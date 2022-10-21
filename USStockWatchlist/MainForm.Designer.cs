namespace USStockWatchlist
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param Name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stocksGridView = new System.Windows.Forms.DataGridView();
            this.symbolsTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sortTypesGroupBox = new System.Windows.Forms.GroupBox();
            this.PercentageChangeRadioButton = new System.Windows.Forms.RadioButton();
            this.AlphabeticalRadioButton = new System.Windows.Forms.RadioButton();
            this.customRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stocksGridView)).BeginInit();
            this.sortTypesGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stocksGridView
            // 
            this.stocksGridView.AllowUserToAddRows = false;
            this.stocksGridView.AllowUserToDeleteRows = false;
            this.stocksGridView.AllowUserToResizeColumns = false;
            this.stocksGridView.AllowUserToResizeRows = false;
            this.stocksGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stocksGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.stocksGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stocksGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.stocksGridView.ColumnHeadersHeight = 20;
            this.stocksGridView.ColumnHeadersVisible = false;
            this.stocksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.currentPrice,
            this.Column3});
            this.stocksGridView.Location = new System.Drawing.Point(112, 110);
            this.stocksGridView.Name = "stocksGridView";
            this.stocksGridView.ReadOnly = true;
            this.stocksGridView.RowHeadersVisible = false;
            this.stocksGridView.RowHeadersWidth = 40;
            this.stocksGridView.RowTemplate.Height = 50;
            this.stocksGridView.RowTemplate.ReadOnly = true;
            this.stocksGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stocksGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stocksGridView.Size = new System.Drawing.Size(451, 266);
            this.stocksGridView.TabIndex = 0;
            this.stocksGridView.SelectionChanged += new System.EventHandler(this.GridViewSelectionChanged);
            // 
            // symbolsTextBox
            // 
            this.symbolsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.symbolsTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolsTextBox.Location = new System.Drawing.Point(16, 110);
            this.symbolsTextBox.Multiline = true;
            this.symbolsTextBox.Name = "symbolsTextBox";
            this.symbolsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.symbolsTextBox.Size = new System.Drawing.Size(90, 230);
            this.symbolsTextBox.TabIndex = 1;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(16, 346);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(90, 30);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButtonDidClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Symbols";
            // 
            // sortTypesGroupBox
            // 
            this.sortTypesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortTypesGroupBox.Controls.Add(this.PercentageChangeRadioButton);
            this.sortTypesGroupBox.Controls.Add(this.AlphabeticalRadioButton);
            this.sortTypesGroupBox.Controls.Add(this.customRadioButton);
            this.sortTypesGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortTypesGroupBox.Location = new System.Drawing.Point(249, 60);
            this.sortTypesGroupBox.Name = "sortTypesGroupBox";
            this.sortTypesGroupBox.Size = new System.Drawing.Size(314, 44);
            this.sortTypesGroupBox.TabIndex = 9;
            this.sortTypesGroupBox.TabStop = false;
            this.sortTypesGroupBox.Text = "Sort";
            // 
            // PercentageChangeRadioButton
            // 
            this.PercentageChangeRadioButton.AutoSize = true;
            this.PercentageChangeRadioButton.Location = new System.Drawing.Point(170, 18);
            this.PercentageChangeRadioButton.Name = "PercentageChangeRadioButton";
            this.PercentageChangeRadioButton.Size = new System.Drawing.Size(135, 19);
            this.PercentageChangeRadioButton.TabIndex = 2;
            this.PercentageChangeRadioButton.TabStop = true;
            this.PercentageChangeRadioButton.Text = "Percentage Change";
            this.PercentageChangeRadioButton.UseVisualStyleBackColor = true;
            this.PercentageChangeRadioButton.Click += new System.EventHandler(this.SortTypeRadioButtonDidClick);
            // 
            // AlphabeticalRadioButton
            // 
            this.AlphabeticalRadioButton.AutoSize = true;
            this.AlphabeticalRadioButton.Location = new System.Drawing.Point(78, 18);
            this.AlphabeticalRadioButton.Name = "AlphabeticalRadioButton";
            this.AlphabeticalRadioButton.Size = new System.Drawing.Size(92, 19);
            this.AlphabeticalRadioButton.TabIndex = 1;
            this.AlphabeticalRadioButton.TabStop = true;
            this.AlphabeticalRadioButton.Text = "Alphabetical";
            this.AlphabeticalRadioButton.UseVisualStyleBackColor = true;
            this.AlphabeticalRadioButton.Click += new System.EventHandler(this.SortTypeRadioButtonDidClick);
            // 
            // customRadioButton
            // 
            this.customRadioButton.AutoSize = true;
            this.customRadioButton.Checked = true;
            this.customRadioButton.Location = new System.Drawing.Point(12, 18);
            this.customRadioButton.Name = "customRadioButton";
            this.customRadioButton.Size = new System.Drawing.Size(69, 19);
            this.customRadioButton.TabIndex = 0;
            this.customRadioButton.TabStop = true;
            this.customRadioButton.Text = "Custom";
            this.customRadioButton.UseVisualStyleBackColor = true;
            this.customRadioButton.Click += new System.EventHandler(this.SortTypeRadioButtonDidClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "U.S. Stock Watchlist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data provided by";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.Location = new System.Drawing.Point(404, 23);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(139, 15);
            this.linkLabel.TabIndex = 14;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Financial Modeling Prep";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelDidClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Icon";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 50;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Symbol";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 5;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Company Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // currentPrice
            // 
            this.currentPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.currentPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.currentPrice.HeaderText = "Price";
            this.currentPrice.Name = "currentPrice";
            this.currentPrice.ReadOnly = true;
            this.currentPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.currentPrice.Width = 5;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Change";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sortTypesGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.symbolsTextBox);
            this.Controls.Add(this.stocksGridView);
            this.MaximumSize = new System.Drawing.Size(700, 1000);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stocksGridView)).EndInit();
            this.sortTypesGroupBox.ResumeLayout(false);
            this.sortTypesGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stocksGridView;
        private System.Windows.Forms.TextBox symbolsTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox sortTypesGroupBox;
        private System.Windows.Forms.RadioButton PercentageChangeRadioButton;
        private System.Windows.Forms.RadioButton AlphabeticalRadioButton;
        private System.Windows.Forms.RadioButton customRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

