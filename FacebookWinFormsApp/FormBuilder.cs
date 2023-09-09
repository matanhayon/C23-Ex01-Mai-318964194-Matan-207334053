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
        private FormComposer m_FormComposer;
        private FormMain m_BuiltForm;

        public FormBuilder(FormComposer i_FormComposer)
        {
            m_FormComposer = i_FormComposer;
        }

        public FormMain Build()
        {
            m_BuiltForm = new FormMain();

            if (m_FormComposer.IsShowPages)
            {
                extarctTabFromFormAndAttach(StaticFormFactory.CreateForm(eFormType.Pages));
            }

            if (m_FormComposer.IsShowAlbums)
            {
                extarctTabFromFormAndAttach(StaticFormFactory.CreateForm(eFormType.Albums));
            }

            if (m_FormComposer.IsShowPosts)
            {
                extarctTabFromFormAndAttach(StaticFormFactory.CreateForm(eFormType.Posts));
            }

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
