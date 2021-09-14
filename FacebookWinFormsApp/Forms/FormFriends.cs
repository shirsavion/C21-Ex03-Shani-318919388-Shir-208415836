﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormFriends : Form
    {
        private readonly FacadeManager r_FacadeManager;
        private UserFoundFriendProxy m_FoundFriend;
        internal BackToLandingVisitor GoBackVisitor;

        public FormFriends(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
            GoBackVisitor = new BackToLandingVisitor();
        }

        private void FormFriends_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Add("Birthday");
            comboBoxCategory.Items.Add("Checks in");
            comboBoxCategory.Items.Add("Events you are not sure about");
            comboBoxCategory.Items.Add("Liked pages");
            comboBoxCategory.Items.Add("Relationship status");
            visibilityControls(false);
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            visibilityControls(false);
            string selectedCategory = comboBoxCategory.Items[comboBoxCategory.SelectedIndex].ToString();
            Thread thread = new Thread(() =>
            {
                m_FoundFriend =
                    r_FacadeManager.GetMyRandomFriendAccordingToCategory(selectedCategory); // I WANT TO RETURN ALSO THE mutual OBJ
                showFriend(); // AND SEND IT HERE, too
            });   
            thread.Start();
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            TextBox textBoxSearch = sender as TextBox;
            textBoxSearch.Text = "";
            textBoxSearch.ReadOnly = false;
            textBoxSearch.ForeColor = Color.Black;

            if (m_FoundFriend != null)
            {
                m_FoundFriend.CommonStr = "";
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            labelInCommon.Text = "";
            new Thread(searchFriendAndShow).Start();
        }

        private void searchFriendAndShow()
        {
            try
            {
                Predicate<User> predicate = CompareName;
                m_FoundFriend = new UserFoundFriendProxy(r_FacadeManager.LoggedInUser.Friends.Find(predicate));
                showFriend();
            }
            catch
            {
                MessageBox.Show("No such friend, Mi Amigo!");
            }
        }

        private bool CompareName(User cur_user)
        {
            return cur_user.Name == textBoxSearch.Text;
        }

        private void showFriend()
        {
            if (m_FoundFriend != null)
            {
                setLabelsInformationFoundFriend();

                if (m_FoundFriend.Posts.Count > 0)
                {
                    labelPost.Invoke(new Action(()=>labelPost.Visible = true));
                    richTextBoxLatestPost.Invoke(new Action(()=>
                    {
                        richTextBoxLatestPost.Text = m_FoundFriend.Posts[0].Message;
                        richTextBoxLatestPost.Visible = true;
                    }));
                }
            }
            else
            {
                visibilityControls(false);
                MessageBox.Show("No friend found.");
            }
        }

        private void setLabelsInformationFoundFriend()
        {
            pictureBoxFriendProfile.Invoke(new Action(()=>pictureBoxFriendProfile.LoadAsync(m_FoundFriend.PictureLargeURL)));
            pictureBoxFriendProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            visibilityControls(true);
            labelDetails.Invoke(new Action(() => labelDetails.Text = m_FoundFriend.ToString()));
            labelInCommon.Invoke(new Action (() => labelInCommon.Text = m_FoundFriend.CommonStr));
            loadInformaionToBrowser(m_FoundFriend);
        }

        private void loadInformaionToBrowser(UserFoundFriendProxy i_FoundFriend)
        {
            try
            {
                StringBuilder friendAdreesLocation = new StringBuilder();
                FacebookWrapper.ObjectModel.City friendLocation = i_FoundFriend.Location;
                friendAdreesLocation.Append("https://www.bing.com/maps?q=");

                if (friendLocation != null)
                {
                    if (friendLocation.Location != null)
                    {
                        if (friendLocation.Location.Street != String.Empty)
                        {
                            friendAdreesLocation.Append(friendLocation.Location.Street + "," + "+");
                        }

                        if (friendLocation.Location.City != String.Empty)
                        {
                            friendAdreesLocation.Append(friendLocation.Location.City + "," + "+");
                        }

                        if (friendLocation.Location.Country != String.Empty)
                        {
                            friendAdreesLocation.Append(friendLocation.Location.Country + "," + "+");
                        }

                        if (friendLocation.Location.State != String.Empty)
                        {
                            friendAdreesLocation.Append(friendLocation.Location.State + "," + "+");
                        }

                        if (friendLocation.Location.Zip != String.Empty)
                        {
                            friendAdreesLocation.Append(friendLocation.Location.Zip + "," + "+");
                        }
                    }
                    else
                    {
                        friendAdreesLocation.Append(friendLocation.ToString() + "," + "+");
                    }

                    webBrowserLocation.Invoke(new Action(() => webBrowserLocation.Navigate(friendAdreesLocation.ToString())));
                }
                else
                {
                    throw new Exception("Coudldn't load friend's location.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "No valid location");
            }
        }

        private void visibilityControls(bool i_Visibilty)
        {
            pictureBoxFriendProfile.Invoke(new Action(()=>pictureBoxFriendProfile.Visible = i_Visibilty));
            labelDetails.Invoke(new Action(() => labelDetails.Visible = i_Visibilty));
            buttonViewFriendOnFB.Invoke(new Action(()=>buttonViewFriendOnFB.Visible = i_Visibilty));
            webBrowserLocation.Invoke(new Action(() => webBrowserLocation.Visible = i_Visibilty));
            labelInCommon.Invoke(new Action(() => labelInCommon.Visible = i_Visibilty));
            if (i_Visibilty == false)
            {
                labelPost.Invoke(new Action(() =>labelPost.Visible = i_Visibilty));
                richTextBoxLatestPost.Invoke(new Action(()=> richTextBoxLatestPost.Visible = i_Visibilty));
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            bool friend_view_visibily = false;
            visibilityControls(friend_view_visibily);
        }

        private void buttonViewFriendOnFB_Click(object sender, EventArgs e)
        {
            if (m_FoundFriend == null)
            {
                MessageBox.Show("There is no friend to make contact with.", "No friend to make contact"); // REBUNDANT
            }
            else
            {
                System.Diagnostics.Process.Start(m_FoundFriend.Link);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeAndGoToLandingPage(this);
            r_FacadeManager.UpdateTimeSpan();
        }
    }
}
