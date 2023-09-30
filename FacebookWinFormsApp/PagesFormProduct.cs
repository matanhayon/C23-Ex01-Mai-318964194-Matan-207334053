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
        private PagesForm m_PagesForm = new PagesForm();

        public PagesForm Form
        {
            get 
            { 
                return m_PagesForm; 
            }
        }
        public override TabControl GetTabControl()
        {
            return m_PagesForm.Controls.OfType<TabControl>().FirstOrDefault();
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
