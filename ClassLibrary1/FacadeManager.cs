using System;
using System.Collections.Generic;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookApp.Logic.ObservantObservee;

namespace FacebookApp
{
    namespace Logic
    {
        public sealed class FacadeManager : ISubject
        {
            private static readonly object sr_CreateLock = new object();
            private User m_LoggedInUser;
            private LoginResult m_LoginResult;
            private AppSettings m_AppSettings;
            private static FacadeManager s_This;
            private List<IObserver> m_Observers;

            public static FacadeManager Instance
            {
                get
                {
                    if (s_This == null)
                    {
                        lock (sr_CreateLock)
                        {
                            s_This = new FacadeManager();
                        }
                    }

                    return s_This;
                }
            }

            private FacadeManager()
            {
                m_LoginResult = null;
                m_LoggedInUser = null;
                m_AppSettings = null;
                m_Observers = new List<IObserver>();
            }

            public User LoggedInUser
            {
                get
                {
                    return m_LoggedInUser;
                }
                set
                {
                    m_LoggedInUser = value;
                }
            }

            public LoginResult LoginResult
            {
                get
                {
                    return m_LoginResult;
                }
            }

            public List<String> BDCards
            {
                get
                {
                    return m_AppSettings.BDCards;
                }
            }

            public Point LastWindowsLocation
            {
                get
                {
                    return m_AppSettings.LastWindowsLocation;
                }
            }

            public Size LastWindowsSize
            {
                get
                {
                    return m_AppSettings.LastWindowsSize;
                }
            }

            public bool RememberUser
            {
                get
                {
                    return m_AppSettings.RememberUser;
                }
            }

            public void InitializationAppSettings()
            {
                m_AppSettings = AppSettings.LoadFromFile();
            }

            public void LogoutFromFacebook()
            {
                if (m_AppSettings.LastAccessToken == null)
                {
                    FacebookService.LogoutWithUI();
                }

                m_LoginResult = null;
            }

            public void RememberFormDetails(bool i_RememberUser, Size i_WindowsSize, Point i_WindowsLocation)
            {
                m_AppSettings.LastWindowsSize = i_WindowsSize;
                m_AppSettings.LastWindowsLocation = i_WindowsLocation;
                m_AppSettings.RememberUser = i_RememberUser;

                if (m_AppSettings.RememberUser && m_LoginResult != null)
                {
                    m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                }
                else
                {
                    m_AppSettings.LastAccessToken = null;
                }

                m_AppSettings.SaveToFile();
            }

            public UserFoundFriendProxy GetMyRandomFriendAccordingToCategory(string i_ChosenCategory)
            {
               string  o_InCommon = "";

                if (m_LoggedInUser == null)
                {
                    throw new ProgrammerMisuseException("No login info.", "User");
                }

                return Features.GetMyRandomFriendAccordingToCategory(this,i_ChosenCategory, out o_InCommon);
            }

            private bool checkIfAutoLogin()
            {
                bool autoConncet = false;

                if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
                { 
                    m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken); 
                    autoConncet = true;
                }

                return autoConncet;
            }

            public void AddCardToSavedCards(string i_Card_Message)
            {
                Features.AddCardToSavedCards(this,i_Card_Message);
            }

            public void PostBDCard(User i_BDFriend, string i_BDCard)
            {
                if (m_LoggedInUser == null)
                {
                    throw new ProgrammerMisuseException("No login info.", "User");
                }

                Features.PostBDCard(this,i_BDFriend,i_BDCard);
            }

            public List<User> FindAllFriendsWithTodayBDay()
            {
                if (m_LoggedInUser == null)
                {
                    throw new ProgrammerMisuseException("No login info.", "User");
                }

                return Features.FindAllFriendsWithTodayBDay(this);
            }

            public void HandleErrorWithsUserPermission()
            {
                m_AppSettings.LastAccessToken = null;
                m_AppSettings.RememberUser = false;
                m_AppSettings.SaveToFile();
            }

            public void LoginToFacebook()
            {
                if (!checkIfAutoLogin())
                {
                    m_LoginResult = FacebookService.Login(
                        /// Our App ID:
                        "1233842327054575",
                        /// requested permissions:
                        "email",
                        "public_profile",
                        "user_age_range",
                        "user_birthday",
                        "user_events",
                        "user_friends",
                        "user_gender",
                        "user_hometown",
                        "user_likes",
                        "user_link",
                        "user_location",
                        "user_photos",
                        "user_posts",
                        "user_videos"
                    );
                }

                if (IsLoginResultAccessTokenNotNullOrEmpty())
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                }
            }

            public bool IsLoginResultAccessTokenNotNullOrEmpty()
            {
                return (!string.IsNullOrEmpty(m_LoginResult.AccessToken));
            }

            public void Attach(IObserver i_Observer)
            {
                if (!m_Observers.Contains(i_Observer))
                {
                    m_Observers.Add(i_Observer);
                }
            }

            public void Detach(IObserver i_Observer)
            {
                if (m_Observers.Contains(i_Observer))
                {
                    m_Observers.Remove(i_Observer);
                }
            }

            private void notify()
            {
                bool timeNeedsUpdate = true;
                if (m_Observers.Count > 0)
                {
                    foreach (IObserver observer in m_Observers)
                    {
                        observer.UpdateByState(timeNeedsUpdate);
                    }
                }
            }

            public void UpdateTimeSpan()
            {
                notify();
            }
        }
    }
}
