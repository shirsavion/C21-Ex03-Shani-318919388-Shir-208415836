using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormAlbums : Form
    {
        private readonly FacadeManager r_FacadeManager;
        private FormAlbumsPhotos m_childFormAlbumsPhotos;
        internal BackToLandingVisitor GoBackVisitor { get; set; }

        public FormAlbums(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
            GoBackVisitor = new BackToLandingVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchAlbums).Start();
        }

        private void fetchAlbums()
        {
            int indexOfAlbums = 0;

            try
            {
                foreach (Album album in r_FacadeManager.LoggedInUser.Albums)
                {
                    PictureBox pictureBoxAlbum = new PictureBox();
                    pictureBoxAlbum.Image = album.ImageAlbum;
                    pictureBoxAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
                    Label labelAlbumName = new Label();
                    labelAlbumName.Text = album.Name;
                    labelAlbumName.ForeColor = Color.White;
                    labelAlbumName.BackColor = Color.Transparent;
                    pictureBoxAlbum.Controls.Add(labelAlbumName);
                    pictureBoxAlbum.TabIndex = indexOfAlbums;
                    pictureBoxAlbum.Click += pictureBoxAlbum_Clicked;
                    flowLayoutPanelAlbums.Invoke(new Action(() => flowLayoutPanelAlbums.Controls.Add(pictureBoxAlbum)));
                    indexOfAlbums++;
                }
            }
            catch (Exception ex)
            {
                string caption = "Facebook Error fetching albums.";
                MessageBox.Show(ex.Message, caption);
            }

        }

        private void pictureBoxAlbum_Clicked(object sender, EventArgs e)
        {
            int indexOfChosenAlbum = (sender as PictureBox).TabIndex;
            string nameOfAlbum = (sender as PictureBox).Controls[0].Text;

            if (r_FacadeManager.LoggedInUser.Albums[indexOfChosenAlbum].Photos.Count > 0)
            {
                new Thread(()=>showFormAlbumsPhotos(indexOfChosenAlbum,nameOfAlbum)).Start();
            }
            else
            {
                string caption = "No Photos.";
                MessageBox.Show("There is no photos in this album", caption);
            }
        }

        private void showFormAlbumsPhotos(int i_IndexOfChosenAlbum, String I_NameOfAlbum)
        {
            m_childFormAlbumsPhotos =new FormAlbumsPhotos(r_FacadeManager,i_IndexOfChosenAlbum, I_NameOfAlbum);
            m_childFormAlbumsPhotos.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeAndGoToLandingPage(this);
            r_FacadeManager.UpdateTimeSpan();
        }
    }
}



















































