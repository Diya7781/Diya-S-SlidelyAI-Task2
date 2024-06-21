using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diya_S_SlidelyAI_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewSubmissions_Click(object sender, EventArgs e)
        {
            var viewForm = new FormViewSubmissions();
            viewForm.Show();
        }

        private void btnCreateSubmission_Click(object sender, EventArgs e)
        {
            var createForm = new FormCreateSubmission();
            createForm.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                btnViewSubmissions.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                btnCreateSubmission.PerformClick();
            }
        }
    }
}
