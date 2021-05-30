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
    public partial class OrdinaryRefereeForm : Form
    {
        public OrdinaryRefereeForm()
        {
            InitializeComponent();
        }

        GymCompetitionService service = new GymCompetitionService();
        public RefereeScore refereeScore { get; set; }

        public OrdinaryRefereeForm(RefereeScore refereeScore) : this()
        {
            this.refereeScore = refereeScore;
            name.Text = service.SearchAthleteByAthleteNum(
                service.SearchGameInfoById(refereeScore.GameInfoId)[0].AthleteNum)[0].Name;
            identity.Text = service.SearchGameInfoById(refereeScore.GameInfoId)[0].AthleteNum;
            result.Text = refereeScore.Score.ToString();
        }

        private void OrdinaryRefereeForm_Load(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                double score = Convert.ToDouble(result.Text.ToString());
                if (score > 0)
                {
                    refereeScore.Score = score;
                    service.UpdateRefereeScore(refereeScore);   //上传数据，通过GymCompetitionService
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("分数为百分制！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }
        }
    }
}
