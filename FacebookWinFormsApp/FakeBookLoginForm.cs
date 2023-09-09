using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FakeBookLoginForm : Form
    {
        private FacebookManager m_FacebookManager;

        public FakeBookLoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isLoggedIn())
                {
                    login();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Login failed: " + exception.Message);
            }
        }

        private bool isLoggedIn()
        {
            return m_FacebookManager != null;
        }

        private void login()
        {
            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                "1576031996471164", // our app id
                /// requested permissions:
                "email", "public_profile", "user_age_range", "user_birthday", "user_events",
                "user_friends", "user_gender", "user_hometown", "user_likes", "user_link",
                "user_location", "user_photos", "user_posts", "user_videos");

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                buttonLogin.Text = $"Logged in";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = loginResult.LoggedInUser.PictureLargeURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                FacebookManager.Initialize(loginResult);
                m_FacebookManager = FacebookManager.Instance;
                enableTabSelectionControls();
            }
        }

        private void enableTabSelectionControls()
        {
            checkBoxAlbums.Enabled = true;
            checkBoxPages.Enabled = true;
            checkBoxPosts.Enabled = true;
            buttonContinue.Enabled = true;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            bool showAlbums = checkBoxAlbums.Checked;
            bool showPages = checkBoxPages.Checked;
            bool showPosts = checkBoxPosts.Checked;

            if (!showAlbums && !showPages && !showPosts)
            {
                MessageBox.Show("Please select at least one tab to display.", "No Tabs Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormComposer formComposer = new FormComposer(showAlbums, showPages, showPosts);
                FormMain formMain = formComposer.Build();
                formMain.ShowDialog();
            }
        }
    }
}
