using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormAlbumsPhotos : Form
    {
        private int m_IndexChosenAlbum;
        private readonly FacadeManager r_FacadeManager;
        private FormPhoto m_ChildFormPhotos;

        public FormAlbumsPhotos(FacadeManager i_FacadeManager, int i_IndexOfChosenAlbum, string i_AlbumName)
        {
            InitializeComponent();
            m_IndexChosenAlbum = i_IndexOfChosenAlbum;
            r_FacadeManager = i_FacadeManager;
            Text = i_AlbumName;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchPhotos).Start();
        }

        private void fetchPhotos()
        {
            try
            {
                foreach (Photo photo in r_FacadeManager.LoggedInUser.Albums[m_IndexChosenAlbum].Photos)
                {
                    PictureBox pictureBoxAlbum = new PictureBox();
                    pictureBoxAlbum.Image = photo.ImageAlbum;
                    pictureBoxAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxAlbum.Click += pictureBoxPhoto_Clicked;
                    flowLayoutPanelAlbums.Invoke(new Action(() => flowLayoutPanelAlbums.Controls.Add(pictureBoxAlbum)));
                }
            }
            catch (Exception ex)
            {
                string caption = "Facebook Error fetching photos";
                MessageBox.Show(ex.Message, caption);
            }
        }

        private void pictureBoxPhoto_Clicked(object sender, EventArgs e)
        {
            Image photoToShow = (sender as PictureBox).Image;
            new Thread(() => showFormPhoto(photoToShow)).Start();
        }

        private void showFormPhoto(Image i_photoToShow)
        {
            m_ChildFormPhotos =new FormPhoto(i_photoToShow);
            m_ChildFormPhotos.ShowDialog();
        }
    }
}
