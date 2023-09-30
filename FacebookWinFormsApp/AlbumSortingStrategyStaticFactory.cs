using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public static class AlbumSortingStrategyFactory
    {
        public static IAlbumSortingStrategy CreateSortingStrategy(eAlbumSortingOption i_Selection)
        {
            switch (i_Selection)
            {
                case eAlbumSortingOption.Newest:
                    return new NewestAlbumSortingStrategy();
                    break;
                case eAlbumSortingOption.Oldest:
                    return new OldestAlbumSortingStrategy();
                    break;
                case eAlbumSortingOption.Largest:
                    return new LargestAlbumSortingStrategy();
                    break;
                case eAlbumSortingOption.Smallest:
                    return new SmallestAlbumSortingStrategy();
                    break;
                default:
                    throw new ArgumentException("Invalid sorting option");
                    break;
            }
        }
    }
}
