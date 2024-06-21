using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Diya_S_SlidelyAI_Task2
{
    public partial class FormViewSubmissions : Form
    {
        private List<Submission> submissions;

        public FormViewSubmissions()
        {
            InitializeComponent();
            LoadSubmissions();
        }

        private void LoadSubmissions()
        {
            try
            {
                using (var client = new WebClient())
                {
                    var response = client.DownloadString("http://localhost:3000/read");
                    submissions = JsonConvert.DeserializeObject<List<Submission>>(response);
                    dataGridViewSubmissions.DataSource = submissions;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load submissions: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSubmissions();
        }
    }

    public class Submission
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string github_link { get; set; }
        public string stopwatch_time { get; set; }
    }
}
