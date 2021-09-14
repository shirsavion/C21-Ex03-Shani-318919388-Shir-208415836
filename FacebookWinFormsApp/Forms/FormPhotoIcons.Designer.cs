
namespace BasicFacebookFeatures.Forms
{
    partial class FormPhotoIcons
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
            this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelAlbums
            // 
            this.flowLayoutPanelAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelAlbums.AutoScroll = true;
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(32, 29);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(825, 498);
            this.flowLayoutPanelAlbums.TabIndex = 1;
            // 
            // iClickableIcons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(891, 557);
            this.Controls.Add(this.flowLayoutPanelAlbums);
            this.Name = "iClickableIcons";
            this.Text = "iClickableIcons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
    }
}