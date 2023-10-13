using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace StudentManagamentSystem
{
    public partial class UserRegistrationForm : Form
    {
        UserRegistration registration = new UserRegistration();

        public UserRegistrationForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Need User's Data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string userName = userNameTextBox.Text;
                string password = passwordTextBox.Text;
                if (!registration.CheckUser(userName))
                {
                    if (registration.InsertUser(userName, password))
                    {
                        userNameTextBox.Clear();
                        passwordTextBox.Clear();
                        MessageBox.Show("User Is Registered", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User Do Not Add", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Username Is Already Exists", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new LoginForm());
            CloseForm(this);
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
                button1.PerformClick();
            }
        }
    }
}
