namespace Diya_S_SlidelyAI_Task2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnViewSubmissions = new System.Windows.Forms.Button();
            this.btnCreateSubmission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewSubmissions
            // 
            this.btnViewSubmissions.Location = new System.Drawing.Point(50, 50);
            this.btnViewSubmissions.Name = "btnViewSubmissions";
            this.btnViewSubmissions.Size = new System.Drawing.Size(200, 50);
            this.btnViewSubmissions.TabIndex = 0;
            this.btnViewSubmissions.Text = "View Submissions (Ctrl + V)";
            this.btnViewSubmissions.UseVisualStyleBackColor = true;
            this.btnViewSubmissions.Click += new System.EventHandler(this.btnViewSubmissions_Click);
            // 
            // btnCreateSubmission
            // 
            this.btnCreateSubmission.Location = new System.Drawing.Point(50, 120);
            this.btnCreateSubmission.Name = "btnCreateSubmission";
            this.btnCreateSubmission.Size = new System.Drawing.Size(200, 50);
            this.btnCreateSubmission.TabIndex = 1;
            this.btnCreateSubmission.Text = "Create New Submission (Ctrl + N)";
            this.btnCreateSubmission.UseVisualStyleBackColor = true;
            this.btnCreateSubmission.Click += new System.EventHandler(this.btnCreateSubmission_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnCreateSubmission);
            this.Controls.Add(this.btnViewSubmissions);
            this.Name = "Form1";
            this.Text = "Slidely Form App";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnViewSubmissions;
        private System.Windows.Forms.Button btnCreateSubmission;
    }
}
