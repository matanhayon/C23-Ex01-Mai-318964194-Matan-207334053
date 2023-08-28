using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.CompilerServices;
using BasicFacebookFeatures.BasicFacebookFeatures;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private FacebookManager m_facebookManager = FacebookManager.Instance;
        private FormComposer m_FormComposer;
        private int m_selectedPhotoIndex = -1;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = Int32.MaxValue;
            initializeAddedFeatures();
        }

        private void initializeAddedFeatures()
        {
            
            initializeAlbumsSortingComboBox();
            initializePostsViewOptionComboBox();
        }

        private void initializePostsViewOptionComboBox()
        {
            comboBoxPostsViewOption.Items.Add("Posts by Month");
            comboBoxPostsViewOption.Items.Add("Total Posts");
            comboBoxPostsViewOption.SelectedIndex = 0;
        }

        private void initializeAlbumsSortingComboBox()
        {
            comboBoxAlbumsSortOption.Items.Add("Newest");
            comboBoxAlbumsSortOption.Items.Add("Oldest");
            comboBoxAlbumsSortOption.Items.Add("Largest");
            comboBoxAlbumsSortOption.Items.Add("Smallest");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn())
            {
                login();
            }
        }

        private bool isLoggedIn()
        {
            return m_facebookManager != null;
        }
        
        private void login()
        {
            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                "1576031996471164", //our app id
                /// requested permissions:
                "email", "public_profile", "user_age_range", "user_birthday", "user_events",
                "user_friends", "user_gender", "user_hometown", "user_likes", "user_link",
                "user_location", "user_photos", "user_posts", "user_videos");

            //if (!string.IsNullOrEmpty(loginResult.AccessToken))
            //{
            //    buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
            //    buttonLogin.BackColor = Color.LightGreen;
            //    pictureBoxProfile.ImageLocation = loginResult.LoggedInUser.PictureNormalURL;
            //    buttonLogin.Enabled = false;
            //    buttonLogout.Enabled = true;
            //    tabControl1.TabPages[0].Text = $"{loginResult.LoggedInUser.Name.ToString()}'s wall";
            //    FacebookManager.Initialize(loginResult);
            //    m_facebookManager = FacebookManager.Instance;
            //    enableControlsAfterLoggedIn();
            //}
        }

        private void enableControlsAfterLoggedIn()
        {
            linkPosts.Enabled = true;
            linkAlbums.Enabled = true;
            linkPages.Enabled = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void logOut()
        {
            //FacebookService.LogoutWithUI();
            //buttonLogin.Enabled = true;
            //buttonLogin.Text = "Login";
            //buttonLogin.BackColor = buttonLogout.BackColor;
            //buttonLogout.Enabled = false;
            //m_facebookManager = null;
            //disabbleControlsAfterLoggedOut();
            //listBoxAlbums.Items.Clear();
            //listBoxPages.Items.Clear();
            //listBoxPosts.Items.Clear();
            //chartPostCountByMonth.Series.Clear();
            //chartPostCountByMonth.Titles.Clear();
            //chartTotalPosts.Series.Clear();
            //chartTotalPosts.Titles.Clear();
            //pictureBoxPhotos.Image = null;
            //pictureBoxPage.Image = null;
            //pictureBoxProfile.Image = null;
            //tabControl1.TabPages[0].Text = "FakeBook";
        }


        private void disabbleControlsAfterLoggedOut()
        {
            disableAlbumsControl();
            disablePagesControl();
            disablePostsControl();
        }

        //Posts Methods:
        private void buttonAnalyzePosts_Click(object sender, EventArgs e)
        {
            CalculatePostCountByMonthChart();
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            if (isLoggedIn())
            {
                listBoxPosts.Items.Clear();
                List<Post> posts = m_facebookManager.Posts.AllPosts;
                foreach (Post post in posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        listBoxPosts.Items.Add(post.Caption);
                    }
                    else
                    {
                        listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }

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
        }

        private void enablePostsControl()
        {
            comboBoxPostsViewOption.Enabled = true;
            comboBoxYears.Enabled = true;
            buttonAnalyzePosts.Enabled = true;
        }

        private void disablePostsControl()
        {
            linkPosts.Enabled = false;
            comboBoxPostsViewOption.Enabled = false;
            comboBoxYears.Enabled = false;
            buttonAnalyzePosts.Enabled = false;
        }

        private void CalculatePostCountByMonthChart()
        {
            if (isLoggedIn())
            {
                int selectedYear = (int)comboBoxYears.SelectedItem;
                Dictionary<int, int> postsByMonth = m_facebookManager.Posts.CalculatePostCountByMonth(selectedYear);
                UpdatePostCountByMonthChart(postsByMonth, selectedYear);
            }
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

        private void InitializeComboBoxPostsYears()
        {
            if (isLoggedIn())
            {
                comboBoxYears.Items.Clear();
                HashSet<int> yearsWithPosts = new HashSet<int>();
                List<Post> posts = m_facebookManager.Posts.AllPosts;
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
                    comboBoxYears.SelectedIndex = 0; // Set the default selected year
                }
            }
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
            if (isLoggedIn())
            {
                Dictionary<int, int> totalPostsByYear = m_facebookManager.Posts.CalculateTotalPostsByYear();
                UpdateTotalPostsChart(totalPostsByYear);
            }
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


        //Albums Methods:
        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isLoggedIn())
            {
                enableAlbumsControl();
                SortAlbums();
            }
        }

        private void enableAlbumsControl()
        {
            buttonDownloadAlbum.Enabled = true;
            comboBoxAlbumsSortOption.Enabled = true;
            buttonNextPhoto.Enabled = true;
            buttonPreviousPhoto.Enabled = true;
        }
        
        private void disableAlbumsControl()
        {
            linkAlbums.Enabled = false;
            buttonDownloadAlbum.Enabled = false;
            comboBoxAlbumsSortOption.Enabled = false;
            buttonNextPhoto.Enabled = false;
            buttonPreviousPhoto.Enabled = false;
        }
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void buttonDownloadAlbum_Click(object sender, EventArgs e)
        {
            downloadAlbum();
        }

        private void buttonPreviousPhoto_Click(object sender, EventArgs e)
        {
            if (m_selectedPhotoIndex > 0)
            {
                m_selectedPhotoIndex--;
                displaySelectedPhoto();
            }
        }

        private void buttonNextPhoto_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
            if (selectedAlbum != null && m_selectedPhotoIndex < selectedAlbum.Photos.Count - 1)
            {
                m_selectedPhotoIndex++;
                displaySelectedPhoto();
            }
        }

        private void comboBoxAlbumsSortOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoggedIn())
            {
                SortAlbums();
            }
        }

        private void SortAlbums()
        {
            if (isLoggedIn())
            {
                IEnumerable<Album> sortedAlbums;
                string sortingOption;
                if(comboBoxAlbumsSortOption.SelectedItem == null)
                {
                    sortingOption = "Newest";
                }
                else
                {
                    sortingOption = comboBoxAlbumsSortOption.SelectedItem.ToString();
                }
                listBoxAlbums.Items.Clear();
                listBoxAlbums.DisplayMember = "Name";
                sortedAlbums = m_facebookManager.Albums.SortAlbums(sortingOption);

                foreach (Album album in sortedAlbums)
                {
                    listBoxAlbums.Items.Add(album);
                }

                if (listBoxAlbums.Items.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve :(");
                }
            }
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null && selectedAlbum.Photos.Count > 0)
                {
                    string firstPhotoUrl;
                    m_selectedPhotoIndex = 0;
                    firstPhotoUrl = selectedAlbum.Photos[m_selectedPhotoIndex].PictureNormalURL;
                    pictureBoxPhotos.LoadAsync(firstPhotoUrl);
                }
                else
                {
                    pictureBoxPhotos.Image = pictureBoxPhotos.ErrorImage;
                }
            }
        }

        private void displaySelectedPhoto()
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
            if (selectedAlbum != null && m_selectedPhotoIndex >= 0 && m_selectedPhotoIndex < selectedAlbum.Photos.Count)
            {
                pictureBoxPhotos.LoadAsync(selectedAlbum.Photos[m_selectedPhotoIndex].PictureNormalURL);
            }
        }

        private void downloadAlbum()
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
            if (selectedAlbum != null && selectedAlbum.Photos.Count > 0)
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string destinationFolderPath = folderBrowserDialog.SelectedPath;
                        string albumFolderPath = Path.Combine(destinationFolderPath, selectedAlbum.Name);
                        Directory.CreateDirectory(albumFolderPath);
                        for (int i = 0; i < selectedAlbum.Photos.Count; i++)
                        {
                            string photoUrl = selectedAlbum.Photos[i].PictureNormalURL;
                            string photoFileName = $"{selectedAlbum.Name}_{i + 1}.jpg";
                            string photoFilePath = Path.Combine(albumFolderPath, photoFileName);
                            using (WebClient webClient = new WebClient())
                            {
                                webClient.DownloadFile(photoUrl, photoFilePath);
                            }
                        }

                        MessageBox.Show("Album downloaded successfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No album selected or the album is empty.");
            }
        }

        //Pages Methods:
        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchLikedPages();
            enablePagesControl();
        }

        private void enablePagesControl()
        {
            listBoxPages.Enabled = true;
        }
        private void disablePagesControl()
        {
            linkPages.Enabled = false;
            listBoxPages.Enabled = false;
        }
        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
                pictureBoxPage.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void fetchLikedPages()
        {
            if(isLoggedIn())
            {
                listBoxPages.Items.Clear();
                listBoxPages.DisplayMember = "Name";
                List<Page> likedPages = m_facebookManager.LikedPages.AllPages;
                try
                {
                    foreach (Page page in likedPages)
                    {
                        listBoxPages.Items.Add(page);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxPages.Items.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve :(");
                }
            }
        }


    }
}
