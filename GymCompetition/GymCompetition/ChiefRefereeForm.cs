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
    public partial class ChiefRefereeForm : Form
    {
        public ChiefRefereeForm()
        {
            InitializeComponent();
        }

        GymCompetitionService service = new GymCompetitionService();
        public RefereeScore refereeScore { get; set; }  //这里需要注意，连接部分，数据库
        bool flag = true;

        public ChiefRefereeForm(RefereeScore refereeScore) : this()
        {
            this.refereeScore = refereeScore;   //这里需要注意，连接部分，数据库
            refereeScoreBindingSource.DataSource = service.SearchRefereeScoreByGameInfoId(refereeScore.GameInfoId); //这里需要注意，连接部分，数据库
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiefRefereeForm_Load(object sender, EventArgs e)
        {

        }

        private void Comfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ScanRefereeScore();
                if (flag)
                {
                    MessageBox.Show("保存成功！");
                    GroupTotalScoreForm groupTotalScoreForm = new GroupTotalScoreForm(refereeScore);    //这里需要注意，连接部分，数据库
                    groupTotalScoreForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("需要等待其他裁判重新评分！");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        public void ScanRefereeScore()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;

                if (!(Convert.ToBoolean(row.Cells[3].Value)) && (Convert.ToBoolean(row.Cells[7].Value)))
                {
                    flag = false;
                    OrdinaryRefereeForm ordinaryRefereeForm = new OrdinaryRefereeForm(service.SearchRefereeScoreById(row.Cells[0].Value.ToString())[0]);    //这里需要注意，连接部分，数据库
                    ordinaryRefereeForm.Show();
                    MessageBox.Show("已返回给相应裁判进行重新评分！");
                }

                if ((Convert.ToBoolean(row.Cells[3].Value)) && (row.Cells[5].Value != null) && (row.Cells[6].Value != null))
                {
                    try
                    {
                        RefereeScore refereeScore = service.SearchRefereeScoreById(row.Cells[0].Value.ToString())[0];
                        refereeScore.P = Convert.ToDouble(row.Cells[5].Value);
                        refereeScore.D = Convert.ToDouble(row.Cells[6].Value);
                        service.UpdateRefereeScore(refereeScore);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error: " + ex.Message);
                    }
                }
            }
        }

    }
}
