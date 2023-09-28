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
using BasicFacebookFeatures.WithSingltonAppSettings;
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
            try
            {
                new Thread(fetchPages).Start();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Loading pages failed: " + exception.Message);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ApplicationSettings.Instance.BrowsingFormsLastWindowState = this.WindowState;
            ApplicationSettings.Instance.BrowsingFormsLastWindowSize = this.Size;
            ApplicationSettings.Instance.BrowsingFormsLastWindowLocation = this.Location;
            ApplicationSettings.Instance.Save();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Size = ApplicationSettings.Instance.BrowsingFormsLastWindowSize;
            this.WindowState = ApplicationSettings.Instance.BrowsingFormsLastWindowState;
            this.Location = ApplicationSettings.Instance.BrowsingFormsLastWindowLocation;
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
