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
        private FacebookObjectCollection<Album> m_Albums;

        public AlbumsManager(FacebookObjectCollection<Album> i_Albums)
        {
            m_Albums = i_Albums;
        }

        public IEnumerable<Album> SortAlbums(string i_sortingOption)
        {
            IEnumerable<Album> sortedAlbums;
            switch (i_sortingOption)
            {
                case "Newest":
                    sortedAlbums = m_Albums.OrderByDescending(album => album.CreatedTime);
                    break;
                case "Oldest":
                    sortedAlbums = m_Albums.OrderBy(album => album.CreatedTime);
                    break;
                case "Largest":
                    sortedAlbums = m_Albums.OrderByDescending(album => album.Count);
                    break;
                case "Smallest":
                    sortedAlbums = m_Albums.OrderBy(album => album.Count);
                    break;
                default:
                    sortedAlbums = m_Albums;
                    break;
            }

            return sortedAlbums;
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
