using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public static class AlbumSortingStrategyFactory
    {
        public static IAlbumSortingStrategy CreateSortingStrategy(AlbumSortingOption i_Selection)
        {
            switch (i_Selection)
            {
                case AlbumSortingOption.Newest:
                    return new NewestAlbumSortingStrategy();
                    break;
                case AlbumSortingOption.Oldest:
                    return new OldestAlbumSortingStrategy();
                    break;
                case AlbumSortingOption.Largest:
                    return new LargestAlbumSortingStrategy();
                    break;
                case AlbumSortingOption.Smallest:
                    return new SmallestAlbumSortingStrategy();
                    break;
                default:
                    throw new ArgumentException("Invalid sorting option");
                    break;
            }
        }
    }
}
