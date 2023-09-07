﻿using BasicFacebookFeatures.BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace BasicFacebookFeatures
{
    public partial class PostsForm : Form
    {
        public PostsForm()
        {
            InitializeComponent();
            initializeAddedFeatures();
        }

        private void initializeAddedFeatures()
        {
            initializePostsViewOptionComboBox();
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void fetchPosts()
        {
            //this.Invoke(new Action(() => 
            //{
            //    postBindingSource.DataSource = FacebookManager.Instance.Posts.AllPosts;

            //    if (listBoxPosts.Items.Count == 0)
            //    {
            //        MessageBox.Show("No Posts to retrieve :(");
            //    }
            //    else
            //    {
            //        enablePostsControl();
            //        InitializeComboBoxPostsYears();
            //    }
            //}));

            List<Post> posts = FacebookManager.Instance.Posts.AllPosts;
            postBindingSource.DataSource = posts;
            
            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
            else
            {
                enablePostsControl();
                InitializeComboBoxPostsYears();
            }
        }

        private void enablePostsControl()
        {
            this.Invoke(new Action(() => 
            {
                comboBoxPostsViewOption.Enabled = true;
                comboBoxYears.Enabled = true;
                buttonAnalyzePosts.Enabled = true;
            }));
        }

        private void initializePostsViewOptionComboBox()
        {
            comboBoxPostsViewOption.Items.Add("Posts by Month");
            comboBoxPostsViewOption.Items.Add("Total Posts");
            comboBoxPostsViewOption.SelectedIndex = 0;
        }

        private void InitializeComboBoxPostsYears()
        {
            this.Invoke(new Action(() => 
            {
                comboBoxYears.Items.Clear();
                HashSet<int> yearsWithPosts = new HashSet<int>();
                List<Post> posts = FacebookManager.Instance.Posts.AllPosts;
                foreach (Post post in posts)
                {
                    int year = DateTime.Parse(post.CreatedTime.ToString()).Year;
                    yearsWithPosts.Add(year);
                }

                foreach (int year in yearsWithPosts)
                {
                    comboBoxYears.Items.Add(year);
                }

                if (comboBoxYears.Items.Count > 0)
                {
                    comboBoxYears.SelectedIndex = 0;
                }
            }));
        }

        private void comboBoxPostsViewOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPostsViewOption.SelectedIndex == 0)
            {
                comboBoxYears.Visible = true;
                buttonAnalyzePosts.Visible = true;
                chartPostCountByMonth.Visible = true;
                chartTotalPosts.Visible = false;
            }
            else if (comboBoxPostsViewOption.SelectedIndex == 1)
            {
                comboBoxYears.Visible = false;
                buttonAnalyzePosts.Visible = false;
                chartPostCountByMonth.Visible = false;
                chartTotalPosts.Visible = true;

                CalculateTotalPostsChart();
            }
        }

        private void CalculateTotalPostsChart()
        {
            Dictionary<int, int> totalPostsByYear = FacebookManager.Instance.Posts.CalculateTotalPostsByYear();
            UpdateTotalPostsChart(totalPostsByYear);
        }

        private void UpdateTotalPostsChart(Dictionary<int, int> totalPostsByYear)
        {
            chartTotalPosts.Series.Clear();

            Series series = new Series("Total Posts");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.Color = Color.Red;
            int totalPosts = 0;
            foreach (var entry in totalPostsByYear)
            {
                DataPoint dataPoint = new DataPoint(entry.Key, entry.Value);
                dataPoint.Label = entry.Value.ToString();
                series.Points.Add(dataPoint);
                totalPosts += entry.Value;
            }

            chartTotalPosts.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            chartArea.AxisY.IsStartedFromZero = true;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Interval = 1;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartTotalPosts.ChartAreas.Add(chartArea);
            chartTotalPosts.Series.Add(series);
            chartTotalPosts.Titles.Clear();
            chartTotalPosts.Titles.Add("Total Posts posted: " + totalPosts);
            chartTotalPosts.ChartAreas[0].AxisY.LabelStyle.Enabled = false; // Disable y-axis labels
        }

        private void buttonAnalyzePosts_Click(object sender, EventArgs e)
        {
            CalculatePostCountByMonthChart();
        }

        private void CalculatePostCountByMonthChart()
        {
                
            int selectedYear = (int)comboBoxYears.SelectedItem;
            Dictionary<int, int> postsByMonth = FacebookManager.Instance.Posts.CalculatePostCountByMonth(selectedYear);
            UpdatePostCountByMonthChart(postsByMonth, selectedYear);
        }

        private void UpdatePostCountByMonthChart(Dictionary<int, int> postsByMonth, int selectedYear)
        {
            int totalPostsCount = 0;
            chartPostCountByMonth.Series.Clear();

            Series series = new Series("Posts");
            series.ChartType = SeriesChartType.Column;

            for (int month = 1; month <= 12; month++)
            {
                int count = postsByMonth.ContainsKey(month) ? postsByMonth[month] : 0;
                series.Points.AddXY(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month), count);
                totalPostsCount += count;
            }

            chartPostCountByMonth.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            chartArea.AxisY.IsStartedFromZero = true;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Interval = 1;
            chartArea.AxisX.Interval = 1;

            chartPostCountByMonth.ChartAreas.Add(chartArea);

            chartPostCountByMonth.Series.Add(series);
            chartPostCountByMonth.Titles.Clear();
            chartPostCountByMonth.Titles.Add($"Total Posts in {selectedYear}: {totalPostsCount}");
        }
    }
}