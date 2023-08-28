using BasicFacebookFeatures.BasicFacebookFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class FormBuilder
    {
        private FormComposer m_formComposer;
        private FormMain m_builtForm;

        public FormBuilder(FormComposer i_formComposer)
        {
            m_formComposer = i_formComposer;
        }

        public FormMain Build()
        {
            m_builtForm = new FormMain();

            if (m_formComposer.IsShowPages)
            {
                BuildTab(StaticFormFactory.CreateProduct("PagesForm"));
            }

            if (m_formComposer.IsShowAlbums)
            {
                BuildTab(StaticFormFactory.CreateProduct("AlbumsForm"));
            }

            if (m_formComposer.IsShowPosts)
            {
                BuildTab(StaticFormFactory.CreateProduct("PostsForm"));
            }

            return m_builtForm;
        }

        private void BuildTab(AbstractForm i_Form)
        {
            TabControl mainTabControl = m_builtForm.Controls.OfType<TabControl>().FirstOrDefault();
            if (mainTabControl != null)
            {
                TabControl productTabControl = i_Form.GetTabControl();
                mainTabControl.Controls.Add(productTabControl.TabPages[0]);
            }
        }


        private void buildAlbumsTab()
        {
            AlbumsForm AlbumForm = new AlbumsForm();
            TabControl mainTabControl = m_builtForm.Controls.OfType<TabControl>().FirstOrDefault();
            if (mainTabControl != null)
            {
                TabControl AlbumsTabControl = AlbumForm.Controls.OfType<TabControl>().FirstOrDefault();
                mainTabControl.Controls.Add(AlbumsTabControl.TabPages[0]);
            }
        }

        private void buildPagesTab()
        {
            PagesForm pagesForm = new PagesForm();
            TabControl mainTabControl = m_builtForm.Controls.OfType<TabControl>().FirstOrDefault();
            if (mainTabControl != null)
            {
                TabControl pagesTabControl = pagesForm.Controls.OfType<TabControl>().FirstOrDefault();
                mainTabControl.Controls.Add(pagesTabControl.TabPages[0]);
            }
        }
    }   
}
