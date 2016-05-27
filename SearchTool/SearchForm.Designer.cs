namespace SearchTool
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._searchTextBox = new System.Windows.Forms.RichTextBox();
            this._enterButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._searchProgressBar = new System.Windows.Forms.ProgressBar();
            this._searchStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._PictureBox = new System.Windows.Forms.PictureBox();
            this._timerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Controls.Add(this._searchTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._enterButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 71);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _searchTextBox
            // 
            this._searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._searchTextBox.Location = new System.Drawing.Point(3, 3);
            this._searchTextBox.Name = "_searchTextBox";
            this._searchTextBox.Size = new System.Drawing.Size(324, 30);
            this._searchTextBox.TabIndex = 0;
            this._searchTextBox.Text = "";
            this._searchTextBox.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // _enterButton
            // 
            this._enterButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._enterButton.Enabled = false;
            this._enterButton.Location = new System.Drawing.Point(344, 4);
            this._enterButton.Name = "_enterButton";
            this._enterButton.Size = new System.Drawing.Size(109, 27);
            this._enterButton.TabIndex = 1;
            this._enterButton.Text = "Search";
            this._enterButton.UseVisualStyleBackColor = true;
            this._enterButton.Click += new System.EventHandler(this.onSearch);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7037F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.2963F));
            this.tableLayoutPanel2.Controls.Add(this._searchProgressBar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._searchStatus, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 29);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // _searchProgressBar
            // 
            this._searchProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._searchProgressBar.Location = new System.Drawing.Point(3, 3);
            this._searchProgressBar.Minimum = 1;
            this._searchProgressBar.Name = "_searchProgressBar";
            this._searchProgressBar.Size = new System.Drawing.Size(248, 23);
            this._searchProgressBar.Step = 1;
            this._searchProgressBar.TabIndex = 0;
            this._searchProgressBar.Value = 1;
            // 
            // _searchStatus
            // 
            this._searchStatus.AutoSize = true;
            this._searchStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this._searchStatus.Location = new System.Drawing.Point(257, 0);
            this._searchStatus.Name = "_searchStatus";
            this._searchStatus.Size = new System.Drawing.Size(64, 29);
            this._searchStatus.TabIndex = 1;
            this._searchStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.83334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.tableLayoutPanel3.Controls.Add(this._PictureBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this._timerLabel, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(333, 39);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(120, 29);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // _PictureBox
            // 
            this._PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_PictureBox.Image")));
            this._PictureBox.Location = new System.Drawing.Point(87, 3);
            this._PictureBox.Name = "_PictureBox";
            this._PictureBox.Size = new System.Drawing.Size(29, 23);
            this._PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._PictureBox.TabIndex = 0;
            this._PictureBox.TabStop = false;
            this._PictureBox.Click += new System.EventHandler(this.onShowInfo);
            // 
            // _timerLabel
            // 
            this._timerLabel.AutoSize = true;
            this._timerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._timerLabel.Location = new System.Drawing.Point(3, 0);
            this._timerLabel.Name = "_timerLabel";
            this._timerLabel.Size = new System.Drawing.Size(78, 29);
            this._timerLabel.TabIndex = 1;
            this._timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchForm
            // 
            this.AcceptButton = this._enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 71);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(890, 590);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "File Search";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox _searchTextBox;
        private System.Windows.Forms.Button _enterButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar _searchProgressBar;
        private System.Windows.Forms.Label _searchStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox _PictureBox;
        private System.Windows.Forms.Label _timerLabel;
    }
}

