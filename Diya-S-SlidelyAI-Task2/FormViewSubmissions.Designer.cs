namespace Diya_S_SlidelyAI_Task2
{
    partial class FormViewSubmissions
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewSubmissions;
        private System.Windows.Forms.Button btnRefresh;

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
            this.dataGridViewSubmissions = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubmissions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSubmissions
            // 
            this.dataGridViewSubmissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubmissions.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSubmissions.Name = "dataGridViewSubmissions";
            this.dataGridViewSubmissions.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewSubmissions.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 420);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormViewSubmissions
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewSubmissions);
            this.Name = "FormViewSubmissions";
            this.Text = "View Submissions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubmissions)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
