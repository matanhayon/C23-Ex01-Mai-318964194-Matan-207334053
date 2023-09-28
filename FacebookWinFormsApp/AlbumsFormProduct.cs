using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class AlbumsFormProduct : AbstractForm
    {
        public override TabControl GetTabControl()
        {
            return new AlbumsForm().Controls.OfType<TabControl>().FirstOrDefault();
        }

        public class AlbumsFormCommand : IFormCommand
        {
            public AbstractForm Execute()
            {
                return new AlbumsFormProduct();
            }
        }
    }
}
