namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkPages = new System.Windows.Forms.LinkLabel();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkAlbums = new System.Windows.Forms.LinkLabel();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.comboBoxAlbumsSortOption = new System.Windows.Forms.ComboBox();
            this.SortByAlbumsLabel = new System.Windows.Forms.Label();
            this.pictureBoxPhotos = new System.Windows.Forms.PictureBox();
            this.buttonPreviousPhoto = new System.Windows.Forms.Button();
            this.buttonNextPhoto = new System.Windows.Forms.Button();
            this.buttonDownloadAlbum = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.chartPostCountByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonAnalyzePosts = new System.Windows.Forms.Button();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.comboBoxPostsViewOption = new System.Windows.Forms.ComboBox();
            this.chartTotalPosts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPostCountByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalPosts)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBoxPage);
            this.tabPage4.Controls.Add(this.listBoxPages);
            this.tabPage4.Controls.Add(this.linkPages);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1399, 662);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pages";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // linkPages
            // 
            this.linkPages.AutoSize = true;
            this.linkPages.LinkArea = new System.Windows.Forms.LinkArea(0, 17);
            this.linkPages.Location = new System.Drawing.Point(25, 15);
            this.linkPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPages.Name = "linkPages";
            this.linkPages.Size = new System.Drawing.Size(302, 47);
            this.linkPages.TabIndex = 71;
            this.linkPages.TabStop = true;
            this.linkPages.Text = "Fetch Liked Pages \r\n(Click on a page to view it\'s picture)";
            this.linkPages.UseCompatibleTextRendering = true;
            this.linkPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPages_LinkClicked);
            // 
            // listBoxPages
            // 
            this.listBoxPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPages.DisplayMember = "name";
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 22;
            this.listBoxPages.Location = new System.Drawing.Point(25, 75);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(1185, 70);
            this.listBoxPages.TabIndex = 69;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxPage.Location = new System.Drawing.Point(25, 153);
            this.pictureBoxPage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(1185, 419);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPage.TabIndex = 70;
            this.pictureBoxPage.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonDownloadAlbum);
            this.tabPage3.Controls.Add(this.buttonNextPhoto);
            this.tabPage3.Controls.Add(this.buttonPreviousPhoto);
            this.tabPage3.Controls.Add(this.pictureBoxPhotos);
            this.tabPage3.Controls.Add(this.SortByAlbumsLabel);
            this.tabPage3.Controls.Add(this.comboBoxAlbumsSortOption);
            this.tabPage3.Controls.Add(this.listBoxAlbums);
            this.tabPage3.Controls.Add(this.linkAlbums);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1399, 662);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Albums";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkAlbums
            // 
            this.linkAlbums.AutoSize = true;
            this.linkAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkAlbums.Location = new System.Drawing.Point(23, 27);
            this.linkAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAlbums.Name = "linkAlbums";
            this.linkAlbums.Size = new System.Drawing.Size(344, 47);
            this.linkAlbums.TabIndex = 78;
            this.linkAlbums.TabStop = true;
            this.linkAlbums.Text = "Fetch Albums\r\n(Click an album to view its cover picture)";
            this.linkAlbums.UseCompatibleTextRendering = true;
            this.linkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlbums_LinkClicked);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 22;
            this.listBoxAlbums.Location = new System.Drawing.Point(375, 27);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(725, 136);
            this.listBoxAlbums.TabIndex = 77;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // comboBoxAlbumsSortOption
            // 
            this.comboBoxAlbumsSortOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlbumsSortOption.Enabled = false;
            this.comboBoxAlbumsSortOption.FormattingEnabled = true;
            this.comboBoxAlbumsSortOption.Location = new System.Drawing.Point(23, 122);
            this.comboBoxAlbumsSortOption.Name = "comboBoxAlbumsSortOption";
            this.comboBoxAlbumsSortOption.Size = new System.Drawing.Size(273, 30);
            this.comboBoxAlbumsSortOption.TabIndex = 79;
            this.comboBoxAlbumsSortOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbumsSortOption_SelectedIndexChanged);
            // 
            // SortByAlbumsLabel
            // 
            this.SortByAlbumsLabel.AutoSize = true;
            this.SortByAlbumsLabel.Location = new System.Drawing.Point(19, 92);
            this.SortByAlbumsLabel.Name = "SortByAlbumsLabel";
            this.SortByAlbumsLabel.Size = new System.Drawing.Size(74, 24);
            this.SortByAlbumsLabel.TabIndex = 80;
            this.SortByAlbumsLabel.Text = "Sort By:";
            // 
            // pictureBoxPhotos
            // 
            this.pictureBoxPhotos.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxPhotos.Location = new System.Drawing.Point(151, 185);
            this.pictureBoxPhotos.Name = "pictureBoxPhotos";
            this.pictureBoxPhotos.Size = new System.Drawing.Size(1078, 438);
            this.pictureBoxPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhotos.TabIndex = 81;
            this.pictureBoxPhotos.TabStop = false;
            // 
            // buttonPreviousPhoto
            // 
            this.buttonPreviousPhoto.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPreviousPhoto.Enabled = false;
            this.buttonPreviousPhoto.Location = new System.Drawing.Point(39, 552);
            this.buttonPreviousPhoto.Name = "buttonPreviousPhoto";
            this.buttonPreviousPhoto.Size = new System.Drawing.Size(80, 71);
            this.buttonPreviousPhoto.TabIndex = 82;
            this.buttonPreviousPhoto.Text = "←";
            this.buttonPreviousPhoto.UseVisualStyleBackColor = false;
            this.buttonPreviousPhoto.Click += new System.EventHandler(this.buttonPreviousPhoto_Click);
            // 
            // buttonNextPhoto
            // 
            this.buttonNextPhoto.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNextPhoto.Enabled = false;
            this.buttonNextPhoto.Location = new System.Drawing.Point(1260, 552);
            this.buttonNextPhoto.Name = "buttonNextPhoto";
            this.buttonNextPhoto.Size = new System.Drawing.Size(80, 71);
            this.buttonNextPhoto.TabIndex = 83;
            this.buttonNextPhoto.Text = "→";
            this.buttonNextPhoto.UseVisualStyleBackColor = false;
            this.buttonNextPhoto.Click += new System.EventHandler(this.buttonNextPhoto_Click);
            // 
            // buttonDownloadAlbum
            // 
            this.buttonDownloadAlbum.Enabled = false;
            this.buttonDownloadAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadAlbum.Location = new System.Drawing.Point(1151, 53);
            this.buttonDownloadAlbum.Name = "buttonDownloadAlbum";
            this.buttonDownloadAlbum.Size = new System.Drawing.Size(187, 79);
            this.buttonDownloadAlbum.TabIndex = 84;
            this.buttonDownloadAlbum.Text = "Download Album";
            this.buttonDownloadAlbum.UseVisualStyleBackColor = true;
            this.buttonDownloadAlbum.Click += new System.EventHandler(this.buttonDownloadAlbum_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartTotalPosts);
            this.tabPage2.Controls.Add(this.comboBoxPostsViewOption);
            this.tabPage2.Controls.Add(this.comboBoxYears);
            this.tabPage2.Controls.Add(this.buttonAnalyzePosts);
            this.tabPage2.Controls.Add(this.chartPostCountByMonth);
            this.tabPage2.Controls.Add(this.listBoxPosts);
            this.tabPage2.Controls.Add(this.linkPosts);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1399, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Posts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.linkPosts.Location = new System.Drawing.Point(38, 26);
            this.linkPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(345, 47);
            this.linkPosts.TabIndex = 72;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch Posts\r\n(Click on a post to view the comments!)\r\n";
            this.linkPosts.UseCompatibleTextRendering = true;
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 24;
            this.listBoxPosts.Location = new System.Drawing.Point(38, 81);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(726, 148);
            this.listBoxPosts.TabIndex = 71;
            // 
            // chartPostCountByMonth
            // 
            this.chartPostCountByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartPostCountByMonth.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPostCountByMonth.Legends.Add(legend2);
            this.chartPostCountByMonth.Location = new System.Drawing.Point(33, 290);
            this.chartPostCountByMonth.Name = "chartPostCountByMonth";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Posts";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartPostCountByMonth.Series.Add(series2);
            this.chartPostCountByMonth.Size = new System.Drawing.Size(1341, 350);
            this.chartPostCountByMonth.TabIndex = 82;
            this.chartPostCountByMonth.Text = "chart1";
            title2.Name = "Posts";
            this.chartPostCountByMonth.Titles.Add(title2);
            // 
            // buttonAnalyzePosts
            // 
            this.buttonAnalyzePosts.Enabled = false;
            this.buttonAnalyzePosts.Location = new System.Drawing.Point(287, 243);
            this.buttonAnalyzePosts.Name = "buttonAnalyzePosts";
            this.buttonAnalyzePosts.Size = new System.Drawing.Size(145, 43);
            this.buttonAnalyzePosts.TabIndex = 83;
            this.buttonAnalyzePosts.Text = "Analyze Posts";
            this.buttonAnalyzePosts.UseVisualStyleBackColor = true;
            this.buttonAnalyzePosts.Click += new System.EventHandler(this.buttonAnalyzePosts_Click);
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYears.Enabled = false;
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(160, 250);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(121, 30);
            this.comboBoxYears.TabIndex = 84;
            // 
            // comboBoxPostsViewOption
            // 
            this.comboBoxPostsViewOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPostsViewOption.Enabled = false;
            this.comboBoxPostsViewOption.FormattingEnabled = true;
            this.comboBoxPostsViewOption.Location = new System.Drawing.Point(33, 250);
            this.comboBoxPostsViewOption.Name = "comboBoxPostsViewOption";
            this.comboBoxPostsViewOption.Size = new System.Drawing.Size(121, 30);
            this.comboBoxPostsViewOption.TabIndex = 85;
            this.comboBoxPostsViewOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostsViewOption_SelectedIndexChanged);
            // 
            // chartTotalPosts
            // 
            this.chartTotalPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartTotalPosts.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTotalPosts.Legends.Add(legend1);
            this.chartTotalPosts.Location = new System.Drawing.Point(38, 286);
            this.chartTotalPosts.Name = "chartTotalPosts";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Posts";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartTotalPosts.Series.Add(series1);
            this.chartTotalPosts.Size = new System.Drawing.Size(1341, 350);
            this.chartTotalPosts.TabIndex = 86;
            this.chartTotalPosts.Text = "chart1";
            title1.Name = "Posts";
            this.chartTotalPosts.Titles.Add(title1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1407, 697);
            this.tabControl1.TabIndex = 54;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 697);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to FakeBook";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPostCountByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalPosts)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.LinkLabel linkPages;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonDownloadAlbum;
        private System.Windows.Forms.Button buttonNextPhoto;
        private System.Windows.Forms.Button buttonPreviousPhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhotos;
        private System.Windows.Forms.Label SortByAlbumsLabel;
        private System.Windows.Forms.ComboBox comboBoxAlbumsSortOption;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.LinkLabel linkAlbums;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalPosts;
        private System.Windows.Forms.ComboBox comboBoxPostsViewOption;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.Button buttonAnalyzePosts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPostCountByMonth;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

