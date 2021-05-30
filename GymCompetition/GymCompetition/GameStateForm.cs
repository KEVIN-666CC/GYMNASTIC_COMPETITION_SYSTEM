using GymCompetitionTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymCompetition
{
    public partial class GameStateForm : Form
    {
        public GameStateForm()
        {
            InitializeComponent();
        }

        GymCompetitionService service = new GymCompetitionService();

        public static int playOrder = 0;

        public GameInformation GameInfo { get; set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            GameInfo = service.CurrentGameInfo(++playOrder);
            if (GameInfo == null)
            {
                MessageBox.Show("比赛完毕！");
                return;
            }
            itemname.Text = service.SearchItemById(GameInfo.ItemId)[0].Name;
            sexagegroup.Text = service.SearchItemById(GameInfo.ItemId)[0].AgeAndSexGroup;
            groupnumber.Text = GameInfo.GroupNumber.ToString();
            athletenumber.Text = GameInfo.AthleteNum;
            playorder.Text = GameInfo.PlayOrder.ToString();

            List<RefereeScore> refereeScores = service.SearchRefereeScoreByGameInfoId(GameInfo.Id);
            for (int j = 0; j < refereeScores.Count; j++)
            {
                if (refereeScores[j].ChiefReferee)
                {
                    creferee.Text = service.SearchRefereeByIdCard(refereeScores[j].RefereeId)[0].Name;
                    refereeScores.RemoveAt(j);
                    break;
                }
            }

            int count = refereeScores.Count;
            int i = 0;
            while (i < 5)
            {
                switch (i)
                {
                    case 0:
                        referee1.Text = (i < count) ? service.SearchRefereeByIdCard(refereeScores[0].RefereeId)[0].Name : "null";
                        i++;
                        break;
                    case 1:
                        referee2.Text = (i < count) ? service.SearchRefereeByIdCard(refereeScores[1].RefereeId)[0].Name : "null";
                        i++;
                        break;
                    case 2:
                        referee3.Text = (i < count) ? service.SearchRefereeByIdCard(refereeScores[2].RefereeId)[0].Name : "null";
                        i++;
                        break;
                    case 3:
                        referee4.Text = (i < count) ? service.SearchRefereeByIdCard(refereeScores[3].RefereeId)[0].Name : "null";
                        i++;
                        break;
                    case 4:
                        referee5.Text = (i < count) ? service.SearchRefereeByIdCard(refereeScores[4].RefereeId)[0].Name : "null";
                        i++;
                        break;
                }
            }
        }

        private void playorder_Click(object sender, EventArgs e)
        {

        }

        private void raferee_Click(object sender, EventArgs e)
        {
            Login login = new Login(false, GameInfo);
            login.Show();
        }

        private void chiefreferee_Click(object sender, EventArgs e)
        {
            Login login = new Login(true, GameInfo);
            login.Show();
        }
    }
}
