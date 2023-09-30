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
        private PostsForm m_PostForm = new PostsForm();
        
       public PostsForm Form
       {
            get 
            { 
                return m_PostForm; 
            }
       }
        public override TabControl GetTabControl()
        {
            return m_PostForm.Controls.OfType<TabControl>().FirstOrDefault();
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
