namespace BasicFacebookFeatures
{
    partial class FakeBookLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxAlbums = new System.Windows.Forms.CheckBox();
            this.checkBoxPages = new System.Windows.Forms.CheckBox();
            this.checkBoxPosts = new System.Windows.Forms.CheckBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxAlbums
            // 
            this.checkBoxAlbums.AutoSize = true;
            this.checkBoxAlbums.Enabled = false;
            this.checkBoxAlbums.Location = new System.Drawing.Point(188, 166);
            this.checkBoxAlbums.Name = "checkBoxAlbums";
            this.checkBoxAlbums.Size = new System.Drawing.Size(74, 20);
            this.checkBoxAlbums.TabIndex = 90;
            this.checkBoxAlbums.Text = "Albums";
            this.checkBoxAlbums.UseVisualStyleBackColor = true;
            // 
            // checkBoxPages
            // 
            this.checkBoxPages.AutoSize = true;
            this.checkBoxPages.Enabled = false;
            this.checkBoxPages.Location = new System.Drawing.Point(188, 200);
            this.checkBoxPages.Name = "checkBoxPages";
            this.checkBoxPages.Size = new System.Drawing.Size(69, 20);
            this.checkBoxPages.TabIndex = 89;
            this.checkBoxPages.Text = "Pages";
            this.checkBoxPages.UseVisualStyleBackColor = true;
            // 
            // checkBoxPosts
            // 
            this.checkBoxPosts.AutoSize = true;
            this.checkBoxPosts.Enabled = false;
            this.checkBoxPosts.Location = new System.Drawing.Point(188, 132);
            this.checkBoxPosts.Name = "checkBoxPosts";
            this.checkBoxPosts.Size = new System.Drawing.Size(63, 20);
            this.checkBoxPosts.TabIndex = 88;
            this.checkBoxPosts.Text = "Posts";
            this.checkBoxPosts.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 98);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 87;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Azure;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(151, 24);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(120, 32);
            this.buttonLogout.TabIndex = 86;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Azure;
            this.buttonLogin.Location = new System.Drawing.Point(10, 24);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(120, 32);
            this.buttonLogin.TabIndex = 85;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.Azure;
            this.buttonContinue.Enabled = false;
            this.buttonContinue.Location = new System.Drawing.Point(17, 274);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(261, 51);
            this.buttonContinue.TabIndex = 91;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(13, 66);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(119, 20);
            this.checkBoxRememberMe.TabIndex = 92;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // FakeBookLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(318, 331);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.checkBoxAlbums);
            this.Controls.Add(this.checkBoxPages);
            this.Controls.Add(this.checkBoxPosts);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FakeBookLoginForm";
            this.Text = "FakeBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAlbums;
        private System.Windows.Forms.CheckBox checkBoxPages;
        private System.Windows.Forms.CheckBox checkBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
    }
}