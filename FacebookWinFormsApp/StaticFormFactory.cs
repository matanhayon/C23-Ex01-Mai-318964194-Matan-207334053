using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public static class StaticFormFactory
    {
        public static AbstractForm CreateProduct(string productType)
        {
            switch (productType)
            {
                case "AlbumsForm":
                    return new AlbumsFormProduct();
                case "PagesForm":
                    return new PagesFormProduct();
                case "PostsForm":
                    return new PostsFormProduct();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }
}
