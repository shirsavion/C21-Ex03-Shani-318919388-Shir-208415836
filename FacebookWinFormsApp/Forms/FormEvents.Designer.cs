
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    partial class FormEvents
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
            System.Windows.Forms.Label attendingCountLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label linkToFacebookLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvents));
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNotRepliedEvents = new System.Windows.Forms.Label();
            this.panelEventDetails = new System.Windows.Forms.Panel();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.attendingCountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.linkToFacebookLinkLabel = new System.Windows.Forms.LinkLabel();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonBack = new BasicFacebookFeatures.Forms.ButtonBack();
            attendingCountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            linkToFacebookLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.panelEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // attendingCountLabel
            // 
            attendingCountLabel.AutoSize = true;
            attendingCountLabel.BackColor = System.Drawing.Color.Transparent;
            attendingCountLabel.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            attendingCountLabel.Location = new System.Drawing.Point(29, 298);
            attendingCountLabel.Name = "attendingCountLabel";
            attendingCountLabel.Size = new System.Drawing.Size(152, 25);
            attendingCountLabel.TabIndex = 0;
            attendingCountLabel.Text = "Attending Count:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            descriptionLabel.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            descriptionLabel.Location = new System.Drawing.Point(29, 133);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(109, 25);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.BackColor = System.Drawing.Color.Transparent;
            endTimeLabel.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            endTimeLabel.Location = new System.Drawing.Point(29, 356);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(96, 25);
            endTimeLabel.TabIndex = 4;
            endTimeLabel.Text = "End Time:";
            // 
            // linkToFacebookLabel
            // 
            linkToFacebookLabel.AutoSize = true;
            linkToFacebookLabel.BackColor = System.Drawing.Color.Transparent;
            linkToFacebookLabel.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            linkToFacebookLabel.Location = new System.Drawing.Point(145, 414);
            linkToFacebookLabel.Name = "linkToFacebookLabel";
            linkToFacebookLabel.Size = new System.Drawing.Size(157, 25);
            linkToFacebookLabel.TabIndex = 8;
            linkToFacebookLabel.Text = "Link To Facebook:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.BackColor = System.Drawing.Color.Transparent;
            startTimeLabel.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            startTimeLabel.Location = new System.Drawing.Point(29, 331);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(102, 25);
            startTimeLabel.TabIndex = 12;
            startTimeLabel.Text = "Start Time:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.BackColor = System.Drawing.Color.Transparent;
            nameLabel1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            nameLabel1.Location = new System.Drawing.Point(33, 228);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(120, 25);
            nameLabel1.TabIndex = 15;
            nameLabel1.Text = "Owner Name:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            nameLabel.Location = new System.Drawing.Point(34, 257);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(104, 25);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Take Place:";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // labelNotRepliedEvents
            // 
            this.labelNotRepliedEvents.AutoSize = true;
            this.labelNotRepliedEvents.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotRepliedEvents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNotRepliedEvents.Location = new System.Drawing.Point(26, 28);
            this.labelNotRepliedEvents.Name = "labelNotRepliedEvents";
            this.labelNotRepliedEvents.Size = new System.Drawing.Size(187, 25);
            this.labelNotRepliedEvents.TabIndex = 5;
            this.labelNotRepliedEvents.Text = "You havn\'t replied to..";
            // 
            // panelEventDetails
            // 
            this.panelEventDetails.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.Blue_wood_BG_forEventPanel;
            this.panelEventDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEventDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEventDetails.Controls.Add(nameLabel);
            this.panelEventDetails.Controls.Add(this.nameLabel3);
            this.panelEventDetails.Controls.Add(nameLabel1);
            this.panelEventDetails.Controls.Add(this.nameLabel2);
            this.panelEventDetails.Controls.Add(this.imageNormalPictureBox);
            this.panelEventDetails.Controls.Add(attendingCountLabel);
            this.panelEventDetails.Controls.Add(this.attendingCountTextBox);
            this.panelEventDetails.Controls.Add(descriptionLabel);
            this.panelEventDetails.Controls.Add(this.descriptionTextBox);
            this.panelEventDetails.Controls.Add(endTimeLabel);
            this.panelEventDetails.Controls.Add(this.endTimeDateTimePicker);
            this.panelEventDetails.Controls.Add(linkToFacebookLabel);
            this.panelEventDetails.Controls.Add(this.linkToFacebookLinkLabel);
            this.panelEventDetails.Controls.Add(startTimeLabel);
            this.panelEventDetails.Controls.Add(this.startTimeDateTimePicker);
            this.panelEventDetails.Location = new System.Drawing.Point(529, 70);
            this.panelEventDetails.Name = "panelEventDetails";
            this.panelEventDetails.Size = new System.Drawing.Size(521, 479);
            this.panelEventDetails.TabIndex = 6;
            // 
            // nameLabel3
            // 
            this.nameLabel3.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Place.Name", true));
            this.nameLabel3.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            this.nameLabel3.Location = new System.Drawing.Point(202, 259);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(263, 23);
            this.nameLabel3.TabIndex = 17;
            // 
            // nameLabel2
            // 
            this.nameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Owner", true));
            this.nameLabel2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            this.nameLabel2.Location = new System.Drawing.Point(202, 230);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(263, 23);
            this.nameLabel2.TabIndex = 16;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(25, 26);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(131, 91);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 14;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // attendingCountTextBox
            // 
            this.attendingCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "AttendingCount", true));
            this.attendingCountTextBox.Location = new System.Drawing.Point(205, 298);
            this.attendingCountTextBox.Name = "attendingCountTextBox";
            this.attendingCountTextBox.ReadOnly = true;
            this.attendingCountTextBox.Size = new System.Drawing.Size(260, 22);
            this.attendingCountTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(205, 133);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.descriptionTextBox.Size = new System.Drawing.Size(260, 83);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(205, 359);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(260, 22);
            this.endTimeDateTimePicker.TabIndex = 5;
            // 
            // linkToFacebookLinkLabel
            // 
            this.linkToFacebookLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.linkToFacebookLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
            this.linkToFacebookLinkLabel.Location = new System.Drawing.Point(321, 416);
            this.linkToFacebookLinkLabel.Name = "linkToFacebookLinkLabel";
            this.linkToFacebookLinkLabel.Size = new System.Drawing.Size(200, 23);
            this.linkToFacebookLinkLabel.TabIndex = 9;
            this.linkToFacebookLinkLabel.TabStop = true;
            this.linkToFacebookLinkLabel.Text = "linkLabel1";
            this.linkToFacebookLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToFacebookLinkLabel_LinkClicked);
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(205, 331);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(260, 22);
            this.startTimeDateTimePicker.TabIndex = 13;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.ItemHeight = 23;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 70);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(398, 303);
            this.listBoxEvents.TabIndex = 3;
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
            this.buttonBack.Location = new System.Drawing.Point(12, 650);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(231, 99);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1294, 761);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelEventDetails);
            this.Controls.Add(this.labelNotRepliedEvents);
            this.Controls.Add(this.listBoxEvents);
            this.Name = "FormEvents";
            this.Text = "Events";
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.panelEventDetails.ResumeLayout(false);
            this.panelEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNotRepliedEvents;
        private System.Windows.Forms.Panel panelEventDetails;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.TextBox attendingCountTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.LinkLabel linkToFacebookLinkLabel;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label nameLabel2;
        private Label nameLabel3;
        private ButtonBack buttonBack;
    }
}