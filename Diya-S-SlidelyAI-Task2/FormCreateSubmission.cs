using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Diya_S_SlidelyAI_Task2
{
    public partial class FormCreateSubmission : Form
    {
        private Stopwatch stopwatch = new Stopwatch();

        public FormCreateSubmission()
        {
            InitializeComponent();
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                btnStartPause.Text = "TOGGLE STOPWATCH (CTRL + T)";
            }
            else
            {
                stopwatch.Start();
                btnStartPause.Text = "Pause";
            }
            lblStopwatch.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var submission = new Submission
            {
                name = txtName.Text,
                email = txtEmail.Text,
                phone = txtPhone.Text,
                github_link = txtGithub.Text,
                stopwatch_time = stopwatch.Elapsed.ToString(@"hh\:mm\:ss")
            };

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var data = JsonConvert.SerializeObject(submission);
                client.UploadString("http://localhost:3000/submit", "POST", data);
            }
        }

        private void FormCreateSubmission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSubmit.PerformClick();
            }
        }
    }

    public class Submissions
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string github_link { get; set; }
        public string stopwatch_time { get; set; }
    }
}
