using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.BasicFacebookFeatures;
using System.IO;
using System.Net;

namespace BasicFacebookFeatures
{

    public partial class AlbumsForm : Form
    {
        private User m_loggedInUser;
        private int m_selectedPhotoIndex;
        public AlbumsForm()
        {
            InitializeComponent();
            if (FacebookManager.Instance != null)
            {
                m_loggedInUser = FacebookManager.Instance.getUser();
                initializeAddedFeatures();
            }
        }

        private void initializeAddedFeatures()
        {
            initializeAlbumsSortingComboBox();
        }

        private void initializeAlbumsSortingComboBox()
        {
            comboBoxAlbumsSortOption.Items.Add("Newest");
            comboBoxAlbumsSortOption.Items.Add("Oldest");
            comboBoxAlbumsSortOption.Items.Add("Largest");
            comboBoxAlbumsSortOption.Items.Add("Smallest");
        }

        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            enableAlbumsControl();
            albumBindingSource.DataSource = m_loggedInUser.Albums;
        }

        private void enableAlbumsControl()
        {
            buttonDownloadAlbum.Enabled = true;
            comboBoxAlbumsSortOption.Enabled = true;
            buttonNextPhoto.Enabled = true;
            buttonPreviousPhoto.Enabled = true;
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
                    m_selectedPhotoIndex = 0;
                    displaySelectedPhoto();
                }
                else
                {
                    pictureBoxPhotos.Image = pictureBoxPhotos.ErrorImage;
                }
            }
        }

        private void buttonPreviousPhoto_Click(object sender, EventArgs e)
        {
            if (m_selectedPhotoIndex > 0)
            {
                m_selectedPhotoIndex--;
                displaySelectedPhoto();
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
            SortAlbums();
        }

        private void SortAlbums()
        {
            if (FacebookManager.Instance != null)
            {
                IEnumerable<Album> sortedAlbums;
                string sortingOption;
                if (comboBoxAlbumsSortOption.SelectedItem == null)
                {
                    sortingOption = "Newest";
                }
                else
                {
                    sortingOption = comboBoxAlbumsSortOption.SelectedItem.ToString();
                }

                sortedAlbums = FacebookManager.Instance.Albums.SortAlbums(sortingOption);
                albumBindingSource.DataSource = sortedAlbums;

                if (listBoxAlbums.Items.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve :(");
                }
            }
        }

        private void buttonDownloadAlbum_Click(object sender, EventArgs e)
        {
            downloadAlbum();
        }

        private void downloadAlbum()
        {
            Album album = listBoxAlbums.SelectedItem as Album;
            FacebookManager.Instance.Albums.DownloadAlbum(album);
        }
    }
}
