
namespace BasicFacebookFeatures.Forms
{
    partial class FormBirthdays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBirthdays));
            this.buttonAddBDCard = new System.Windows.Forms.Button();
            this.flowLayoutPanelBDCards = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBoxBDCard = new System.Windows.Forms.RichTextBox();
            this.labelCard = new System.Windows.Forms.Label();
            this.listBoxBDFriends = new System.Windows.Forms.ListBox();
            this.buttonBack1 = new BasicFacebookFeatures.Forms.ButtonBack();
            this.SuspendLayout();
            // 
            // buttonAddBDCard
            // 
            this.buttonAddBDCard.AccessibleDescription = "Add Card";
            this.buttonAddBDCard.AccessibleName = "Add Card";
            this.buttonAddBDCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddBDCard.BackgroundImage")));
            this.buttonAddBDCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddBDCard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAddBDCard.FlatAppearance.BorderSize = 0;
            this.buttonAddBDCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBDCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBDCard.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddBDCard.Location = new System.Drawing.Point(228, 126);
            this.buttonAddBDCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddBDCard.Name = "buttonAddBDCard";
            this.buttonAddBDCard.Size = new System.Drawing.Size(114, 36);
            this.buttonAddBDCard.TabIndex = 2;
            this.buttonAddBDCard.Tag = "";
            this.buttonAddBDCard.Text = "Add Card";
            this.buttonAddBDCard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonAddBDCard.Click += new System.EventHandler(this.buttonAddBDCard_Click);
            // 
            // flowLayoutPanelBDCards
            // 
            this.flowLayoutPanelBDCards.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBDCards.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelBDCards.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanelBDCards.Location = new System.Drawing.Point(364, 52);
            this.flowLayoutPanelBDCards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelBDCards.Name = "flowLayoutPanelBDCards";
            this.flowLayoutPanelBDCards.Size = new System.Drawing.Size(380, 350);
            this.flowLayoutPanelBDCards.TabIndex = 1;
            // 
            // richTextBoxBDCard
            // 
            this.richTextBoxBDCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxBDCard.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxBDCard.Location = new System.Drawing.Point(20, 52);
            this.richTextBoxBDCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxBDCard.Name = "richTextBoxBDCard";
            this.richTextBoxBDCard.ReadOnly = true;
            this.richTextBoxBDCard.Size = new System.Drawing.Size(321, 70);
            this.richTextBoxBDCard.TabIndex = 0;
            this.richTextBoxBDCard.Text = "Tell your friends how much you care, \nbut in you own special way...";
            this.richTextBoxBDCard.Click += new System.EventHandler(this.richTextBoxBDCard_Click);
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCard.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelCard.Location = new System.Drawing.Point(19, 24);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(220, 26);
            this.labelCard.TabIndex = 3;
            this.labelCard.Text = "Create Birthday Card!";
            // 
            // listBoxBDFriends
            // 
            this.listBoxBDFriends.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBDFriends.FormattingEnabled = true;
            this.listBoxBDFriends.ItemHeight = 23;
            this.listBoxBDFriends.Location = new System.Drawing.Point(20, 222);
            this.listBoxBDFriends.Name = "listBoxBDFriends";
            this.listBoxBDFriends.Size = new System.Drawing.Size(137, 165);
            this.listBoxBDFriends.TabIndex = 4;
            this.listBoxBDFriends.Visible = false;
            this.listBoxBDFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxBDFriends_SelectedIndexChanged);
            // 
            // buttonBack1
            // 
            this.buttonBack1.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack1.BackgroundImage")));
            this.buttonBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack1.FlatAppearance.BorderSize = 0;
            this.buttonBack1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonBack1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack1.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBack1.Location = new System.Drawing.Point(-8, 393);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(135, 45);
            this.buttonBack1.TabIndex = 1;
            this.buttonBack1.UseVisualStyleBackColor = false;
            this.buttonBack1.Click += new System.EventHandler(this.buttonBack1_Click);
            // 
            // FormBirthdays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.listBoxBDFriends);
            this.Controls.Add(this.labelCard);
            this.Controls.Add(this.richTextBoxBDCard);
            this.Controls.Add(this.flowLayoutPanelBDCards);
            this.Controls.Add(this.buttonAddBDCard);
            this.Name = "FormBirthdays";
            this.Text = "Birthdays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddBDCard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBDCards;
        private System.Windows.Forms.RichTextBox richTextBoxBDCard;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.ListBox listBoxBDFriends;
        private ButtonBack buttonBack1;
    }
}