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
    public partial class ManageStudentsForm : Form
    {
        Student student = new Student();

        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        public void ShowTable()
        {
            listDataGridView.DataSource = student.GetStudentsList(new SqlCommand("SELECT * FROM Students"));
        }

        bool Verify()
        {
            if ((firstnameTextbox.Text == "") || (lastNameTextbox.Text == "") ||
               (phoneTextbox.Text == "") || (adressTextbox.Text == "")) return false;
            else return true;
        }

        private void listDataGridView_Click(object sender, EventArgs e)
        {
            idTextbox.Text = listDataGridView.CurrentRow.Cells[0].Value.ToString();
            firstnameTextbox.Text = listDataGridView.CurrentRow.Cells[1].Value.ToString();
            lastNameTextbox.Text = listDataGridView.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker.Value = (DateTime)listDataGridView.CurrentRow.Cells[3].Value;
            if (listDataGridView.CurrentRow.Cells[4].Value.ToString() == "Male")
                radioMaleButton.Checked = true;
            phoneTextbox.Text = listDataGridView.CurrentRow.Cells[5].Value.ToString();
            adressTextbox.Text = listDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listDataGridView.DataSource = student.SearchStudentsList(searchTextBox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (idTextbox.Text.Equals(""))
            {
                MessageBox.Show("Need Student's ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(idTextbox.Text);
                var result = MessageBox.Show("Are You Sure You Want To Delete Student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (student.DeleteStudent(id))
                    {
                        ShowTable();
                        firstnameTextbox.Clear();
                        lastNameTextbox.Clear();
                        adressTextbox.Clear();
                        phoneTextbox.Clear();
                        idTextbox.Clear();

                        MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Score Can't Be Deleted", "Delete SCore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextbox.Text);
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
                    if (student.UpdateStudent(id, firstName, lastName, birthDate, gender, phone, adress))
                    {
                        ShowTable();
                        MessageBox.Show("Student Data Updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Students", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new EnteranceForm());
            CloseForm(this);
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchButton.Focus();
                searchButton.PerformClick();
            }
        }
    }
}
