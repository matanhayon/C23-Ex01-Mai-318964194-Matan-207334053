using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class OldestAlbumSortingStrategy : IAlbumSortingStrategy
    {
        public IEnumerable<Album> SortAlbums(IEnumerable<Album> albums)
        {
            return albums.OrderBy(album => album.CreatedTime);
        }
    }
}
