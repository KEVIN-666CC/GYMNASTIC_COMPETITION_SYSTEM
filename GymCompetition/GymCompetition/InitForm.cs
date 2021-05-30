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
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        GymCompetitionService service = new GymCompetitionService();

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setup_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void schedule_Click(object sender, EventArgs e)
        {
            service.ArrangeNumber(GymCompetitionService.HostTeamAccount);   //调用
            service.AlterAthnumInGameInfo();    //调用
            service.ArrangeGroups();    //调用

            SetRefereesForm setRefereesForm = new SetRefereesForm();
            setRefereesForm.Show();
        }

        private void preliminary_Click(object sender, EventArgs e)
        {
            GameStateForm gameStateForm = new GameStateForm();
            gameStateForm.Show();
        }

        private void final_Click(object sender, EventArgs e)
        {
            GameStateForm gameStateForm = new GameStateForm();
            gameStateForm.Show();
        }

        private void result_Click(object sender, EventArgs e)
        {
            GameStateForm gameStateForm = new GameStateForm();
            gameStateForm.Show();
        }
    }
}
