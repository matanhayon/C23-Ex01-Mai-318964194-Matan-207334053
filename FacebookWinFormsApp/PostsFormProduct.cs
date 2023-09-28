using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class PostsFormProduct : AbstractForm
    {
        public override TabControl GetTabControl()
        {
            return new PostsForm().Controls.OfType<TabControl>().FirstOrDefault();
        }


        public class PostsFormCommand : IFormCommand
        {
            public AbstractForm Execute()
            {
                return new PostsFormProduct();
            }
        }
    }
}
