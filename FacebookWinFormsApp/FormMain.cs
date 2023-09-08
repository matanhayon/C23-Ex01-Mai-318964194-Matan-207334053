using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.CompilerServices;
using BasicFacebookFeatures.BasicFacebookFeatures;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private FacebookManager m_facebookManager = FacebookManager.Instance;
        private int m_selectedPhotoIndex = -1;
        private int countityToFetch = 50;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = countityToFetch;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(m_facebookManager != null)
            {
                userBindingSource.DataSource = m_facebookManager.getUser();
                string url = m_facebookManager.Albums.GetCoverPhotoUrl();
                coverPictureBox.LoadAsync(url);
            }
        }
    }
}
