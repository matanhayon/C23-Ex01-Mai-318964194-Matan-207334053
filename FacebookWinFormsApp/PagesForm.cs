using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class PagesForm : Form
    {
        private User m_loggedInUser;
        public PagesForm()
        {
            InitializeComponent();
            if(FacebookManager.Instance != null)
            {
                m_loggedInUser = FacebookManager.Instance.getUser();
            }
        }

        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPages();
        }

        private void fetchPages() 
        {
            pageBindingSource.DataSource = m_loggedInUser.LikedPages;
        }
    }
}
