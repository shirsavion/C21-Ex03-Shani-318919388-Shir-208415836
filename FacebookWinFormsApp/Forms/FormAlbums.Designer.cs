
namespace BasicFacebookFeatures.Forms
{
    partial class FormAlbums
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
            this.buttonBack = new ButtonBack();
            this.SuspendLayout();
            // 
            // flowLayoutPanelAlbums
            // 
            this.flowLayoutPanelAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelAlbums.AutoScroll = true;
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(175, 82);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(868, 508);
            this.flowLayoutPanelAlbums.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.AccessibleName = "buttonBack";
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.buttonBackBG1;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBack.Location = new System.Drawing.Point(17, 613);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(231, 99);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1193, 724);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.flowLayoutPanelAlbums);
            this.Name = "FormAlbums";
            this.Text = "Albums";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
        private System.Windows.Forms.Button buttonBack;
    }
}