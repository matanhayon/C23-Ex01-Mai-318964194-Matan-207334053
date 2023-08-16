using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class AlbumsManager
    {
        //private FacebookManager m_FacebookManager;
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
                    sortedAlbums = m_Albums; // Default sorting
                    break;
            }
            return sortedAlbums;
        }



        // Other methods related to albums
    }
}
