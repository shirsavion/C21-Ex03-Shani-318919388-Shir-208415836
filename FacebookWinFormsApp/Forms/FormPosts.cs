using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormPosts : Form
    {
        private readonly FacadeManager r_FacadeManager;
        internal BackToLandingVisitor GoBackVisitor;

        public FormPosts(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
            GoBackVisitor = new BackToLandingVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchPosts).Start();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            { 
                Status postedStatus = r_FacadeManager.LoggedInUser.PostStatus(textBoxPosts.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                const string caption = "Facebook Error!";
                MessageBox.Show(ex.ToString(),caption);
            }
        }

        private void fetchPosts()
        {
            try
            {
                listBoxPosts.Invoke(new Action(()=>listBoxPosts.Items.Clear()));
                foreach (Post post in r_FacadeManager.LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                    }
                    else if (post.Caption != null)
                    {
                       listBoxPosts.Invoke(new Action(()=> listBoxPosts.Items.Add(post.Caption)));
                    }
                    else
                    {
                        listBoxPosts.Invoke((new Action(()=>listBoxPosts.Items.Add(string.Format("[{0}]", post.Type)))));
                    }
                }
            }
            catch (Exception ex)
            {
                const string caption = "Facebook Error!";
                MessageBox.Show(ex.ToString(), caption);
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPost.Image = null;
            int selectedIndex = listBoxPosts.SelectedIndex;
            showCommentsPost(selectedIndex);
        }

        private void showCommentsPost(int i_SelctedIndex)
        {
            Post selected = r_FacadeManager.LoggedInUser.Posts[i_SelctedIndex];
            if (selected != null)
            {
                if (selected.Type == Post.eType.photo && selected.PictureURL != null)
                {
                    pictureBoxPost.Invoke(new Action(() => pictureBoxPost.LoadAsync(selected.PictureURL)));
                }

                try 
                {
                    listBoxPostComment.Invoke(new Action(() => listBoxPostComment.DisplayMember = "Message"));
                    listBoxPostComment.Invoke(new Action(() => listBoxPostComment.DataSource = selected.Comments));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Loading comments went wrong");
                }
            }
        }

        private void listBoxPostComment_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxComment.Image = null;
            Post selected = r_FacadeManager.LoggedInUser.Posts[listBoxPostComment.SelectedIndex];
            if (selected.Type == Post.eType.photo)
            {
                pictureBoxComment.LoadAsync(selected.PictureURL);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeAndGoToLandingPage(this);
            r_FacadeManager.UpdateTimeSpan();
        }
    }
}
