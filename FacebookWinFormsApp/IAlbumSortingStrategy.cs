using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IAlbumSortingStrategy
    {
        IEnumerable<Album> SortAlbums(IEnumerable<Album> albums);
    }
}
