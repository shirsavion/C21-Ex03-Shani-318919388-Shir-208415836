
namespace BasicFacebookFeatures.Forms
{
    partial class FormPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPosts));
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.textBoxPosts = new System.Windows.Forms.TextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPostComment = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxComment = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBack = new BasicFacebookFeatures.Forms.ButtonBack();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComment)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(446, 31);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(310, 212);
            this.listBoxPosts.TabIndex = 0;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // textBoxPosts
            // 
            this.textBoxPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPosts.Location = new System.Drawing.Point(27, 31);
            this.textBoxPosts.Multiline = true;
            this.textBoxPosts.Name = "textBoxPosts";
            this.textBoxPosts.Size = new System.Drawing.Size(347, 40);
            this.textBoxPosts.TabIndex = 1;
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetStatus.Location = new System.Drawing.Point(273, 77);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(101, 31);
            this.buttonSetStatus.TabIndex = 2;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(446, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your posts..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(446, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "post\'s comments";
            // 
            // listBoxPostComment
            // 
            this.listBoxPostComment.FormattingEnabled = true;
            this.listBoxPostComment.ItemHeight = 16;
            this.listBoxPostComment.Location = new System.Drawing.Point(446, 294);
            this.listBoxPostComment.Name = "listBoxPostComment";
            this.listBoxPostComment.Size = new System.Drawing.Size(307, 196);
            this.listBoxPostComment.TabIndex = 5;
            this.listBoxPostComment.SelectedIndexChanged += new System.EventHandler(this.listBoxPostComment_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "what\'s on your mind?";
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.Location = new System.Drawing.Point(813, 31);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(204, 212);
            this.pictureBoxPost.TabIndex = 7;
            this.pictureBoxPost.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(810, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Image of the post";
            // 
            // pictureBoxComment
            // 
            this.pictureBoxComment.Location = new System.Drawing.Point(813, 294);
            this.pictureBoxComment.Name = "pictureBoxComment";
            this.pictureBoxComment.Size = new System.Drawing.Size(204, 196);
            this.pictureBoxComment.TabIndex = 9;
            this.pictureBoxComment.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(810, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Image of the comment";
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
            this.buttonBack.Location = new System.Drawing.Point(12, 531);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(193, 75);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1091, 618);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxPost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxPostComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.textBoxPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPosts";
            this.Text = "Posts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TextBox textBoxPosts;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPostComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxComment;
        private System.Windows.Forms.Label label5;
        private ButtonBack buttonBack;
    }
}