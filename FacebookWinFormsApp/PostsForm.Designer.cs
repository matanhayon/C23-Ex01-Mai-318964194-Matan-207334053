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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label captionLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.captionTextBox = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chartTotalPosts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxPostsViewOption = new System.Windows.Forms.ComboBox();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.buttonAnalyzePosts = new System.Windows.Forms.Button();
            this.chartPostCountByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.postBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.postBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            captionLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPostCountByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingNavigator)).BeginInit();
            this.postBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // captionLabel
            // 
            captionLabel.AutoSize = true;
            captionLabel.Location = new System.Drawing.Point(17, 22);
            captionLabel.Name = "captionLabel";
            captionLabel.Size = new System.Drawing.Size(56, 16);
            captionLabel.TabIndex = 0;
            captionLabel.Text = "Caption:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(17, 61);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(92, 16);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1270, 450);
            this.tabControl1.TabIndex = 55;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.panel1);
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
            this.tabPage2.Size = new System.Drawing.Size(1262, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Posts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(captionLabel);
            this.panel1.Controls.Add(this.captionTextBox);
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(677, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 148);
            this.panel1.TabIndex = 87;
            // 
            // captionTextBox
            // 
            this.captionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Caption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "[No Caption]"));
            this.captionTextBox.Location = new System.Drawing.Point(255, 22);
            this.captionTextBox.Name = "captionTextBox";
            this.captionTextBox.Size = new System.Drawing.Size(310, 22);
            this.captionTextBox.TabIndex = 1;
            this.captionTextBox.TextChanged += new System.EventHandler(this.captionTextBox_TextChanged);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(255, 61);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(310, 22);
            this.createdTimeDateTimePicker.TabIndex = 3;
            // 
            // chartTotalPosts
            // 
            this.chartTotalPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chartTotalPosts.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartTotalPosts.Legends.Add(legend7);
            this.chartTotalPosts.Location = new System.Drawing.Point(38, 286);
            this.chartTotalPosts.Name = "chartTotalPosts";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Posts";
            series7.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartTotalPosts.Series.Add(series7);
            this.chartTotalPosts.Size = new System.Drawing.Size(1204, 109);
            this.chartTotalPosts.TabIndex = 86;
            this.chartTotalPosts.Text = "chart1";
            title7.Name = "Posts";
            this.chartTotalPosts.Titles.Add(title7);
            // 
            // comboBoxPostsViewOption
            // 
            this.comboBoxPostsViewOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPostsViewOption.Enabled = false;
            this.comboBoxPostsViewOption.FormattingEnabled = true;
            this.comboBoxPostsViewOption.Location = new System.Drawing.Point(9, 250);
            this.comboBoxPostsViewOption.Name = "comboBoxPostsViewOption";
            this.comboBoxPostsViewOption.Size = new System.Drawing.Size(188, 24);
            this.comboBoxPostsViewOption.TabIndex = 85;
            this.comboBoxPostsViewOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostsViewOption_SelectedIndexChanged);
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYears.Enabled = false;
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(214, 250);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(188, 24);
            this.comboBoxYears.TabIndex = 84;
            // 
            // buttonAnalyzePosts
            // 
            this.buttonAnalyzePosts.Enabled = false;
            this.buttonAnalyzePosts.Location = new System.Drawing.Point(415, 237);
            this.buttonAnalyzePosts.Name = "buttonAnalyzePosts";
            this.buttonAnalyzePosts.Size = new System.Drawing.Size(145, 43);
            this.buttonAnalyzePosts.TabIndex = 83;
            this.buttonAnalyzePosts.Text = "Analyze Posts";
            this.buttonAnalyzePosts.UseVisualStyleBackColor = true;
            this.buttonAnalyzePosts.Click += new System.EventHandler(this.buttonAnalyzePosts_Click);
            // 
            // chartPostCountByMonth
            // 
            this.chartPostCountByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Name = "ChartArea1";
            this.chartPostCountByMonth.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartPostCountByMonth.Legends.Add(legend8);
            this.chartPostCountByMonth.Location = new System.Drawing.Point(33, 290);
            this.chartPostCountByMonth.Name = "chartPostCountByMonth";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Posts";
            series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartPostCountByMonth.Series.Add(series8);
            this.chartPostCountByMonth.Size = new System.Drawing.Size(1204, 109);
            this.chartPostCountByMonth.TabIndex = 82;
            this.chartPostCountByMonth.Text = "chart1";
            title8.Name = "Posts";
            this.chartPostCountByMonth.Titles.Add(title8);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.DisplayMember = "Description";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 24;
            this.listBoxPosts.Location = new System.Drawing.Point(19, 71);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(796, 148);
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
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // postBindingNavigator
            // 
            this.postBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.postBindingNavigator.BindingSource = this.postBindingSource;
            this.postBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.postBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.postBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.postBindingNavigatorSaveItem});
            this.postBindingNavigator.Location = new System.Drawing.Point(0, 423);
            this.postBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.postBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.postBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.postBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.postBindingNavigator.Name = "postBindingNavigator";
            this.postBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.postBindingNavigator.Size = new System.Drawing.Size(1270, 27);
            this.postBindingNavigator.TabIndex = 56;
            this.postBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // postBindingNavigatorSaveItem
            // 
            this.postBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postBindingNavigatorSaveItem.Enabled = false;
            this.postBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postBindingNavigatorSaveItem.Image")));
            this.postBindingNavigatorSaveItem.Name = "postBindingNavigatorSaveItem";
            this.postBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.postBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 450);
            this.Controls.Add(this.postBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "PostsForm";
            this.Text = "PostsForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPostCountByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingNavigator)).EndInit();
            this.postBindingNavigator.ResumeLayout(false);
            this.postBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.BindingNavigator postBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton postBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox captionTextBox;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
    }
}