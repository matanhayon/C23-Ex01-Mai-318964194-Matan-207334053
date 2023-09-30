using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BasicFacebookFeatures.AlbumsFormProduct;
using static BasicFacebookFeatures.PagesFormProduct;
using static BasicFacebookFeatures.PostsFormProduct;

namespace BasicFacebookFeatures
{
    internal class FormBuilder
    {
        private FormComposer m_FormComposer;
        private FormMain m_BuiltForm;
        private DynamicFormFactory m_DynamicFormFactory;
        private DataUpdater m_DataUpdater = new DataUpdater();


        public FormBuilder(FormComposer i_FormComposer)
        {
            m_FormComposer = i_FormComposer;
            m_DynamicFormFactory = new DynamicFormFactory();
            m_DynamicFormFactory.RegisterForm(eFormType.Albums, new AlbumsFormCommand());
            m_DynamicFormFactory.RegisterForm(eFormType.Pages, new PagesFormCommand());
            m_DynamicFormFactory.RegisterForm(eFormType.Posts, new PostsFormCommand());
        }

        public FormMain Build()
        {
            m_BuiltForm = new FormMain();

            if (m_FormComposer.IsShowPages)
            {
                AbstractForm pagesForm = m_DynamicFormFactory.CreateForm(eFormType.Pages);
                m_DataUpdater.AddObserver(((PagesFormProduct)pagesForm).Form);
                extarctTabFromFormAndAttach(pagesForm);
            }

            if (m_FormComposer.IsShowAlbums)
            {
                AbstractForm albumsForm = m_DynamicFormFactory.CreateForm(eFormType.Albums);
                m_DataUpdater.AddObserver(((AlbumsFormProduct)albumsForm).Form);
                extarctTabFromFormAndAttach(albumsForm);
            }

            if (m_FormComposer.IsShowPosts)
            {
                AbstractForm postsForm = m_DynamicFormFactory.CreateForm(eFormType.Posts);
                m_DataUpdater.AddObserver(((PostsFormProduct)postsForm).Form);
                extarctTabFromFormAndAttach(postsForm);
            }
            m_DataUpdater.StartUpdatingData();
            return m_BuiltForm;
        }

        private void extarctTabFromFormAndAttach(AbstractForm i_Form)
        {
            TabControl mainTabControl = m_BuiltForm.Controls.OfType<TabControl>().FirstOrDefault();
            if (mainTabControl != null)
            {
                TabControl productTabControl = i_Form.GetTabControl();
                mainTabControl.Controls.Add(productTabControl.TabPages[0]);
            }
        }
    }
}
