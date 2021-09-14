using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormPhoto : Form
    {
        private readonly Image r_PhotoToShow;

        public FormPhoto(Image i_PhotoToShow)
        {
            InitializeComponent();
            r_PhotoToShow = i_PhotoToShow;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchPhoto();
        }

        private void fetchPhoto()
        {
            pictureBoxPhoto.Image = r_PhotoToShow;
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
