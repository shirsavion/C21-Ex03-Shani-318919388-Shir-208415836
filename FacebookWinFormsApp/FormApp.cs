using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookApp.Logic;
using System.Collections.Generic;
using BasicFacebookFeatures.ObserverObsreveeFiles;
using FacebookApp.Logic.ObservantObservee;

namespace FacebookApp
{
    public partial class FormApp : Form, IObserver
    {
        private Form m_ActiveForm;
        private readonly FacadeManager r_FacadeManager;
        private TimeSpan m_TimeSpentInApp;
        private readonly DateTime r_StartTime;

        public FormApp(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
            StartPosition = FormStartPosition.Manual;
            initializationStyleOfForm();
            (checkBoxRememberMe as ObserveeCheckBox).Attach(panelLogo as ObservantPanel);
            (checkBoxRememberMe as ObserveeCheckBox).Attach(panelMenuPage as ObservantPanel);
            (checkBoxRememberMe as ObserveeCheckBox).Attach(panelHome as ObservantPanel);
            (checkBoxRememberMe as ObserveeCheckBox).Attach(observantPictureBoxIncognito);
            r_StartTime = DateTime.Now;
            updateTimeSpan();
            r_FacadeManager.Attach(this);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchUserBasicInfo();
        }

        public override void Refresh()
        {
            base.Refresh();
        }

        private void initializationStyleOfForm()
        {
            Size = r_FacadeManager.LastWindowsSize;
            Location = r_FacadeManager.LastWindowsLocation;
            checkBoxRememberMe.Checked = r_FacadeManager.RememberUser;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_FacadeManager.RememberFormDetails(checkBoxRememberMe.Checked, Size, Location);
        }

        private void openFormAcoordingToUserSelect(Form i_FormSelcted, object buttonSender)
        {
            if (m_ActiveForm != null)
            {
                m_ActiveForm.Close();
            }

            activateButton(buttonSender);
            m_ActiveForm = i_FormSelcted;
            m_ActiveForm.TopLevel = false;
            m_ActiveForm.FormBorderStyle = FormBorderStyle.None;
            m_ActiveForm.Dock = DockStyle.Fill;
            panelViewSelection.Controls.Add(m_ActiveForm);
            panelViewSelection.Tag = m_ActiveForm;
            m_ActiveForm.BringToFront();
            m_ActiveForm.Show();
        }

        private void activateButton(object buttonSender)
        {
            Button buttonSelected = buttonSender as Button;
            if (buttonSender != null)
            {
                disableButton();
                buttonSelected.BackColor=Color.Gray;
                buttonSelected.ForeColor=Color.White;
                buttonSelected.Font= new System.Drawing.Font("Guttman Haim", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));

            }
        }

        private void disableButton()
        {
            foreach (Control previousButton in panelMenuPage.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.White;
                    previousButton.ForeColor = Color.Black;
                    previousButton.Font= new System.Drawing.Font("Guttman Haim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                }
            }
        }

        private void fetchUserBasicInfo()
        {
            Name = r_FacadeManager.LoggedInUser.Name;
            pictureBoxProfile.Invoke(new Action(()=>
            {
                pictureBoxProfile.LoadAsync(r_FacadeManager.LoggedInUser.PictureLargeURL);
                pictureBoxProfile.Visible = true;
            }));
            labelHelloUser.Invoke(new Action(() => labelHelloUser.Text = $"Hello {r_FacadeManager.LoginResult.LoggedInUser.Name}!"));
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            Form formSelected = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormPosts);
            openFormAcoordingToUserSelect(formSelected, sender);
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            Form formSelected = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormEvents);
            openFormAcoordingToUserSelect(formSelected, sender);
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            Form formSelected = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormGroups);
            openFormAcoordingToUserSelect(formSelected, sender);
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            Form formSelected = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormAlbums);
            openFormAcoordingToUserSelect(formSelected, sender);
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            Form formSelected = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormFriends);
            openFormAcoordingToUserSelect(formSelected, sender);
        }

        private void buttonBirthdays_Click(object sender, EventArgs e)
        {
            Form formSelected = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormBirthday);
            openFormAcoordingToUserSelect(formSelected, sender);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            r_FacadeManager.LogoutFromFacebook();
            checkBoxRememberMe.Checked = false;
            MessageBox.Show("Logout succeeded!");
            Close();
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void UpdateByState(bool i_TimeNeedsUpdate)
        {
            updateTimeSpan();
        }

        private void updateTimeSpan()
        {
            m_TimeSpentInApp = DateTime.Now - r_StartTime;
            labelMinutesInApp.Text = $"Time in Finessebook: {(int)m_TimeSpentInApp.TotalMinutes} minutes";
            this.Refresh();
        }
    }
}
