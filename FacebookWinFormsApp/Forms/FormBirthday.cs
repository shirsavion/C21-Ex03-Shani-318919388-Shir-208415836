using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormBirthdays : Form
    {
        private readonly FacadeManager r_FacadeManager;
        private User m_ChosenFriend;
        internal BackToLandingVisitor GoBackVisitor { get; set; }

        public FormBirthdays(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
            m_ChosenFriend = null;
            GoBackVisitor = new BackToLandingVisitor();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchBirthdayCard();
            new Thread(fetchFriendsBirthday).Start();
        }

        private void fetchFriendsBirthday()
        {
            List<User> BDFriends = r_FacadeManager.FindAllFriendsWithTodayBDay();
            if (BDFriends.Count > 0)
            {
                foreach (User friend in BDFriends)
                {
                    listBoxBDFriends.Invoke(new Action(()=>listBoxBDFriends.Items.Add(friend)));
                }

                listBoxBDFriends.Visible = true;
            }
            else
            {
                const string message = @"None of your friends have their birthday today:( 
In the meantime you can add more cards";
                const string caption = "No Friends For Today";
                MessageBox.Show(message,caption);
            }
        }

        private void fetchBirthdayCard()
        {
            List<string> cards = r_FacadeManager.BDCards;
            flowLayoutPanelBDCards.AutoScroll = true;
            flowLayoutPanelBDCards.Controls.Clear();

            if (cards != null)
            {
                foreach (string card in cards)
                {
                    RichTextBox cardBox = new RichTextBox();
                    cardBox.Text = card;
                    disableChosenCard(cardBox);
                    cardBox.ReadOnly = true;
                    cardBox.Visible = true;
                    cardBox.Click += cardBox_Click;
                    flowLayoutPanelBDCards.Invoke(new Action(() => flowLayoutPanelBDCards.Controls.Add(cardBox)));
                }
            }
        }

        private void disableChosenCard(RichTextBox i_BDCard)
        {
            i_BDCard.BackColor = Color.White;
            i_BDCard.ForeColor = Color.Black;
            i_BDCard.Font = new System.Drawing.Font("Segoe Print", 10F,System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
        }

        private void activateChosenCard(RichTextBox i_BDCard)
        {
            i_BDCard.BackColor = Color.DarkBlue;
            i_BDCard.ForeColor = Color.White;
            i_BDCard.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
        }

        private void cardBox_Click(object sender, EventArgs e)
        {
            RichTextBox chosenCard = sender as RichTextBox;
            if (m_ChosenFriend != null)
            {
                activateChosenCard(chosenCard);
                const string message = "Do you want to post the selected birthday card to your chosen friend?";
                const string caption = "Posting card!";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                try
                {
                    if (result == DialogResult.Yes)
                    {
                        r_FacadeManager.PostBDCard(m_ChosenFriend, (sender as RichTextBox).Text);
                    }
                }
                catch (Exception exception)
                {
                    const string caption1 = "Facebook Error!";
                    MessageBox.Show(exception.ToString(),caption1);
                }
            }

            disableChosenCard(chosenCard);
        }

        private void richTextBoxBDCard_Click(object sender, EventArgs e)
        {
            richTextBoxBDCard.Text = "";
            richTextBoxBDCard.ReadOnly = false;
            richTextBoxBDCard.ForeColor = Color.Black;
        }

        private void buttonAddBDCard_Click(object sender, EventArgs e)
        {
            string bdCard = richTextBoxBDCard.Text;
            r_FacadeManager.AddCardToSavedCards(bdCard);
            fetchBirthdayCard();
        }

        private void listBoxBDFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string message = "Great! Please choose card...";
            const string caption = "Friend chosen!";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                flowLayoutPanelBDCards.Focus();
                m_ChosenFriend = listBoxBDFriends.SelectedItem as User;
            }
        }

        private void buttonBack1_Click(object sender, EventArgs e)
        {
            GoBackVisitor.FadeAndGoToLandingPage(this);
            r_FacadeManager.UpdateTimeSpan();
        }
    }
}
