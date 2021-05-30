using GymCompetitionTest;
using GymCompetition;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        GymCompetitionService service = new GymCompetitionService();
        public GameInformation GameInfo { get; set; }
        bool chiefReferee = false;

        public Login(bool chiefReferee, GameInformation gameInfo) : this()
        {
            this.chiefReferee = chiefReferee;
            this.GameInfo = gameInfo;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void log_Click(object sender, EventArgs e)
        {
            if (Identity.Text != null && Password.Text != null)
            {
                int n = service.Login(Identity.Text, Password.Text);
                switch (n)
                {
                    case 1:
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Close();
                        break;
                    case 2:
                        List<Team> teams = service.SearchTeamByAccount(Identity.Text);

                        TeamForm teamForm = new TeamForm(teams[0]);
                        teamForm.Show();
                        this.Close();
                        break;
                    case 3:
                        List<RefereeScore> ts = service.SearchRefereeScoreByRefereeIdAndGameInfo(GameInfo.Id, Identity.Text);
                        if (ts.Count > 0)
                        {
                            if (chiefReferee)
                            {
                                ChiefRefereeForm chiefRefereeForm = new ChiefRefereeForm(ts[0]);
                                chiefRefereeForm.Show();
                            }
                            else
                            {
                                OrdinaryRefereeForm refereeForm = new OrdinaryRefereeForm(ts[0]);
                                refereeForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("您不是当前比赛项目分组的裁判！");
                        }
                        this.Close();
                        break;
                    default:
                        MessageBox.Show("账号/密码/姓名错误");
                        break;
                }
            }
            else
            {
                MessageBox.Show("不能为空！");
            }
        }
    }
}
