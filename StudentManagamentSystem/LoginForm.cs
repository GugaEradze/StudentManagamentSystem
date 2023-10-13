using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagamentSystem
{
    public partial class LoginForm : Form
    {
        Student student = new Student();

        public LoginForm()
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Need Login Data", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string userName = userNameTextBox.Text;
                string password = passwordTextBox.Text;
                DataTable dataTable = student.GetStudentsList(new SqlCommand("SELECT * FROM Users WHERE Username = '" + userNameTextBox.Text + "' AND Password = '" + passwordTextBox.Text + "'"));
                if (dataTable.Rows.Count > 0)
                {
                    EnteranceForm enteranceForm = new EnteranceForm();
                    this.Hide();
                    OpenForm(new EnteranceForm());
                    CloseForm(this);
                }
                else
                {
                    MessageBox.Show("Your Username Or Password Doesn't Exist", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new UserRegistrationForm());
            CloseForm(this);
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginButton.Focus();
                loginButton.PerformClick();
            }
        }
    }
}
