namespace BasicFacebookFeatures
{
    partial class PostsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartTotalPosts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxPostsViewOption = new System.Windows.Forms.ComboBox();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.buttonAnalyzePosts = new System.Windows.Forms.Button();
            this.chartPostCountByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPostCountByMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 55;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Posts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartTotalPosts
            // 
            this.chartTotalPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartTotalPosts.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTotalPosts.Legends.Add(legend3);
            this.chartTotalPosts.Location = new System.Drawing.Point(38, 286);
            this.chartTotalPosts.Name = "chartTotalPosts";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Posts";
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartTotalPosts.Series.Add(series3);
            this.chartTotalPosts.Size = new System.Drawing.Size(734, 109);
            this.chartTotalPosts.TabIndex = 86;
            this.chartTotalPosts.Text = "chart1";
            title3.Name = "Posts";
            this.chartTotalPosts.Titles.Add(title3);
            // 
            // comboBoxPostsViewOption
            // 
            this.comboBoxPostsViewOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPostsViewOption.Enabled = false;
            this.comboBoxPostsViewOption.FormattingEnabled = true;
            this.comboBoxPostsViewOption.Location = new System.Drawing.Point(33, 250);
            this.comboBoxPostsViewOption.Name = "comboBoxPostsViewOption";
            this.comboBoxPostsViewOption.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPostsViewOption.TabIndex = 85;
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYears.Enabled = false;
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(160, 250);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYears.TabIndex = 84;
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
            // 
            // chartPostCountByMonth
            // 
            this.chartPostCountByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartPostCountByMonth.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPostCountByMonth.Legends.Add(legend4);
            this.chartPostCountByMonth.Location = new System.Drawing.Point(33, 290);
            this.chartPostCountByMonth.Name = "chartPostCountByMonth";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Posts";
            series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartPostCountByMonth.Series.Add(series4);
            this.chartPostCountByMonth.Size = new System.Drawing.Size(734, 109);
            this.chartPostCountByMonth.TabIndex = 82;
            this.chartPostCountByMonth.Text = "chart1";
            title4.Name = "Posts";
            this.chartPostCountByMonth.Titles.Add(title4);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 24;
            this.listBoxPosts.Location = new System.Drawing.Point(19, 71);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(119, 148);
            this.listBoxPosts.TabIndex = 71;
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.linkPosts.Location = new System.Drawing.Point(19, 17);
            this.linkPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(245, 35);
            this.linkPosts.TabIndex = 72;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch Posts\r\n(Click on a post to view the comments!)\r\n";
            this.linkPosts.UseCompatibleTextRendering = true;
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "PostsForm";
            this.Text = "PostsForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPostCountByMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalPosts;
        private System.Windows.Forms.ComboBox comboBoxPostsViewOption;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.Button buttonAnalyzePosts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPostCountByMonth;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.LinkLabel linkPosts;
    }
}