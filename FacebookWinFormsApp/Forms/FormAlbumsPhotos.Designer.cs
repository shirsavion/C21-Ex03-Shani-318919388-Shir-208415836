
namespace BasicFacebookFeatures.Forms
{
    partial class FormAlbumsPhotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbumsPhotos));
            this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelAlbums
            // 
            this.flowLayoutPanelAlbums.AutoScroll = true;
            this.flowLayoutPanelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(948, 587);
            this.flowLayoutPanelAlbums.TabIndex = 1;
            // 
            // FormAlbumsPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(948, 587);
            this.Controls.Add(this.flowLayoutPanelAlbums);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlbumsPhotos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
    }
}