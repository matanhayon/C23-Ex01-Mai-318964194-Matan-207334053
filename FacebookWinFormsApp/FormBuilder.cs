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
                ExtarctTabFromFormAndAttach(StaticFormFactory.CreateForm(eFormType.Pages));
            }

            if (m_formComposer.IsShowAlbums)
            {
                ExtarctTabFromFormAndAttach(StaticFormFactory.CreateForm(eFormType.Albums));
            }

            if (m_formComposer.IsShowPosts)
            {
                ExtarctTabFromFormAndAttach(StaticFormFactory.CreateForm(eFormType.Posts));
            }

            return m_builtForm;
        }

        private void ExtarctTabFromFormAndAttach(AbstractForm i_Form)
        {
            TabControl mainTabControl = m_builtForm.Controls.OfType<TabControl>().FirstOrDefault();
            if (mainTabControl != null)
            {
                TabControl productTabControl = i_Form.GetTabControl();
                mainTabControl.Controls.Add(productTabControl.TabPages[0]);
            }
        }
    }   
}
