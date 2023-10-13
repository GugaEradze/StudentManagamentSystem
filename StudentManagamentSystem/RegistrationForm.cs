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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        EnteranceForm enteranceForm = new EnteranceForm();
        DbContext context = new DbContext();
        Student student = new Student();

        bool Verify()
        {
            if ((firstnameTextbox.Text == "") || (lastNameTextbox.Text == "") ||
               (phoneTextbox.Text == "") || (adressTextbox.Text == "")) return false;
            else return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string firstName = firstnameTextbox.Text;
            string lastName = lastNameTextbox.Text;
            string phone = phoneTextbox.Text;
            string adress = adressTextbox.Text;
            DateTime birthDate = dateTimePicker.Value;
            string gender = radioMaleButton.Checked ? "Male" : "Female";
            int bornYear = dateTimePicker.Value.Year;
            int thisYear = DateTime.Now.Year;
            if ((thisYear - bornYear < 10) || (thisYear - bornYear > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 And 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verify())
            {
                try
                {
                    if (student.InsertStudent(firstName, lastName, birthDate, gender, phone, adress))
                    {
                        ShowTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    clearButton.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Students", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void OpenForm(Form formToOpen)
        {
            formToOpen.ShowDialog();
        }

        public static void CloseForm(Form formToClose)
        {
            formToClose.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        public void ShowTable()
        {
            listDataGridView.DataSource = student.GetStudentsList(new SqlCommand("SELECT * FROM Students"));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstnameTextbox.Clear();
            lastNameTextbox.Clear();
            phoneTextbox.Clear();
            adressTextbox.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new EnteranceForm());
            CloseForm(this);
        }
    }
}
