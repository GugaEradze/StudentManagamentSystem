using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagamentSystem
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        public static void OpenForm(Form formToOpen)
        {
            formToOpen.ShowDialog();
        }

        public static void CloseForm(Form formToClose)
        {
            formToClose.Close();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startPoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            guna2WinProgressIndicator1.Start();
            if (startPoint > 50)
            {
                guna2WinProgressIndicator1.Stop();
                timer1.Stop();
                this.Hide();
                OpenForm(new LoginForm());
                CloseForm(this);
            }
        }
    }
}
