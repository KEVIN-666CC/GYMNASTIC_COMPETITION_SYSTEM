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

namespace AdminForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GymCompetitionService service = new GymCompetitionService();

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = service.QueryAllTeams(); //bindingSource需要换名字
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            AlterTable();
            bindingSource1.DataSource = service.QueryAllTeams();//bindingSource需要换名字
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null)
            {
                GymCompetitionService.MaxAthletesPerGroup = Convert.ToInt16(textBox1.Text);
                GymCompetitionService.MaxAthletesPerGame = Convert.ToInt16(textBox2.Text);
                GymCompetitionService.GroupGradeCount = Convert.ToInt16(textBox3.Text);
                GymCompetitionService.HostTeamAccount = textBox4.Text;
            }
        }

        private void AlterTable()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;

                Team team = new Team();
                team.Account = row.Cells[0].Value.ToString();
                team.Password = row.Cells[1].Value.ToString();
                team.Name = row.Cells[2].Value.ToString();

                int count = service.SearchTeamByAccount(team.Account).Count();
                if (count == 0)
                {
                    service.AddTeam(team);
                }
                else
                {
                    service.UpdateTeam(team);
                }
            }
        }
    }
}

