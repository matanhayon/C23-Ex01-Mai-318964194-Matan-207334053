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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.linkAlbums = new System.Windows.Forms.LinkLabel();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.linkPages = new System.Windows.Forms.LinkLabel();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.comboBoxAlbumsSortOption = new System.Windows.Forms.ComboBox();
            this.SortByAlbumsLabel = new System.Windows.Forms.Label();
            this.pictureBoxPhotos = new System.Windows.Forms.PictureBox();
            this.buttonPreviousPhoto = new System.Windows.Forms.Button();
            this.buttonNextPhoto = new System.Windows.Forms.Button();
            this.buttonDownloadAlbum = new System.Windows.Forms.Button();
            this.chartPostCountByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonAnalyzePosts = new System.Windows.Forms.Button();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.comboBoxPostsViewOption = new System.Windows.Forms.ComboBox();
            this.chartTotalPosts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPostCountByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalPosts)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartTotalPosts);
            this.tabPage1.Controls.Add(this.comboBoxPostsViewOption);
            this.tabPage1.Controls.Add(this.comboBoxYears);
            this.tabPage1.Controls.Add(this.buttonAnalyzePosts);
            this.tabPage1.Controls.Add(this.chartPostCountByMonth);
            this.tabPage1.Controls.Add(this.buttonDownloadAlbum);
            this.tabPage1.Controls.Add(this.buttonNextPhoto);
            this.tabPage1.Controls.Add(this.buttonPreviousPhoto);
            this.tabPage1.Controls.Add(this.pictureBoxPhotos);
            this.tabPage1.Controls.Add(this.SortByAlbumsLabel);
            this.tabPage1.Controls.Add(this.comboBoxAlbumsSortOption);
            this.tabPage1.Controls.Add(this.listBoxPosts);
            this.tabPage1.Controls.Add(this.linkPosts);
            this.tabPage1.Controls.Add(this.pictureBoxPage);
            this.tabPage1.Controls.Add(this.listBoxPages);
            this.tabPage1.Controls.Add(this.linkPages);
            this.tabPage1.Controls.Add(this.listBoxAlbums);
            this.tabPage1.Controls.Add(this.linkAlbums);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1399, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FakeBook";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(132, 17);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(94, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 56);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // linkAlbums
            // 
            this.linkAlbums.AutoSize = true;
            this.linkAlbums.Enabled = false;
            this.linkAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkAlbums.Location = new System.Drawing.Point(18, 223);
            this.linkAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAlbums.Name = "linkAlbums";
            this.linkAlbums.Size = new System.Drawing.Size(344, 47);
            this.linkAlbums.TabIndex = 65;
            this.linkAlbums.TabStop = true;
            this.linkAlbums.Text = "Fetch Albums\r\n(Click an album to view its cover picture)";
            this.linkAlbums.UseCompatibleTextRendering = true;
            this.linkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlbums_LinkClicked);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 22;
            this.listBoxAlbums.Location = new System.Drawing.Point(18, 344);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(273, 92);
            this.listBoxAlbums.TabIndex = 63;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // linkPages
            // 
            this.linkPages.AutoSize = true;
            this.linkPages.Enabled = false;
            this.linkPages.LinkArea = new System.Windows.Forms.LinkArea(0, 17);
            this.linkPages.Location = new System.Drawing.Point(403, 240);
            this.linkPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPages.Name = "linkPages";
            this.linkPages.Size = new System.Drawing.Size(302, 47);
            this.linkPages.TabIndex = 68;
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
            this.listBoxPages.Location = new System.Drawing.Point(403, 291);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(302, 180);
            this.listBoxPages.TabIndex = 66;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxPage.Location = new System.Drawing.Point(403, 479);
            this.pictureBoxPage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(302, 169);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPage.TabIndex = 67;
            this.pictureBoxPage.TabStop = false;
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.Enabled = false;
            this.linkPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.linkPosts.Location = new System.Drawing.Point(403, 17);
            this.linkPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(345, 47);
            this.linkPosts.TabIndex = 70;
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
            this.listBoxPosts.Location = new System.Drawing.Point(403, 72);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(973, 148);
            this.listBoxPosts.TabIndex = 69;
            // 
            // comboBoxAlbumsSortOption
            // 
            this.comboBoxAlbumsSortOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlbumsSortOption.Enabled = false;
            this.comboBoxAlbumsSortOption.FormattingEnabled = true;
            this.comboBoxAlbumsSortOption.Location = new System.Drawing.Point(18, 307);
            this.comboBoxAlbumsSortOption.Name = "comboBoxAlbumsSortOption";
            this.comboBoxAlbumsSortOption.Size = new System.Drawing.Size(273, 30);
            this.comboBoxAlbumsSortOption.TabIndex = 71;
            this.comboBoxAlbumsSortOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbumsSortOption_SelectedIndexChanged);
            // 
            // SortByAlbumsLabel
            // 
            this.SortByAlbumsLabel.AutoSize = true;
            this.SortByAlbumsLabel.Location = new System.Drawing.Point(14, 277);
            this.SortByAlbumsLabel.Name = "SortByAlbumsLabel";
            this.SortByAlbumsLabel.Size = new System.Drawing.Size(74, 24);
            this.SortByAlbumsLabel.TabIndex = 72;
            this.SortByAlbumsLabel.Text = "Sort By:";
            // 
            // pictureBoxPhotos
            // 
            this.pictureBoxPhotos.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxPhotos.Location = new System.Drawing.Point(18, 443);
            this.pictureBoxPhotos.Name = "pictureBoxPhotos";
            this.pictureBoxPhotos.Size = new System.Drawing.Size(273, 215);
            this.pictureBoxPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhotos.TabIndex = 73;
            this.pictureBoxPhotos.TabStop = false;
            // 
            // buttonPreviousPhoto
            // 
            this.buttonPreviousPhoto.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPreviousPhoto.Enabled = false;
            this.buttonPreviousPhoto.Location = new System.Drawing.Point(18, 616);
            this.buttonPreviousPhoto.Name = "buttonPreviousPhoto";
            this.buttonPreviousPhoto.Size = new System.Drawing.Size(34, 40);
            this.buttonPreviousPhoto.TabIndex = 74;
            this.buttonPreviousPhoto.Text = "←";
            this.buttonPreviousPhoto.UseVisualStyleBackColor = false;
            this.buttonPreviousPhoto.Click += new System.EventHandler(this.buttonPreviousPhoto_Click);
            // 
            // buttonNextPhoto
            // 
            this.buttonNextPhoto.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNextPhoto.Enabled = false;
            this.buttonNextPhoto.Location = new System.Drawing.Point(257, 619);
            this.buttonNextPhoto.Name = "buttonNextPhoto";
            this.buttonNextPhoto.Size = new System.Drawing.Size(34, 40);
            this.buttonNextPhoto.TabIndex = 75;
            this.buttonNextPhoto.Text = "→";
            this.buttonNextPhoto.UseVisualStyleBackColor = false;
            this.buttonNextPhoto.Click += new System.EventHandler(this.buttonNextPhoto_Click);
            // 
            // buttonDownloadAlbum
            // 
            this.buttonDownloadAlbum.Enabled = false;
            this.buttonDownloadAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadAlbum.Location = new System.Drawing.Point(166, 276);
            this.buttonDownloadAlbum.Name = "buttonDownloadAlbum";
            this.buttonDownloadAlbum.Size = new System.Drawing.Size(129, 28);
            this.buttonDownloadAlbum.TabIndex = 76;
            this.buttonDownloadAlbum.Text = "Download Album";
            this.buttonDownloadAlbum.UseVisualStyleBackColor = true;
            this.buttonDownloadAlbum.Click += new System.EventHandler(this.buttonDownloadAlbum_Click);
            // 
            // chartPostCountByMonth
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPostCountByMonth.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPostCountByMonth.Legends.Add(legend2);
            this.chartPostCountByMonth.Location = new System.Drawing.Point(726, 277);
            this.chartPostCountByMonth.Name = "chartPostCountByMonth";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Posts";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartPostCountByMonth.Series.Add(series2);
            this.chartPostCountByMonth.Size = new System.Drawing.Size(665, 350);
            this.chartPostCountByMonth.TabIndex = 77;
            this.chartPostCountByMonth.Text = "chart1";
            title2.Name = "Posts";
            this.chartPostCountByMonth.Titles.Add(title2);
            // 
            // buttonAnalyzePosts
            // 
            this.buttonAnalyzePosts.Enabled = false;
            this.buttonAnalyzePosts.Location = new System.Drawing.Point(980, 230);
            this.buttonAnalyzePosts.Name = "buttonAnalyzePosts";
            this.buttonAnalyzePosts.Size = new System.Drawing.Size(145, 43);
            this.buttonAnalyzePosts.TabIndex = 78;
            this.buttonAnalyzePosts.Text = "Analyze Posts";
            this.buttonAnalyzePosts.UseVisualStyleBackColor = true;
            this.buttonAnalyzePosts.Click += new System.EventHandler(this.buttonAnalyzePosts_Click);
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYears.Enabled = false;
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(853, 237);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(121, 30);
            this.comboBoxYears.TabIndex = 79;
            // 
            // comboBoxPostsViewOption
            // 
            this.comboBoxPostsViewOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPostsViewOption.Enabled = false;
            this.comboBoxPostsViewOption.FormattingEnabled = true;
            this.comboBoxPostsViewOption.Location = new System.Drawing.Point(726, 237);
            this.comboBoxPostsViewOption.Name = "comboBoxPostsViewOption";
            this.comboBoxPostsViewOption.Size = new System.Drawing.Size(121, 30);
            this.comboBoxPostsViewOption.TabIndex = 80;
            this.comboBoxPostsViewOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostsViewOption_SelectedIndexChanged);
            // 
            // chartTotalPosts
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTotalPosts.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTotalPosts.Legends.Add(legend1);
            this.chartTotalPosts.Location = new System.Drawing.Point(731, 277);
            this.chartTotalPosts.Name = "chartTotalPosts";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Posts";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartTotalPosts.Series.Add(series1);
            this.chartTotalPosts.Size = new System.Drawing.Size(665, 350);
            this.chartTotalPosts.TabIndex = 81;
            this.chartTotalPosts.Text = "chart1";
            title1.Name = "Posts";
            this.chartTotalPosts.Titles.Add(title1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPostCountByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalPosts)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalPosts;
        private System.Windows.Forms.ComboBox comboBoxPostsViewOption;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.Button buttonAnalyzePosts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPostCountByMonth;
        private System.Windows.Forms.Button buttonDownloadAlbum;
        private System.Windows.Forms.Button buttonNextPhoto;
        private System.Windows.Forms.Button buttonPreviousPhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhotos;
        private System.Windows.Forms.Label SortByAlbumsLabel;
        private System.Windows.Forms.ComboBox comboBoxAlbumsSortOption;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.LinkLabel linkPages;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.LinkLabel linkAlbums;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

