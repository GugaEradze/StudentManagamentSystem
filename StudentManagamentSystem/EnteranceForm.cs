using Microsoft.VisualBasic.Devices;

namespace StudentManagamentSystem
{
    public partial class EnteranceForm : Form
    {
        Student student = new Student();
        Course course = new Course();

        public EnteranceForm()
        {
            InitializeComponent();
            _CustomizeDesing();
        }

        private void EntranceFormLoad(object sender, EventArgs e)
        {
            totalLabel.Text = "Total Students : " + student.TotalCount();
            maleCountLabel.Text = student.MaleCount();
            femaleCountLabel.Text = student.FemaleCount();
            courseBox.DataSource = course.GetCourseList();
            courseBox.DisplayMember = "CourseName";
            courseBox.ValueMember = "CourseName";
            courseHourLabel.Text = student.GetCourseHour(courseBox.Text);

        }

        public static void OpenForm(Form formToOpen)
        {
            formToOpen.ShowDialog();
        }

        public static void CloseForm(Form formToClose)
        {
            formToClose.Close();
        }

        private void _CustomizeDesing()
        {
            studentPanel.Visible = false;
            scorePanel.Visible = false;
            coursePanel.Visible = false;
        }

        private void _HideSubMenu()
        {
            if (studentPanel.Visible == true) studentPanel.Visible = false;
            if (scorePanel.Visible == true) scorePanel.Visible = false;
            if (coursePanel.Visible == true) coursePanel.Visible = false;
        }

        private void _ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                _HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            _ShowSubMenu(studentPanel);
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new RegistrationForm());
            CloseForm(this);
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new ManageStudentsForm());
            CloseForm(this);
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            //..
            _HideSubMenu();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //..
            _HideSubMenu();
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            _ShowSubMenu(coursePanel);
        }

        private void newCourseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new CourseForm());
            CloseForm(this);
        }

        private void manageCourseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new ManageCoursesForm());
            CloseForm(this);
        }

        private void coursePrintButton_Click(object sender, EventArgs e)
        {
            //..
            _HideSubMenu();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            _ShowSubMenu(scorePanel);
        }

        private void newScoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new ScoreForm());
            CloseForm(this);
        }

        private void manageScoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new ManageScoresForm());
            CloseForm(this);
        }

        private void scorePrintButton_Click(object sender, EventArgs e)
        {
            //..
            _HideSubMenu();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are You Sure You Want To Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                OpenForm(new LoginForm());
                CloseForm(this);
            }
        }

        private void courseBox_Click(object sender, EventArgs e)
        {
            courseHourLabel.Text = student.GetCourseHour(courseBox.Text);
        }
    }
}