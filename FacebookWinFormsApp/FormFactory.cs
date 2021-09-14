using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Forms;
using FacebookApp;
using FacebookApp.Logic;

namespace BasicFacebookFeatures
{
    internal static class FormFactory
    {
        public enum eFormType
        {
            FormLogin,
            FormApp,
            FormAlbums,
            FormBirthday,
            FormEvents,
            FormFriends,
            FormGroups,
            FormPosts
        }

        private static FormLogin s_FormLogin;

        public static Form CreateFormAccordingToType(eFormType i_TypeOfFormToCreate)
        {
            Form formToReturn = null;
            if (i_TypeOfFormToCreate != eFormType.FormLogin && s_FormLogin == null)
            {
                throw new ProgrammerMisuseException("No login info.", "FormLogin");
            }

            switch (i_TypeOfFormToCreate)
            {
                case eFormType.FormLogin:
                    s_FormLogin = new FormLogin();
                    formToReturn = s_FormLogin;
                    break;
                case eFormType.FormAlbums:
                    formToReturn = new FormAlbums(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormApp:
                    formToReturn = new FormApp(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormBirthday:
                    formToReturn = new FormBirthdays(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormGroups:
                    formToReturn = new FormGroups(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormPosts:
                    formToReturn = new FormPosts(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormEvents:
                    formToReturn = new FormEvents(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormFriends:
                    formToReturn = new FormFriends(s_FormLogin.FacadeManager);
                    break;
                default:
                    throw new Exception("invalid form to create.");
            }

            return formToReturn;
        }
    }
}

