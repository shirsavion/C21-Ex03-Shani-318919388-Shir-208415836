using System;
using System.Windows.Forms;
using BasicFacebookFeatures;
using Facebook;
using FacebookWrapper;
using FacebookApp.Logic;

namespace FacebookApp
{
    public partial class FormLogin : Form
    {
        private Form m_AppForm;
        private readonly FacadeManager r_FacadeManager;

        public FormLogin()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            r_FacadeManager = FacadeManager.Instance; // Singelton - changed to Instance
        }

        public FacadeManager FacadeManager
        {
            get { return r_FacadeManager; }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns"); /// the current password for Desig Patter
            try
            {  
                r_FacadeManager.InitializationAppSettings();
                r_FacadeManager.LoginToFacebook();

                if (r_FacadeManager.IsLoginResultAccessTokenNotNullOrEmpty())
                {
                    buttonLogin.Text = $"logged in as {r_FacadeManager.LoggedInUser.Name}";
                    m_AppForm = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormApp);
                    m_AppForm.ShowDialog();
                    buttonLogin.Text = "Login";
                }
                else
                {
                    MessageBox.Show(r_FacadeManager.LoginResult.ErrorMessage, "Login Failed");
                }
            }
            catch (FacebookOAuthException exception)
            {
                r_FacadeManager.HandleErrorWithsUserPermission();
                MessageBox.Show(exception.Message, "Login Failed");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Login Failed");
            }
        }
    }
}
