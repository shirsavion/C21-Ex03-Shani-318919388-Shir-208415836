using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormGroups : Form
    {
        private readonly FacadeManager r_FacadeManager;
        internal BackToLandingVisitor GoBackVisitor;

        public FormGroups(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
            GoBackVisitor = new BackToLandingVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchGroups).Start();
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxGroups.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }

        private void fetchGroups()
        {
            listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Clear()));
            listBoxGroups.Invoke(new Action(() => listBoxGroups.DisplayMember = "Name"));
            try
            {
                foreach (Group group in r_FacadeManager.LoggedInUser.Groups)
                {
                    listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(group)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeAndGoToLandingPage(this);
            r_FacadeManager.UpdateTimeSpan();
        }
    }
}
