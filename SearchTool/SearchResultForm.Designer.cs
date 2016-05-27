namespace SearchTool
{
    partial class SearchResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._searchResultTreeView = new System.Windows.Forms.TreeView();
            this._fileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this._fileContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._searchResultTreeView);
            this.splitContainer1.Size = new System.Drawing.Size(733, 316);
            this.splitContainer1.SplitterDistance = 579;
            this.splitContainer1.TabIndex = 0;
            // 
            // _searchResultTreeView
            // 
            this._searchResultTreeView.ContextMenuStrip = this._fileContextMenu;
            this._searchResultTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._searchResultTreeView.FullRowSelect = true;
            this._searchResultTreeView.Location = new System.Drawing.Point(0, 0);
            this._searchResultTreeView.Name = "_searchResultTreeView";
            this._searchResultTreeView.Size = new System.Drawing.Size(579, 316);
            this._searchResultTreeView.TabIndex = 0;
            this._searchResultTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.onRightClickNode);
            this._searchResultTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.onDoubleClick);
            // 
            // _fileContextMenu
            // 
            this._fileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileLocationToolStripMenuItem});
            this._fileContextMenu.Name = "_fileContextMenu";
            this._fileContextMenu.Size = new System.Drawing.Size(174, 26);
            // 
            // openFileLocationToolStripMenuItem
            // 
            this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openFileLocationToolStripMenuItem.Text = "Open File Location";
            this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.onOpenFileLocation);
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 316);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SearchResultForm";
            this.Text = "Search Results";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this._fileContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView _searchResultTreeView;
        private System.Windows.Forms.ContextMenuStrip _fileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileLocationToolStripMenuItem;
    }
}