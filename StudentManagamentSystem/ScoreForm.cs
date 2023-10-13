using System.Data.SqlClient;
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
    public partial class ScoreForm : Form
    {
        Course course = new Course();
        Student student = new Student();
        Score score = new Score();

        public ScoreForm()
        {
            InitializeComponent();
        }

        private void _ShowScore()
        {
            scoreDataGridView.DataSource = score.GetStudentsList(new SqlCommand("SELECT StudentID, CourseName, Score, Description FROM StudentScores"));
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            courseComboBox.DataSource = course.GetCourseList();
            courseComboBox.DisplayMember = "CourseName";
            courseComboBox.ValueMember = "CourseName";

            studentDataGridView.DataSource = student.GetStudentsList(new SqlCommand("SELECT ID, FirstName, LastName FROM Students"));
            scoreDataGridView.DataSource = score.GetStudentsList(new SqlCommand("SELECT StudentID, CourseName, Score, Description FROM StudentScores"));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (studentIdTextbox.Text == "" || scoreTextbox.Text == "")
            {
                MessageBox.Show("Need Student's ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int studentId = Convert.ToInt32(studentIdTextbox.Text);
                string courseName = courseComboBox.Text;
                decimal studentScore = Convert.ToDecimal(scoreTextbox.Text);
                string description = descriptionTextbox.Text;
                if (!score.CheckScore(studentId, courseName))
                {
                    if (score.InsertScore(studentId, courseName, studentScore, description))
                    {
                        _ShowScore();
                        clearButton.PerformClick();
                        MessageBox.Show("Score Is Added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Score Do Not Add", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Exists", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            studentIdTextbox.Clear();
            scoreTextbox.Clear();
            courseComboBox.SelectedIndex = 0;
            descriptionTextbox.Clear();
        }

        private void studentDataGridView_Click(object sender, EventArgs e)
        {
            studentIdTextbox.Text = studentDataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new EnteranceForm());
            CloseForm(this);
        }

        public static void OpenForm(Form formToOpen)
        {
            formToOpen.ShowDialog();
        }

        public static void CloseForm(Form formToClose)
        {
            formToClose.Close();
        }
    }
}
