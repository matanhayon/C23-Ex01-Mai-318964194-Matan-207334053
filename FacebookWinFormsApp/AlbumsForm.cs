using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.WithSingltonAppSettings;

namespace BasicFacebookFeatures
{
    public partial class AlbumsForm : Form, IObserver
    {
        private User m_LoggedInUser;
        private int m_SelectedPhotoIndex;

        public AlbumsForm()
        {
            InitializeComponent();
            if (FacebookManager.Instance != null)
            {
                m_LoggedInUser = FacebookManager.Instance.User;
                initializeAddedFeatures();
            }
        }

        private void initializeAddedFeatures()
        {
            initializeAlbumsSortingComboBox();
        }

        private void initializeAlbumsSortingComboBox()
        {
            foreach (eAlbumSortingOption sortingOption in Enum.GetValues(typeof(eAlbumSortingOption)))
            {
                comboBoxAlbumsSortOption.Items.Add(sortingOption.ToString());
            }
        }

        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                new Thread(fetchAlbums).Start();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Loading albums failed: " + exception.Message);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ApplicationSettings.Instance.BrowsingFormsLastWindowState = this.WindowState;
            ApplicationSettings.Instance.BrowsingFormsLastWindowSize = this.Size;
            ApplicationSettings.Instance.BrowsingFormsLastWindowLocation = this.Location;
            ApplicationSettings.Instance.Save();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Size = ApplicationSettings.Instance.BrowsingFormsLastWindowSize;
            this.WindowState = ApplicationSettings.Instance.BrowsingFormsLastWindowState;
            this.Location = ApplicationSettings.Instance.BrowsingFormsLastWindowLocation;
        }

        private void fetchAlbums()
        {
            if (!listBoxAlbums.InvokeRequired)
            {
                albumBindingSource.DataSource = m_LoggedInUser.Albums;
            }
            else
            {
                listBoxAlbums.Invoke(new Action(() =>
                {
                    enableAlbumsControl();
                    albumBindingSource.DataSource = m_LoggedInUser.Albums;
                }));
            }
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
                    m_SelectedPhotoIndex = 0;
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
            if (m_SelectedPhotoIndex > 0)
            {
                m_SelectedPhotoIndex--;
                displaySelectedPhoto();
            }
        }

        private void displaySelectedPhoto()
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
            if (selectedAlbum != null && m_SelectedPhotoIndex >= 0 && m_SelectedPhotoIndex < selectedAlbum.Photos.Count)
            {
                pictureBoxPhotos.LoadAsync(selectedAlbum.Photos[m_SelectedPhotoIndex].PictureNormalURL);
            }
        }

        private void buttonNextPhoto_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
            if (selectedAlbum != null && m_SelectedPhotoIndex < selectedAlbum.Photos.Count - 1)
            {
                m_SelectedPhotoIndex++;
                displaySelectedPhoto();
            }
        }

        private void comboBoxAlbumsSortOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortAlbums();
        }

        private void sortAlbums()
        {
            if (FacebookManager.Instance != null)
            {
                if (comboBoxAlbumsSortOption.SelectedItem != null)
                {
                    string sortingOption = comboBoxAlbumsSortOption.SelectedItem.ToString();
                    if (Enum.TryParse(sortingOption, out eAlbumSortingOption o_Selection))
                    {
                        IAlbumSortingStrategy sortingStrategy = AlbumSortingStrategyFactory.CreateSortingStrategy(o_Selection);
                        FacebookManager.Instance.Albums.SetSortingStrategy(sortingStrategy);
                        albumBindingSource.DataSource = FacebookManager.Instance.Albums.SortAlbums();
                    }
                    else
                    {
                        MessageBox.Show("Invalid sorting option");
                    }
                }

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

        public void Update()
        {
            fetchAlbums();
            MessageBox.Show("Albums are updated.", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
