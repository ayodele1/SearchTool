using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SearchTool
{
    public partial class SearchResultForm : Form
    {
        List<String> files;
        private int _fileResultCount = 0;

        public int FileResultCount
        {
            get { return _fileResultCount; }
            set { _fileResultCount = value; }
        }

        public SearchResultForm()
        {
            InitializeComponent();

        }

        public SearchResultForm(List<string> fileList)
            : this()
        {
            files = fileList;
            foreach (string file in files)
            {
                TreeNode node = _searchResultTreeView.Nodes.Add(file);
            }
        }

        private void _searchResultTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        public void AddNewFileToNode(IEnumerable<string> files)
        {
            foreach (var file in files)
            {
                TreeNode node = _searchResultTreeView.Nodes.Add(file);
                _searchResultTreeView.SelectedNode = node;
                _fileResultCount++;
            }



        }

        private void onDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OpenFileInExplorer(e.Node.Text);
        }

        private void onOpenFileLocation(object sender, EventArgs e)
        {
            OpenFileInExplorer(_searchResultTreeView.SelectedNode.Text);
        }

        private void OpenFileInExplorer(string filename)
        {
            System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filename));
        }

        private void onRightClickNode(object sender, TreeNodeMouseClickEventArgs e)
        {
            _searchResultTreeView.SelectedNode = e.Node;
        }
    }
}
