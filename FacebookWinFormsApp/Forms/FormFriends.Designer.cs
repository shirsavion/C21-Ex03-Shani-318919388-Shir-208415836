
namespace BasicFacebookFeatures.Forms
{
    partial class FormFriends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriends));
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBoxFriendProfile = new System.Windows.Forms.PictureBox();
            this.richTextBoxLatestPost = new System.Windows.Forms.RichTextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.panelViewMyFriend = new System.Windows.Forms.Panel();
            this.buttonViewFriendOnFB = new System.Windows.Forms.Button();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelInCommon = new System.Windows.Forms.Label();
            this.panelViewInsertInfoFormFriend = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowserLocation = new System.Windows.Forms.WebBrowser();
            this.buttonBack = new BasicFacebookFeatures.Forms.ButtonBack();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).BeginInit();
            this.panelViewMyFriend.SuspendLayout();
            this.panelViewInsertInfoFormFriend.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(194, 50);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(299, 31);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Category";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBoxSearch.Location = new System.Drawing.Point(23, 183);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.ReadOnly = true;
            this.textBoxSearch.Size = new System.Drawing.Size(225, 31);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.Text = "Search By Name...";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.MistyRose;
            this.buttonSearch.Location = new System.Drawing.Point(274, 174);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Size = new System.Drawing.Size(96, 45);
            this.buttonSearch.TabIndex = 37;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pictureBoxFriendProfile
            // 
            this.pictureBoxFriendProfile.Location = new System.Drawing.Point(33, 47);
            this.pictureBoxFriendProfile.Name = "pictureBoxFriendProfile";
            this.pictureBoxFriendProfile.Padding = new System.Windows.Forms.Padding(1);
            this.pictureBoxFriendProfile.Size = new System.Drawing.Size(157, 156);
            this.pictureBoxFriendProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFriendProfile.TabIndex = 38;
            this.pictureBoxFriendProfile.TabStop = false;
            this.pictureBoxFriendProfile.Visible = false;
            // 
            // richTextBoxLatestPost
            // 
            this.richTextBoxLatestPost.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLatestPost.Location = new System.Drawing.Point(288, 66);
            this.richTextBoxLatestPost.Name = "richTextBoxLatestPost";
            this.richTextBoxLatestPost.ReadOnly = true;
            this.richTextBoxLatestPost.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxLatestPost.Size = new System.Drawing.Size(155, 123);
            this.richTextBoxLatestPost.TabIndex = 40;
            this.richTextBoxLatestPost.Text = "";
            this.richTextBoxLatestPost.Visible = false;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelPost.Location = new System.Drawing.Point(283, 22);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(117, 28);
            this.labelPost.TabIndex = 43;
            this.labelPost.Text = "Latest post..";
            this.labelPost.Visible = false;
            // 
            // panelViewMyFriend
            // 
            this.panelViewMyFriend.Controls.Add(this.buttonViewFriendOnFB);
            this.panelViewMyFriend.Controls.Add(this.labelDetails);
            this.panelViewMyFriend.Controls.Add(this.pictureBoxFriendProfile);
            this.panelViewMyFriend.Controls.Add(this.labelPost);
            this.panelViewMyFriend.Controls.Add(this.richTextBoxLatestPost);
            this.panelViewMyFriend.Location = new System.Drawing.Point(546, 75);
            this.panelViewMyFriend.Name = "panelViewMyFriend";
            this.panelViewMyFriend.Size = new System.Drawing.Size(476, 664);
            this.panelViewMyFriend.TabIndex = 44;
            // 
            // buttonViewFriendOnFB
            // 
            this.buttonViewFriendOnFB.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewFriendOnFB.Location = new System.Drawing.Point(33, 497);
            this.buttonViewFriendOnFB.Name = "buttonViewFriendOnFB";
            this.buttonViewFriendOnFB.Size = new System.Drawing.Size(185, 39);
            this.buttonViewFriendOnFB.TabIndex = 48;
            this.buttonViewFriendOnFB.Text = "View Friend on FB..";
            this.buttonViewFriendOnFB.UseVisualStyleBackColor = true;
            this.buttonViewFriendOnFB.Click += new System.EventHandler(this.buttonViewFriendOnFB_Click);
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.ForeColor = System.Drawing.Color.Black;
            this.labelDetails.Location = new System.Drawing.Point(35, 215);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(0, 28);
            this.labelDetails.TabIndex = 45;
            // 
            // labelInCommon
            // 
            this.labelInCommon.AutoSize = true;
            this.labelInCommon.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInCommon.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelInCommon.Location = new System.Drawing.Point(554, 36);
            this.labelInCommon.Name = "labelInCommon";
            this.labelInCommon.Size = new System.Drawing.Size(0, 28);
            this.labelInCommon.TabIndex = 49;
            // 
            // panelViewInsertInfoFormFriend
            // 
            this.panelViewInsertInfoFormFriend.Controls.Add(this.comboBoxCategory);
            this.panelViewInsertInfoFormFriend.Controls.Add(this.label1);
            this.panelViewInsertInfoFormFriend.Controls.Add(this.buttonSearch);
            this.panelViewInsertInfoFormFriend.Controls.Add(this.textBoxSearch);
            this.panelViewInsertInfoFormFriend.Location = new System.Drawing.Point(27, 162);
            this.panelViewInsertInfoFormFriend.Name = "panelViewInsertInfoFormFriend";
            this.panelViewInsertInfoFormFriend.Size = new System.Drawing.Size(513, 323);
            this.panelViewInsertInfoFormFriend.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowserLocation);
            this.panel1.Location = new System.Drawing.Point(1028, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 664);
            this.panel1.TabIndex = 46;
            // 
            // webBrowserLocation
            // 
            this.webBrowserLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserLocation.Location = new System.Drawing.Point(0, 0);
            this.webBrowserLocation.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserLocation.Name = "webBrowserLocation";
            this.webBrowserLocation.Size = new System.Drawing.Size(452, 664);
            this.webBrowserLocation.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBack.Location = new System.Drawing.Point(12, 755);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(231, 99);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 866);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelInCommon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelViewInsertInfoFormFriend);
            this.Controls.Add(this.panelViewMyFriend);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormFriends";
            this.Text = "Friends";
            this.Load += new System.EventHandler(this.FormFriends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).EndInit();
            this.panelViewMyFriend.ResumeLayout(false);
            this.panelViewMyFriend.PerformLayout();
            this.panelViewInsertInfoFormFriend.ResumeLayout(false);
            this.panelViewInsertInfoFormFriend.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfile;
        private System.Windows.Forms.RichTextBox richTextBoxLatestPost;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Panel panelViewMyFriend;
        private System.Windows.Forms.Panel panelViewInsertInfoFormFriend;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowserLocation;
        private System.Windows.Forms.Button buttonViewFriendOnFB;
        private System.Windows.Forms.Label labelInCommon;
        private ButtonBack buttonBack;
    }
}