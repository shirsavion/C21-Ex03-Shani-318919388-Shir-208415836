using BasicFacebookFeatures.ObserverObsreveeFiles;

namespace FacebookApp
{
    partial class FormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelViewSelection = new System.Windows.Forms.Panel();
            this.labelMinutesInApp = new System.Windows.Forms.Label();
            this.panelHome = new BasicFacebookFeatures.ObserverObsreveeFiles.ObservantPanel();
            this.observantPictureBoxIncognito = new BasicFacebookFeatures.ObserverObsreveeFiles.ObservantPictureBox();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.panelMenuPage = new BasicFacebookFeatures.ObserverObsreveeFiles.ObservantPanel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonBirthdays = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.panelLogo = new BasicFacebookFeatures.ObserverObsreveeFiles.ObservantPanel();
            this.checkBoxRememberMe = new BasicFacebookFeatures.ObserverObsreveeFiles.ObserveeCheckBox();
            this.labelHelloUser = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panelViewSelection.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.observantPictureBoxIncognito)).BeginInit();
            this.panelMenuPage.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelViewSelection
            // 
            this.panelViewSelection.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelViewSelection.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.FirstScreenBG;
            this.panelViewSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelViewSelection.Controls.Add(this.labelMinutesInApp);
            this.panelViewSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewSelection.Location = new System.Drawing.Point(256, 143);
            this.panelViewSelection.Name = "panelViewSelection";
            this.panelViewSelection.Size = new System.Drawing.Size(1126, 613);
            this.panelViewSelection.TabIndex = 3;
            // 
            // labelMinutesInApp
            // 
            this.labelMinutesInApp.AutoSize = true;
            this.labelMinutesInApp.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutesInApp.ForeColor = System.Drawing.Color.MistyRose;
            this.labelMinutesInApp.Location = new System.Drawing.Point(807, 19);
            this.labelMinutesInApp.Name = "labelMinutesInApp";
            this.labelMinutesInApp.Size = new System.Drawing.Size(0, 22);
            this.labelMinutesInApp.TabIndex = 0;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelHome.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.Logo_small;
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelHome.Controls.Add(this.observantPictureBoxIncognito);
            this.panelHome.Controls.Add(this.labelPageTitle);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(256, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1126, 143);
            this.panelHome.TabIndex = 2;
            // 
            // observantPictureBoxIncognito
            // 
            this.observantPictureBoxIncognito.AccessibleName = "observantPictureBoxIncognito";
            this.observantPictureBoxIncognito.BackColor = System.Drawing.Color.Transparent;
            this.observantPictureBoxIncognito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.observantPictureBoxIncognito.Dock = System.Windows.Forms.DockStyle.Right;
            this.observantPictureBoxIncognito.Image = global::BasicFacebookFeatures.Properties.Resources.incognito;
            this.observantPictureBoxIncognito.Location = new System.Drawing.Point(974, 0);
            this.observantPictureBoxIncognito.Name = "observantPictureBoxIncognito";
            this.observantPictureBoxIncognito.Size = new System.Drawing.Size(152, 143);
            this.observantPictureBoxIncognito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.observantPictureBoxIncognito.TabIndex = 1;
            this.observantPictureBoxIncognito.TabStop = false;
            this.observantPictureBoxIncognito.Visible = false;
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelPageTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPageTitle.Font = new System.Drawing.Font("Levenim MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelPageTitle.Location = new System.Drawing.Point(0, 0);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(288, 143);
            this.labelPageTitle.TabIndex = 0;
            this.labelPageTitle.Text = "Welocme to Finessebook";
            this.labelPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenuPage
            // 
            this.panelMenuPage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelMenuPage.Controls.Add(this.buttonLogout);
            this.panelMenuPage.Controls.Add(this.buttonBirthdays);
            this.panelMenuPage.Controls.Add(this.buttonFriends);
            this.panelMenuPage.Controls.Add(this.buttonAlbums);
            this.panelMenuPage.Controls.Add(this.buttonGroups);
            this.panelMenuPage.Controls.Add(this.buttonEvents);
            this.panelMenuPage.Controls.Add(this.buttonPosts);
            this.panelMenuPage.Controls.Add(this.panelLogo);
            this.panelMenuPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuPage.Location = new System.Drawing.Point(0, 0);
            this.panelMenuPage.Name = "panelMenuPage";
            this.panelMenuPage.Size = new System.Drawing.Size(256, 756);
            this.panelMenuPage.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Guttman Haim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.Image = global::BasicFacebookFeatures.Properties.Resources.logut;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 629);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(256, 81);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "   Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonBirthdays
            // 
            this.buttonBirthdays.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBirthdays.FlatAppearance.BorderSize = 0;
            this.buttonBirthdays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBirthdays.Font = new System.Drawing.Font("Guttman Haim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBirthdays.Image = global::BasicFacebookFeatures.Properties.Resources.birthday;
            this.buttonBirthdays.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBirthdays.Location = new System.Drawing.Point(0, 548);
            this.buttonBirthdays.Name = "buttonBirthdays";
            this.buttonBirthdays.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonBirthdays.Size = new System.Drawing.Size(256, 81);
            this.buttonBirthdays.TabIndex = 6;
            this.buttonBirthdays.Text = "   Birthdays";
            this.buttonBirthdays.UseVisualStyleBackColor = true;
            this.buttonBirthdays.Click += new System.EventHandler(this.buttonBirthdays_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFriends.FlatAppearance.BorderSize = 0;
            this.buttonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFriends.Font = new System.Drawing.Font("Guttman Haim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFriends.Image = global::BasicFacebookFeatures.Properties.Resources.friends;
            this.buttonFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFriends.Location = new System.Drawing.Point(0, 467);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonFriends.Size = new System.Drawing.Size(256, 81);
            this.buttonFriends.TabIndex = 5;
            this.buttonFriends.Text = "  Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAlbums.FlatAppearance.BorderSize = 0;
            this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbums.Font = new System.Drawing.Font("Guttman Haim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAlbums.Image = global::BasicFacebookFeatures.Properties.Resources.albums;
            this.buttonAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlbums.Location = new System.Drawing.Point(0, 386);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonAlbums.Size = new System.Drawing.Size(256, 81);
            this.buttonAlbums.TabIndex = 4;
            this.buttonAlbums.Text = "   Albums";
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroups.FlatAppearance.BorderSize = 0;
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroups.Font = new System.Drawing.Font("Guttman Haim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGroups.Image = global::BasicFacebookFeatures.Properties.Resources.groups1;
            this.buttonGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroups.Location = new System.Drawing.Point(0, 305);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonGroups.Size = new System.Drawing.Size(256, 81);
            this.buttonGroups.TabIndex = 3;
            this.buttonGroups.Text = "   Groups";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEvents.FlatAppearance.BorderSize = 0;
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvents.Font = new System.Drawing.Font("Guttman Haim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonEvents.Image = global::BasicFacebookFeatures.Properties.Resources._event;
            this.buttonEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEvents.Location = new System.Drawing.Point(0, 224);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonEvents.Size = new System.Drawing.Size(256, 81);
            this.buttonEvents.TabIndex = 2;
            this.buttonEvents.Text = "   Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonPosts
            // 
            this.buttonPosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPosts.FlatAppearance.BorderSize = 0;
            this.buttonPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosts.Font = new System.Drawing.Font("Guttman Haim", 10F);
            this.buttonPosts.Image = global::BasicFacebookFeatures.Properties.Resources.post5;
            this.buttonPosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPosts.Location = new System.Drawing.Point(0, 143);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonPosts.Size = new System.Drawing.Size(256, 81);
            this.buttonPosts.TabIndex = 8;
            this.buttonPosts.Text = "   Posts";
            this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelLogo.Controls.Add(this.checkBoxRememberMe);
            this.panelLogo.Controls.Add(this.labelHelloUser);
            this.panelLogo.Controls.Add(this.pictureBoxProfile);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(256, 143);
            this.panelLogo.TabIndex = 0;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(7, 118);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(124, 24);
            this.checkBoxRememberMe.TabIndex = 2;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // labelHelloUser
            // 
            this.labelHelloUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHelloUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHelloUser.Location = new System.Drawing.Point(-1, 0);
            this.labelHelloUser.Name = "labelHelloUser";
            this.labelHelloUser.Size = new System.Drawing.Size(114, 34);
            this.labelHelloUser.TabIndex = 1;
            this.labelHelloUser.Text = "Hello!";
            this.labelHelloUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(123, 0);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(133, 143);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1382, 756);
            this.Controls.Add(this.panelViewSelection);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelMenuPage);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1400, 750);
            this.Name = "FormApp";
            this.Text = "App";
            this.panelViewSelection.ResumeLayout(false);
            this.panelViewSelection.PerformLayout();
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.observantPictureBoxIncognito)).EndInit();
            this.panelMenuPage.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonBirthdays;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Panel panelViewSelection;
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.Label labelHelloUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private BasicFacebookFeatures.ObserverObsreveeFiles.ObservantPictureBox observantPictureBoxIncognito;
        private ObservantPanel panelMenuPage;
        private ObservantPanel panelLogo;
        private ObservantPanel panelHome;
        private ObserveeCheckBox checkBoxRememberMe;
        private System.Windows.Forms.Label labelMinutesInApp;
    }
}