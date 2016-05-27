using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchTool
{
    public partial class SearchForm : Form
    {
        String _searchString = string.Empty;
        List<Task> _tasks;
        Stopwatch sw;
        string _baseDirectory = @"C:\Users\Ayodele\Documents\";
        SearchResultForm srf;

        public SearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On Search Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void onSearch(object sender, EventArgs e)
        {
            ResetAllFields();
            sw = new Stopwatch();
            sw.Start();
            _searchString = (string)_searchTextBox.Invoke(new Func<string>(() => _searchTextBox.Text));
            _searchString = string.Concat("*", _searchString, "*");
            int subDirectoryCount = 0;
            getSubDirectoryCount(_baseDirectory, ref subDirectoryCount);
            if (subDirectoryCount > 0)
            {
                _searchProgressBar.Invoke(new Action(() => _searchProgressBar.Maximum = (subDirectoryCount + 1)));
                _searchStatus.Invoke(new Action(() => _searchStatus.Text = "Searching"));
                _tasks = new List<Task>();
                srf = new SearchResultForm();
                srf.Show();

                IEnumerable<string> topDirectories = getTopDirectories(_baseDirectory);
                if (topDirectories != Enumerable.Empty<string>())
                {
                    foreach (var dir in topDirectories)
                    {
                        Task t2 = Task.Run(() => runSearch(dir));
                        _tasks.Add(t2);
                    }
                    Task t1 = Task.Run(() => runSearchInBaseDirectory()); // Also search in the base Directory
                    _tasks.Add(t1);
                }

                if (_tasks.Count > 0)
                    await Task.WhenAll(_tasks.ToArray()); // Don't switch back to main thread until ALL tasks are done processing.

                sw.Stop();
                _searchStatus.Invoke(new Action(() => _searchStatus.Text = "Done"));
                _timerLabel.Invoke(new Action(() => _timerLabel.Text = string.Format("{0}", sw.Elapsed.TotalSeconds.ToString())));
            }
            else
            {
                MessageBoxHelper.Error(this, @"There are no SubDirectories to Search");
            }
            if (srf.FileResultCount == 0)
            {
                MessageBoxHelper.Error(this, "No files were Found!");
                srf.Close();
            }

        }

        private void findFiles(string dirToSearch, ref IEnumerable<string> foundFiles)
        {
            try
            {
                IEnumerable<string> subDirectories = Directory.EnumerateDirectories(dirToSearch);
                foreach (var dir in subDirectories)
                {
                    findFiles(dir, ref foundFiles);
                }
            }
            catch (UnauthorizedAccessException)
            {
                //Move to the next file
            }

            try
            {
                foundFiles = foundFiles.Concat(getFilesFromDirectory(dirToSearch));
            }
            catch (UnauthorizedAccessException)
            {
                //Move to the Next File
            }
            _searchProgressBar.Invoke(new Action(() => _searchProgressBar.Increment(1)));

        }

        private void runSearch(string Dir)
        {
            if (!string.IsNullOrEmpty(_searchString))
            {
                IEnumerable<string> foundFiles = Enumerable.Empty<string>();
                findFiles(Dir, ref foundFiles);
                if (foundFiles != Enumerable.Empty<string>())
                {
                    addFileToView(foundFiles);
                }
            }
        }

        private void runSearchInBaseDirectory()
        {
            if (!string.IsNullOrEmpty(_searchString))
            {
                try
                {
                    IEnumerable<string> foundFiles = getFilesFromDirectory(_baseDirectory);
                    if (foundFiles != Enumerable.Empty<string>())
                    {
                        addFileToView(foundFiles);
                    }
                }
                catch (UnauthorizedAccessException) { }
            }
        }

        private void onTextChanged(object sender, EventArgs e)
        {
            _enterButton.Enabled = false;
            if (!string.IsNullOrEmpty(_searchTextBox.Text))
            {
                _enterButton.Enabled = true;
            }
        }

        private void getSubDirectoryCount(string directory, ref int subDirectoryCount)
        {
            try
            {
                IEnumerable<string> subDirectories = Directory.EnumerateDirectories(directory);//Get Top Directories Only
                foreach (var dir in subDirectories)
                {
                    getSubDirectoryCount(dir, ref subDirectoryCount);
                }

                subDirectoryCount += subDirectories.ToList().Count;
            }
            catch (UnauthorizedAccessException)
            {
                // Move on to the Next file             
            }
        }

        public IEnumerable<string> getTopDirectories(string dir)
        {
            if (!string.IsNullOrEmpty(dir))
            {
                return Directory.EnumerateDirectories(dir);

            }
            return Enumerable.Empty<string>();
        }

        private void addFileToView(IEnumerable<string> files)
        {

            srf.Invoke(new Action(() => srf.AddNewFileToNode(files)));
        }

        private void onShowInfo(object sender, EventArgs e)
        {
            MessageBoxHelper.Info(this, @"This tool Search files in the ""C:\Documents"" Directory");
        }

        private IEnumerable<string> getFilesFromDirectory(string dirToSearch)
        {
            return Directory.EnumerateFiles(dirToSearch, _searchString);
        }

        private void ResetAllFields()
        {
            _searchProgressBar.Maximum = 0;
            _searchProgressBar.Minimum = 1;
            _timerLabel.Text = "";
        }
    }

}
