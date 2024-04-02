using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;
                label3.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                login login = new login();
                timer1.Stop();
                this.Hide();
                login.Show();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

      




        
    }
}
