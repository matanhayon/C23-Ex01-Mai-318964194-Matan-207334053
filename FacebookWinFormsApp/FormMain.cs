using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.CompilerServices;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.WithSingltonAppSettings;
using System.ComponentModel;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private FacebookManager m_FacebookManager = FacebookManager.Instance;
        private int m_CountityToFetch = int.MaxValue;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = m_CountityToFetch;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            if (m_FacebookManager != null)
            {
                userBindingSource.DataSource = m_FacebookManager.User;
                string url = m_FacebookManager.Albums.GetCoverPhotoUrl();
                coverPictureBox.LoadAsync(url);
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
    }
}
