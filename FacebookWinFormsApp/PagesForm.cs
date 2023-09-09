using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class PagesForm : Form
    {
        private User m_LoggedInUser;

        public PagesForm()
        {
            InitializeComponent();
            if (FacebookManager.Instance != null)
            {
                m_LoggedInUser = FacebookManager.Instance.User;
            }
        }

        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchPages).Start();
        }

        private void fetchPages()
        {
            if (!listBoxPages.InvokeRequired)
            {
                pageBindingSource.DataSource = FacebookManager.Instance.LikedPages.AllPages;
            }
            else
            {
                listBoxPages.Invoke(new Action(() =>
                {
                    listBoxPages.DisplayMember = "Name";
                    List<Page> pages = FacebookManager.Instance.LikedPages.AllPages;
                    pageBindingSource.DataSource = pages;
                    listBoxPages.DataSource = pageBindingSource;
                }));
            }
        }
    }
}
