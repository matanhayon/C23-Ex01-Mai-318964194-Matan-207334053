using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;
using System.Net;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        FacebookWrapper.LoginResult m_LoginResult;
        User m_LoggedInUser;
        private int m_selectedAlbumIndex = -1;
        private FacebookManager m_facebookManager;


        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            initializeAddedFeatures();
        }

        private void initializeAddedFeatures()
        {
            initializeComboBox();
        }

        private void initializeComboBox()
        {
            comboBoxSortOption.Items.Add("Newest");
            comboBoxSortOption.Items.Add("Oldest");
            comboBoxSortOption.Items.Add("Largest");
            comboBoxSortOption.Items.Add("Smallest");
            comboBoxSortOption.SelectedIndex = 0; // Set the default selected option
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (!isLoggedIn())
            {
                login();
            }
        }

        private bool isLoggedIn()
        {
            return !(m_LoginResult == null || string.IsNullOrEmpty(m_LoginResult.AccessToken));
        }
        private void login()
        {
            m_LoginResult = null;
            m_LoginResult = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
                textBoxAppID.Text,
                /// requested permissions:
                "email",
                "public_profile",
                "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos"
                /// add any relevant permissions
                );

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                m_facebookManager = new FacebookManager(m_LoginResult);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }


        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
            InitializeComboBoxYears();
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();

            foreach (Post post in m_LoggedInUser.Posts)
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
        }

        private void PopulatePostCountByMonthChart()
        {
            if (isLoggedIn())
            {
                int selectedYear = (int)comboBoxYears.SelectedItem; // Get the selected year

                Dictionary<int, int> postsByMonth = new Dictionary<int, int>();
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    int year = DateTime.Parse(post.CreatedTime.ToString()).Year;
                    int month = DateTime.Parse(post.CreatedTime.ToString()).Month;
                    if (year == selectedYear) // Use the selected year for analysis
                    {
                        if (postsByMonth.ContainsKey(month))
                        {
                            postsByMonth[month]++;
                        }
                        else
                        {
                            postsByMonth[month] = 1;
                        }
                    }
                }

                chartPostCountByMonth.Series.Clear();

                Series series = new Series("Posts");
                series.ChartType = SeriesChartType.Column;

                for (int month = 1; month <= 12; month++)
                {
                    int count = postsByMonth.ContainsKey(month) ? postsByMonth[month] : 0;
                    series.Points.AddXY(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month), count);
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
                chartPostCountByMonth.Titles.Add($"Post Count by Month in {selectedYear}");
            }
        }

        private void InitializeComboBoxYears()
        {
            if (isLoggedIn())
            {
                comboBoxYears.Items.Clear();
                HashSet<int> yearsWithPosts = new HashSet<int>();

                foreach (Post post in m_LoggedInUser.Posts)
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

        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SortAlbums();
        }

    
        private void SortAlbums()
        {
            IEnumerable<Album> sortedAlbums;
            var sortingOption = comboBoxSortOption.SelectedItem.ToString();

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
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null && selectedAlbum.Photos.Count > 0)
                {
                    string firstPhotoUrl;
                    m_selectedAlbumIndex = 0;
                    firstPhotoUrl = selectedAlbum.Photos[m_selectedAlbumIndex].PictureNormalURL;
                    pictureBoxPhotos.LoadAsync(firstPhotoUrl);
                }
                else
                {
                    pictureBoxPhotos.Image = pictureBoxPhotos.ErrorImage;
                }
            }
        }

        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
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

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
                pictureBoxPage.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void comboBoxSortOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoggedIn())
            {
                SortAlbums();
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (m_selectedAlbumIndex > 0)
            {
                m_selectedAlbumIndex--;
                displaySelectedPhoto();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
            if (selectedAlbum != null && m_selectedAlbumIndex < selectedAlbum.Photos.Count - 1)
            {
                m_selectedAlbumIndex++;
                displaySelectedPhoto();
            }
        }

        private void displaySelectedPhoto()
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
            if (selectedAlbum != null && m_selectedAlbumIndex >= 0 && m_selectedAlbumIndex < selectedAlbum.Photos.Count)
            {
                pictureBoxPhotos.LoadAsync(selectedAlbum.Photos[m_selectedAlbumIndex].PictureNormalURL);
            }
        }

        private void buttonDownloadAlbum_Click(object sender, EventArgs e)
        {
            downloadAlbum();
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

        private void buttonAnalyzePosts_Click(object sender, EventArgs e)
        {
            PopulatePostCountByMonthChart();
        }

        private void pictureBoxPage_Click(object sender, EventArgs e)
        {

        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
