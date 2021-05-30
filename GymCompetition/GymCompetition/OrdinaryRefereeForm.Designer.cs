
namespace GymCompetition
{
    partial class OrdinaryRefereeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.identity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前云动员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "名字：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "成绩：";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(90, 119);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(188, 27);
            this.result.TabIndex = 4;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(147, 152);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 30);
            this.Save.TabIndex = 5;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(13, 152);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(130, 30);
            this.Quit.TabIndex = 6;
            this.Quit.Text = "退出";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(147, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 28);
            this.name.TabIndex = 7;
            // 
            // identity
            // 
            this.identity.AutoSize = true;
            this.identity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.identity.Location = new System.Drawing.Point(147, 82);
            this.identity.Name = "identity";
            this.identity.Size = new System.Drawing.Size(0, 28);
            this.identity.TabIndex = 8;
            // 
            // OrdinaryRefereeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 196);
            this.Controls.Add(this.identity);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrdinaryRefereeForm";
            this.Text = "RefereeForm";
            this.Load += new System.EventHandler(this.OrdinaryRefereeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label identity;
    }
}