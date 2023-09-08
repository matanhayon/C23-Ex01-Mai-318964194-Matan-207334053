namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label localeLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label religionLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Wall = new System.Windows.Forms.TabPage();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.localeLabel1 = new System.Windows.Forms.Label();
            this.middleNameLabel1 = new System.Windows.Forms.Label();
            this.religionLabel1 = new System.Windows.Forms.Label();
            this.wallPostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wallPostsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            localeLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            religionLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.Wall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPostsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Wall);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 553);
            this.tabControl1.TabIndex = 54;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // Wall
            // 
            this.Wall.AutoScroll = true;
            this.Wall.BackColor = System.Drawing.Color.LightBlue;
            this.Wall.Controls.Add(this.coverPictureBox);
            this.Wall.Controls.Add(birthdayLabel);
            this.Wall.Controls.Add(this.birthdayLabel1);
            this.Wall.Controls.Add(emailLabel);
            this.Wall.Controls.Add(this.emailLabel1);
            this.Wall.Controls.Add(firstNameLabel);
            this.Wall.Controls.Add(this.firstNameLabel1);
            this.Wall.Controls.Add(this.imageLargePictureBox);
            this.Wall.Controls.Add(lastNameLabel);
            this.Wall.Controls.Add(this.lastNameLabel1);
            this.Wall.Controls.Add(localeLabel);
            this.Wall.Controls.Add(this.localeLabel1);
            this.Wall.Controls.Add(middleNameLabel);
            this.Wall.Controls.Add(this.middleNameLabel1);
            this.Wall.Controls.Add(religionLabel);
            this.Wall.Controls.Add(this.religionLabel1);
            this.Wall.Location = new System.Drawing.Point(4, 31);
            this.Wall.Name = "Wall";
            this.Wall.Size = new System.Drawing.Size(1174, 518);
            this.Wall.TabIndex = 0;
            this.Wall.Text = "Wall";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.ForeColor = System.Drawing.Color.Black;
            birthdayLabel.Location = new System.Drawing.Point(510, 407);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(82, 24);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel1.ForeColor = System.Drawing.Color.Black;
            this.birthdayLabel1.Location = new System.Drawing.Point(644, 407);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(352, 23);
            this.birthdayLabel1.TabIndex = 1;
            this.birthdayLabel1.Text = "label1";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = System.Drawing.Color.Black;
            emailLabel.Location = new System.Drawing.Point(510, 370);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(62, 24);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel1.ForeColor = System.Drawing.Color.Black;
            this.emailLabel1.Location = new System.Drawing.Point(644, 370);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(262, 23);
            this.emailLabel1.TabIndex = 3;
            this.emailLabel1.Text = "label1";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.ForeColor = System.Drawing.Color.Black;
            firstNameLabel.Location = new System.Drawing.Point(510, 268);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(106, 24);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.firstNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel1.ForeColor = System.Drawing.Color.Black;
            this.firstNameLabel1.Location = new System.Drawing.Point(644, 268);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(352, 23);
            this.firstNameLabel1.TabIndex = 5;
            this.firstNameLabel1.Text = "label1";
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(255, 268);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(240, 240);
            this.imageLargePictureBox.TabIndex = 7;
            this.imageLargePictureBox.TabStop = false;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.ForeColor = System.Drawing.Color.Black;
            lastNameLabel.Location = new System.Drawing.Point(510, 334);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(104, 24);
            lastNameLabel.TabIndex = 8;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LastName", true));
            this.lastNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel1.ForeColor = System.Drawing.Color.Black;
            this.lastNameLabel1.Location = new System.Drawing.Point(644, 334);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(352, 23);
            this.lastNameLabel1.TabIndex = 9;
            this.lastNameLabel1.Text = "label1";
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.ForeColor = System.Drawing.Color.Black;
            localeLabel.Location = new System.Drawing.Point(510, 445);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(71, 24);
            localeLabel.TabIndex = 10;
            localeLabel.Text = "Locale:";
            // 
            // localeLabel1
            // 
            this.localeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Locale", true));
            this.localeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localeLabel1.ForeColor = System.Drawing.Color.Black;
            this.localeLabel1.Location = new System.Drawing.Point(644, 445);
            this.localeLabel1.Name = "localeLabel1";
            this.localeLabel1.Size = new System.Drawing.Size(352, 23);
            this.localeLabel1.TabIndex = 11;
            this.localeLabel1.Text = "label1";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.ForeColor = System.Drawing.Color.Black;
            middleNameLabel.Location = new System.Drawing.Point(510, 298);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(128, 24);
            middleNameLabel.TabIndex = 12;
            middleNameLabel.Text = "Middle Name:";
            // 
            // middleNameLabel1
            // 
            this.middleNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "MiddleName", true));
            this.middleNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameLabel1.ForeColor = System.Drawing.Color.Black;
            this.middleNameLabel1.Location = new System.Drawing.Point(644, 298);
            this.middleNameLabel1.Name = "middleNameLabel1";
            this.middleNameLabel1.Size = new System.Drawing.Size(352, 23);
            this.middleNameLabel1.TabIndex = 13;
            this.middleNameLabel1.Text = "label1";
            // 
            // religionLabel
            // 
            religionLabel.AutoSize = true;
            religionLabel.ForeColor = System.Drawing.Color.Black;
            religionLabel.Location = new System.Drawing.Point(510, 482);
            religionLabel.Name = "religionLabel";
            religionLabel.Size = new System.Drawing.Size(84, 24);
            religionLabel.TabIndex = 16;
            religionLabel.Text = "Religion:";
            // 
            // religionLabel1
            // 
            this.religionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Religion", true));
            this.religionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.religionLabel1.ForeColor = System.Drawing.Color.Black;
            this.religionLabel1.Location = new System.Drawing.Point(644, 482);
            this.religionLabel1.Name = "religionLabel1";
            this.religionLabel1.Size = new System.Drawing.Size(352, 23);
            this.religionLabel1.TabIndex = 17;
            this.religionLabel1.Text = "label1";
            // 
            // wallPostsBindingSource
            // 
            this.wallPostsBindingSource.DataMember = "WallPosts";
            this.wallPostsBindingSource.DataSource = this.userBindingSource;
            // 
            // wallPostsBindingSource1
            // 
            this.wallPostsBindingSource1.DataMember = "WallPosts";
            this.wallPostsBindingSource1.DataSource = this.userBindingSource;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageLarge", true));
            this.coverPictureBox.Location = new System.Drawing.Point(255, 3);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(686, 260);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.coverPictureBox.TabIndex = 18;
            this.coverPictureBox.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to FakeBook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.Wall.ResumeLayout(false);
            this.Wall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPostsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TabPage Wall;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label localeLabel1;
        private System.Windows.Forms.Label middleNameLabel1;
        private System.Windows.Forms.Label religionLabel1;
        private System.Windows.Forms.BindingSource wallPostsBindingSource;
        private System.Windows.Forms.BindingSource wallPostsBindingSource1;
        private System.Windows.Forms.PictureBox coverPictureBox;
    }
}

