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

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        FacebookWrapper.LoginResult m_LoginResult;
        User m_LoggedInUser;
        private int m_selectedAlbumIndex = -1;


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



        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";

            var sortingOption = comboBoxSortOption.SelectedItem.ToString();
            IEnumerable<Album> sortedAlbums;

            switch (sortingOption)
            {
                case "Newest":
                    sortedAlbums = m_LoggedInUser.Albums.OrderByDescending(album => album.CreatedTime);
                    break;
                case "Oldest":
                    sortedAlbums = m_LoggedInUser.Albums.OrderBy(album => album.CreatedTime);
                    break;
                case "Largest":
                    sortedAlbums = m_LoggedInUser.Albums.OrderByDescending(album => album.Count);
                    break;
                case "Smallest":
                    sortedAlbums = m_LoggedInUser.Albums.OrderBy(album => album.Count);
                    break;
                default:
                    sortedAlbums = m_LoggedInUser.Albums; // Default sorting
                    break;
            }

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
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    string firstPhotoUrl;
                    m_selectedAlbumIndex = 0;
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                    firstPhotoUrl = selectedAlbum.Photos[m_selectedAlbumIndex].PictureNormalURL;
                    pictureBoxPhotos.LoadAsync(firstPhotoUrl);
                }
                else
                {
                    pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
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
          if(isLoggedIn()) 
             fetchAlbums();
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
    }
}
