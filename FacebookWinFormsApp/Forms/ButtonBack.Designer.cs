using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    partial class ButtonBack : Button
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

        
        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.buttonBackBG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Location = new System.Drawing.Point(17, 613);
            this.Size = new System.Drawing.Size(231, 99);
            this.TabIndex = 1;
            this.UseVisualStyleBackColor = false;
            this.Text = "";
        }

        #endregion
    }
}
