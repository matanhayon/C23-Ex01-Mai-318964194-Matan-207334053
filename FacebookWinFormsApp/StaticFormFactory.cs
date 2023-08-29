using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public static class StaticFormFactory
    {
        public static AbstractForm CreateProduct(eFormType i_eFormType)
        {
            switch (i_eFormType)
            {
                case eFormType.Albums:
                    return new AlbumsFormProduct();
                case eFormType.Pages:
                    return new PagesFormProduct();
                case eFormType.Posts:
                    return new PostsFormProduct();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }
}
