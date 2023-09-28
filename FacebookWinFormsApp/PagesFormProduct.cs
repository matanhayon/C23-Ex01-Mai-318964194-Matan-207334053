using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class PagesFormProduct : AbstractForm
    {
        public override TabControl GetTabControl()
        {
            return new PagesForm().Controls.OfType<TabControl>().FirstOrDefault();
        }

        public class PagesFormCommand : IFormCommand
        {
            public AbstractForm Execute()
            {
                return new PagesFormProduct();
            }
        }
    }
}
