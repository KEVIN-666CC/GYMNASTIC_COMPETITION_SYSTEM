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
    public partial class TeamForm : Form
    {
        public TeamForm()
        {
            InitializeComponent();
        }

        GymCompetitionService service = new GymCompetitionService();
        public Team team { get; set; }

        public TeamForm(Team team) : this()
        {
            this.team = team;
            label1.Text = ", 欢迎！" + team.Name;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeamForm_Load(object sender, EventArgs e)
        {
            leaderBindingSource.DataSource = service.QueryLeadersByTeamAccout(team.Account);    //调用
            doctorBindingSource.DataSource = service.QueryDoctorsByTeamAccount(team.Account);   //调用
            athleteBindingSource.DataSource = service.QueryAthletesByTeamAccount(team.Account); //调用
            gameInformationBindingSource.DataSource = service.QueryGameInformationById();   //调用
            coachBindingSource.DataSource = service.QueryCoachByTeamAccount(team.Account);  //调用
            refereeBindingSource.DataSource = service.QueryRefereeByTeamAccount(team.Account);  //调用
            itemBindingSource.DataSource = service.QueryItems();    //调用
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                ScanLeader();
                ScanDoctor();
                ScanAthlete();
                ScanGameInfo();
                ScanCoach();
                ScanReferee();
                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("fail: " + ex.Message);
            }
        }

        public void ScanLeader()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;

                Leader leader = new Leader();
                leader.Idcard = row.Cells[0].Value.ToString();
                leader.Name = row.Cells[1].Value.ToString();
                leader.Phonenum = row.Cells[2].Value.ToString();
                leader.TeamAccount = team.Account;

                if (service.SearchLeaderByIdCard(leader.Idcard).Count == 0)
                {
                    service.AddLeader(leader);
                }
                else
                {
                    service.UpdateLeader(leader);
                }
            }
        }

        public void ScanDoctor()
        {

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;

                Doctor doctor = new Doctor();
                doctor.Idcard = row.Cells[0].Value.ToString();
                doctor.Name = row.Cells[1].Value.ToString();
                doctor.Phonenum = row.Cells[2].Value.ToString();
                doctor.TeamAccount = team.Account;

                if (service.SearchDoctorByIdCard(doctor.Idcard).Count == 0)
                {
                    service.AddDoctor(doctor);
                }
                else
                {
                    service.UpdateDoctor(doctor);
                }
            }
        }

        public void ScanAthlete()
        {

            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;

                Athlete athlete = new Athlete();
                athlete.Idcard = row.Cells[0].Value.ToString();
                athlete.Name = row.Cells[1].Value.ToString();
                athlete.Age = Convert.ToInt16(row.Cells[2].Value.ToString());
                athlete.Sex = row.Cells[3].Value.ToString();
                athlete.TeamAccount = team.Account;
                athlete.CulturalAchivement = null;
                athlete.Athnum = null;

                if (service.SearchAthleteByIdCard(athlete.Idcard).Count == 0)
                {
                    service.AddAthlete(athlete);
                }
                else
                {
                    service.UpdateAthlete(athlete);
                }
            }
        }

        public void ScanGameInfo()
        {
            foreach (DataGridViewRow row in dataGridView6.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;

                GameInformation gameInformation = new GameInformation();
                gameInformation.Id = row.Cells[0].Value.ToString();
                gameInformation.ItemId = row.Cells[1].Value.ToString();
                gameInformation.AthleteNum = row.Cells[2].Value.ToString();  //注意这里 idcard 和 num的转换
                gameInformation.GroupNumber = -1;
                gameInformation.PlayOrder = -1;
                gameInformation.FinalGame = false;

                if (service.SearchGameInfoById(gameInformation.Id).Count == 0)
                {
                    service.AddGameInformation(gameInformation);
                }
                else
                {
                    service.UpdateGameInfo(gameInformation);
                }
            }
        }

        public void ScanCoach()
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;

                Coach coach = new Coach();
                coach.Idcard = row.Cells[0].Value.ToString();
                coach.Name = row.Cells[1].Value.ToString();
                coach.PhoneNum = row.Cells[2].Value.ToString();
                coach.Sex = row.Cells[3].Value.ToString();
                coach.TeamAccount = team.Account;

                if (service.SearchCoachByIdCard(coach.Idcard).Count == 0)
                {
                    service.AddCoach(coach);
                }
                else
                {
                    service.UpdateCoach(coach);
                }
            }
        }

        public void ScanReferee()
        {
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;

                Referee referee = new Referee();
                referee.Idcard = row.Cells[0].Value.ToString();
                referee.Name = row.Cells[1].Value.ToString();
                referee.Phonenum = row.Cells[2].Value.ToString();
                referee.TeamAccount = team.Account;

                if (service.SearchRefereeByIdCard(referee.Idcard).Count == 0)
                {
                    service.AddReferee(referee);
                }
                else
                {
                    service.UpdateReferee(referee);
                }
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
