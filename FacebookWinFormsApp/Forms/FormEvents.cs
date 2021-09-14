using System;
using System.Windows.Forms;
using FacebookApp.Logic;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormEvents : Form
    {
        private readonly FacadeManager r_FacadeManager;
        internal BackToLandingVisitor GoBackVisitor;

        public FormEvents(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
            GoBackVisitor = new BackToLandingVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchUserNotRepliedEvents();
        }

        private void fetchUserNotRepliedEvents()
        {
            try
            {
                eventBindingSource.DataSource = r_FacadeManager.LoggedInUser.EventsNotYetReplied;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void linkToFacebookLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((sender as LinkLabel).Text);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeAndGoToLandingPage(this);
            r_FacadeManager.UpdateTimeSpan();
        }
    }
}
