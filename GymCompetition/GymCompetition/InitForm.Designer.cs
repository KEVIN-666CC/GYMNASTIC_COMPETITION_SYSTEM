
namespace GymCompetition
{
    partial class InitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.setup = new System.Windows.Forms.Button();
            this.schedule = new System.Windows.Forms.Button();
            this.preliminary = new System.Windows.Forms.Button();
            this.final = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setup
            // 
            this.setup.Location = new System.Drawing.Point(13, 13);
            this.setup.Name = "setup";
            this.setup.Size = new System.Drawing.Size(150, 50);
            this.setup.TabIndex = 0;
            this.setup.Text = "系统设置/报名";
            this.setup.UseVisualStyleBackColor = true;
            this.setup.Click += new System.EventHandler(this.setup_Click);
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(13, 70);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(150, 50);
            this.schedule.TabIndex = 1;
            this.schedule.Text = "编排";
            this.schedule.UseVisualStyleBackColor = true;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // preliminary
            // 
            this.preliminary.Location = new System.Drawing.Point(13, 127);
            this.preliminary.Name = "preliminary";
            this.preliminary.Size = new System.Drawing.Size(150, 50);
            this.preliminary.TabIndex = 2;
            this.preliminary.Text = "初赛/裁判评分";
            this.preliminary.UseVisualStyleBackColor = true;
            this.preliminary.Click += new System.EventHandler(this.preliminary_Click);
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(13, 184);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(150, 50);
            this.final.TabIndex = 3;
            this.final.Text = "决赛/裁判评分";
            this.final.UseVisualStyleBackColor = true;
            this.final.Click += new System.EventHandler(this.final_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(13, 241);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(150, 50);
            this.result.TabIndex = 4;
            this.result.Text = "比赛结果";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(13, 298);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(150, 50);
            this.quit.TabIndex = 5;
            this.quit.Text = "退出";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 360);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.result);
            this.Controls.Add(this.final);
            this.Controls.Add(this.preliminary);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.setup);
            this.Name = "InitForm";
            this.Text = "InitForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setup;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Button preliminary;
        private System.Windows.Forms.Button final;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button quit;
    }
}