using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using static System.Net.WebRequestMethods;

namespace BasicFacebookFeatures
{
    internal class AlbumsManager
    {
        private User m_LoggedInUser;
        private List<Album> m_Albums;
        private IAlbumSortingStrategy m_SortingStrategy;

        public AlbumsManager(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_SortingStrategy = new NewestAlbumSortingStrategy();
            m_Albums = fetchAllAlbums();
        }

        public List<Album> AllAlbums
        {
            get
            {
                if (m_Albums == null)
                {
                    m_Albums = fetchAllAlbums();
                }

                return m_Albums;
            }
        }

        private List<Album> fetchAllAlbums()
        {
            List<Album> allAlbums = new List<Album>();

            if (m_LoggedInUser != null)
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    allAlbums.Add(album);
                }
            }

            return allAlbums;
        }

        public IEnumerable<Album> SortAlbums()
        {
            return m_SortingStrategy.SortAlbums(m_Albums);
        }

        public void SetSortingStrategy(IAlbumSortingStrategy i_SortingStrategy)
        {
            m_SortingStrategy = i_SortingStrategy;
        }

        public void DownloadAlbum(Album i_SelectedAlbum)
        {
            if (i_SelectedAlbum != null && i_SelectedAlbum.Photos.Count > 0)
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string destinationFolderPath = folderBrowserDialog.SelectedPath;
                        string albumFolderPath = Path.Combine(destinationFolderPath, i_SelectedAlbum.Name);
                        Directory.CreateDirectory(albumFolderPath);
                        for (int i = 0; i < i_SelectedAlbum.Photos.Count; i++)
                        {
                            string photoUrl = i_SelectedAlbum.Photos[i].PictureNormalURL;
                            string photoFileName = $"{i_SelectedAlbum.Name}_{i + 1}.jpg";
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

        public string GetCoverPhotoUrl()
        {
            string defaultUrl = "https://designshack.net/wp-content/uploads/facebook-cover-image-tips.png";
            foreach (Album album in m_Albums)
            {
                if (album.Name == "Cover photos")
                {
                    return album.Photos[0].PictureNormalURL;
                }
            }

            return defaultUrl;
        }
    }
}
