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
        private AlbumsForm m_AlbumsForm = new AlbumsForm();

        public AlbumsForm Form
        {
            get 
            { 
                return m_AlbumsForm; 
            }
        }
        public override TabControl GetTabControl()
        {
            return m_AlbumsForm.Controls.OfType<TabControl>().FirstOrDefault();
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
