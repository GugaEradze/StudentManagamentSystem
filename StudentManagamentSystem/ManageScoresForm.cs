using System.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace StudentManagamentSystem
{
    public partial class ManageScoresForm : Form
    {
        Course course = new Course();
        Score score = new Score();

        public ManageScoresForm()
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

        private void ManageScoresForm_Load(object sender, EventArgs e)
        {
            courseComboBox.DataSource = course.GetCourseList();
            courseComboBox.DisplayMember = "CourseName";
            courseComboBox.ValueMember = "CourseName";
            ShowScore();
        }

        public void ShowScore()
        {
            listDataGridView.DataSource = score.GetStudentsList(new SqlCommand("SELECT StudentScores.StudentID, Students.FirstName, Students.LastName, StudentScores.CourseName, StudentScores.Score, StudentScores.Description FROM Students INNER JOIN StudentScores ON StudentScores.StudentID = Students.ID"));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (studentIdTextbox.Text == "" || scoreTextbox.Text == "")
            {
                MessageBox.Show("Need Course Data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int studentId = Convert.ToInt32(studentIdTextbox.Text);
                string courseName = courseComboBox.Text;
                decimal studentScore = Convert.ToDecimal(scoreTextbox.Text);
                string description = descriptionTextbox.Text;
                {
                    if (score.UpdateScore(studentId, courseName, studentScore, description))
                    {
                        ShowScore();
                        studentIdTextbox.Clear();
                        scoreTextbox.Clear();
                        descriptionTextbox.Clear();
                        MessageBox.Show("Score Updated", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Score Do Not Update", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (studentIdTextbox.Text.Equals(""))
            {
                MessageBox.Show("Need Student's ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(studentIdTextbox.Text);
                string courseName = courseComboBox.Text;
                var result = MessageBox.Show("Are You Sure You Want To Delete Score?", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (score.DeleteScore(id, courseName))
                    {
                        ShowScore();
                        studentIdTextbox.Clear();
                        scoreTextbox.Clear();
                        descriptionTextbox.Clear();

                        MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Score Can't Be Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listDataGridView_Click(object sender, EventArgs e)
        {
            studentIdTextbox.Text = listDataGridView.CurrentRow.Cells[0].Value.ToString();
            courseComboBox.DisplayMember = listDataGridView.CurrentRow.Cells[3].Value.ToString();
            scoreTextbox.Text = listDataGridView.CurrentRow.Cells[4].Value.ToString();
            descriptionTextbox.Text = listDataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new EnteranceForm());
            CloseForm(this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listDataGridView.DataSource = score.SearchScoresList(searchTextBox.Text);
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
