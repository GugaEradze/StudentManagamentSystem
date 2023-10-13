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
    public partial class CourseForm : Form
    {
        Course course = new Course();

        public CourseForm()
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (courseTextbox.Text == "" || hourTextbox.Text == "")
            {
                MessageBox.Show("Need Course Data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string courseName = courseTextbox.Text;
                int courseHour = Convert.ToInt32(hourTextbox.Text);
                string courseDescription = descriptionTextbox.Text;

                if (course.InsertCourse(courseName, courseHour, courseDescription))
                {
                    _ShowData();
                    clearButton.PerformClick();
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course Do Not Insert", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            courseTextbox.Clear();
            hourTextbox.Clear();
            descriptionTextbox.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new EnteranceForm());
            CloseForm(this);
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            _ShowData();
        }

        private void _ShowData()
        {
            courseDataGridView.DataSource = course.GetCourseList();
        }
    }
}
