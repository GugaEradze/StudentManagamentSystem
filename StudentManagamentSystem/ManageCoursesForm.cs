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
    public partial class ManageCoursesForm : Form
    {
        Course course = new Course();

        public ManageCoursesForm()
        {
            InitializeComponent();
        }

        private void ManageCourses_Load(object sender, EventArgs e)
        {
            _ShowData();
        }

        public static void OpenForm(Form formToOpen)
        {
            formToOpen.ShowDialog();
        }

        public static void CloseForm(Form formToClose)
        {
            formToClose.Close();
        }

        private void _ShowData()
        {
            courseDataGridView.DataSource = course.GetCourseList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (idTextbox.Text.Equals(""))
            {
                MessageBox.Show("Need Student's ID", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(idTextbox.Text);
                    var result = MessageBox.Show("Are You Sure You Want To Delete Course?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (course.DeleteCourse(id))
                        {
                            _ShowData();
                            courseTextbox.Clear();
                            hourTextbox.Clear();
                            descriptionTextbox.Clear();
                            idTextbox.Clear();

                            MessageBox.Show("Course Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (courseTextbox.Text == "" || hourTextbox.Text == "" || idTextbox.Equals(""))
            {
                MessageBox.Show("Need Course Data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(idTextbox.Text);
                string courseName = courseTextbox.Text;
                int courseHour = Convert.ToInt32(hourTextbox.Text);
                string courseDescription = descriptionTextbox.Text;

                if (course.UpdateCourse(id, courseName, courseHour, courseDescription))
                {
                    _ShowData();
                    courseTextbox.Clear();
                    hourTextbox.Clear();
                    idTextbox.Clear();
                    descriptionTextbox.Clear();
                    MessageBox.Show("Course Updated Successfully", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course Can't Be Updated", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void courseDataGridView_Click(object sender, EventArgs e)
        {
            idTextbox.Text = courseDataGridView.CurrentRow.Cells[0].Value.ToString();
            courseTextbox.Text = courseDataGridView.CurrentRow.Cells[1].Value.ToString();
            hourTextbox.Text = courseDataGridView.CurrentRow.Cells[2].Value.ToString();
            descriptionTextbox.Text = courseDataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new EnteranceForm());
            CloseForm(this);
        }
    }
}
