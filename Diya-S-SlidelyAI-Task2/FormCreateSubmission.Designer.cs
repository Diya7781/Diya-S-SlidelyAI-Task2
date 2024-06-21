namespace Diya_S_SlidelyAI_Task2
{
    partial class FormCreateSubmission
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtGithub;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGithub;
        private System.Windows.Forms.Label lblStopwatch;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGithub = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGithub = new System.Windows.Forms.Label();
            this.lblStopwatch = new System.Windows.Forms.Label();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(200, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(200, 150);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 2;
            // 
            // txtGithub
            // 
            this.txtGithub.Location = new System.Drawing.Point(200, 200);
            this.txtGithub.Name = "txtGithub";
            this.txtGithub.Size = new System.Drawing.Size(200, 22);
            this.txtGithub.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(50, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(50, 153);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(77, 16);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone Num";
            // 
            // lblGithub
            // 
            this.lblGithub.AutoSize = true;
            this.lblGithub.Location = new System.Drawing.Point(50, 203);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(132, 16);
            this.lblGithub.TabIndex = 7;
            this.lblGithub.Text = "GitHub Link For Task";
            // 
            // lblStopwatch
            // 
            this.lblStopwatch.AutoSize = true;
            this.lblStopwatch.Location = new System.Drawing.Point(367, 257);
            this.lblStopwatch.Name = "lblStopwatch";
            this.lblStopwatch.Size = new System.Drawing.Size(55, 16);
            this.lblStopwatch.TabIndex = 8;
            this.lblStopwatch.Text = "00:00:00";
            // 
            // btnStartPause
            // 
            this.btnStartPause.Location = new System.Drawing.Point(119, 250);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(200, 30);
            this.btnStartPause.TabIndex = 9;
            this.btnStartPause.Text = "TOGGLE STOPWATCH (CTRL + T)";
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(200, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 30);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "SUBMIT (CTRL + S)";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormCreateSubmission
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.lblStopwatch);
            this.Controls.Add(this.lblGithub);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtGithub);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Name = "FormCreateSubmission";
            this.Text = "Create Submission";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCreateSubmission_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
