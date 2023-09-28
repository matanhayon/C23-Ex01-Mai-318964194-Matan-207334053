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

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ApplicationSettings.Instance.LoginFormLastWindowState = this.WindowState;
            ApplicationSettings.Instance.LoginFormLastWindowSize = this.Size;
            ApplicationSettings.Instance.LoginFormLastWindowLocation = this.Location;
            ApplicationSettings.Instance.IsAutoLogin = this.checkBoxRememberMe.Checked;
            ApplicationSettings.Instance.Save();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.WindowState = ApplicationSettings.Instance.LoginFormLastWindowState;
            this.Location = ApplicationSettings.Instance.LoginFormLastWindowLocation;
            this.checkBoxRememberMe.Checked = ApplicationSettings.Instance.IsAutoLogin;

            if (ApplicationSettings.Instance.IsAutoLogin)
            {
                autoLogin();
            }
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FacebookManager.IsLoggedIn())
                {
                    login();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Login failed: " + exception.Message);
            }
        }

        private void login()
        {
            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                "1576031996471164", // our app id
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos");

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                FacebookManager.Initialize(loginResult);
                m_FacebookManager = FacebookManager.Instance;
                ApplicationSettings.Instance.AccessToken = loginResult.AccessToken;
                enableTabSelectionControls();
                changeUiAfterLoggedIn();
            }
        }

        private void autoLogin()
        {
            try
            {
                LoginResult loginResult = FacebookService.Connect(ApplicationSettings.Instance.AccessToken);
                if (!string.IsNullOrEmpty(loginResult.AccessToken))
                {
                    FacebookManager.Initialize(loginResult);
                    m_FacebookManager = FacebookManager.Instance;
                    ApplicationSettings.Instance.AccessToken = loginResult.AccessToken;
                    enableTabSelectionControls();
                    changeUiAfterLoggedIn();
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => MessageBox.Show("Could not Auto-Connect")));
            }
        }

        private void changeUiAfterLoggedIn()
        {
            buttonLogin.Text = $"Logged in";
            buttonLogin.BackColor = Color.LightGreen;
            pictureBoxProfile.ImageLocation = m_FacebookManager.User.PictureLargeURL;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
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
            try
            {
                initiateBuilder();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Loading form failed: " + exception.Message);
            }
        }

        private void initiateBuilder()
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (m_FacebookManager != null)
            {
                logOut();
            }
        }

        private void logOut()
        {
            FacebookService.LogoutWithUI();
            m_FacebookManager.Reset();
            disableControlsLogout();
        }

        private void disableControlsLogout()
        {
            buttonLogin.Enabled = true;
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            buttonLogout.Enabled = false;
            pictureBoxProfile.Image = null;
            buttonContinue.Enabled = false;
            checkBoxAlbums.Enabled = false;
            checkBoxPages.Enabled = false;
            checkBoxPosts.Enabled = false;
            checkBoxAlbums.Checked = false;
            checkBoxPages.Checked = false;
            checkBoxPosts.Checked = false;
        }
    }
}
