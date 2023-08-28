using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public abstract class AbstractForm
    {
        public abstract TabControl GetTabControl();
    }

    internal class AlbumsFormProduct : AbstractForm
    {
        public override TabControl GetTabControl()
        {
            return new AlbumsForm().Controls.OfType<TabControl>().FirstOrDefault();
        }
    }

    internal class PagesFormProduct : AbstractForm
    {
        public override TabControl GetTabControl()
        {
            return new PagesForm().Controls.OfType<TabControl>().FirstOrDefault();
        }
    }

    internal class PostsFormProduct : AbstractForm
    {
        public override TabControl GetTabControl()
        {
            return new PostsForm().Controls.OfType<TabControl>().FirstOrDefault();
        }
    }
}
