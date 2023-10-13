namespace StudentManagamentSystem
{
    partial class EnteranceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnteranceForm));
            subMenu = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            logOutButton = new Button();
            scorePanel = new Panel();
            manageScoreButton = new Button();
            newScoreButton = new Button();
            scoreButton = new Button();
            coursePanel = new Panel();
            manageCourseButton = new Button();
            newCourseButton = new Button();
            courseButton = new Button();
            studentPanel = new Panel();
            statusButton = new Button();
            manageButton = new Button();
            registrationButton = new Button();
            studentButton = new Button();
            panelLogo = new Panel();
            label2 = new Label();
            label1 = new Label();
            nameLabel = new Label();
            panel1 = new Panel();
            label13 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            courseHourLabel = new Label();
            label7 = new Label();
            femaleCountLabel = new Label();
            maleCountLabel = new Label();
            femaleLabel = new Label();
            label12 = new Label();
            courseBox = new ComboBox();
            maleLabel = new Label();
            totalLabel = new Label();
            pictureBox2 = new PictureBox();
            subMenu.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            scorePanel.SuspendLayout();
            coursePanel.SuspendLayout();
            studentPanel.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // subMenu
            // 
            subMenu.BackColor = Color.Brown;
            subMenu.Controls.Add(panel4);
            subMenu.Controls.Add(courseButton);
            subMenu.Controls.Add(studentPanel);
            subMenu.Controls.Add(studentButton);
            subMenu.Controls.Add(panelLogo);
            subMenu.Dock = DockStyle.Left;
            subMenu.Location = new Point(0, 0);
            subMenu.Name = "subMenu";
            subMenu.Size = new Size(200, 620);
            subMenu.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Brown;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(coursePanel);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 405);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 215);
            panel4.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DodgerBlue;
            panel6.Controls.Add(logOutButton);
            panel6.Controls.Add(scorePanel);
            panel6.Controls.Add(scoreButton);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 113);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 102);
            panel6.TabIndex = 3;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.DodgerBlue;
            logOutButton.Dock = DockStyle.Top;
            logOutButton.FlatAppearance.BorderSize = 0;
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            logOutButton.ForeColor = SystemColors.ButtonHighlight;
            logOutButton.Location = new Point(0, 163);
            logOutButton.Name = "logOutButton";
            logOutButton.Padding = new Padding(10, 0, 0, 0);
            logOutButton.Size = new Size(200, 55);
            logOutButton.TabIndex = 3;
            logOutButton.Text = "Log Out";
            logOutButton.TextAlign = ContentAlignment.MiddleLeft;
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += exitButton_Click;
            // 
            // scorePanel
            // 
            scorePanel.Controls.Add(manageScoreButton);
            scorePanel.Controls.Add(newScoreButton);
            scorePanel.Dock = DockStyle.Top;
            scorePanel.Location = new Point(0, 55);
            scorePanel.Name = "scorePanel";
            scorePanel.Size = new Size(200, 108);
            scorePanel.TabIndex = 2;
            // 
            // manageScoreButton
            // 
            manageScoreButton.BackColor = Color.DodgerBlue;
            manageScoreButton.Dock = DockStyle.Top;
            manageScoreButton.FlatAppearance.BorderSize = 0;
            manageScoreButton.FlatStyle = FlatStyle.Flat;
            manageScoreButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            manageScoreButton.ForeColor = SystemColors.ButtonHighlight;
            manageScoreButton.Location = new Point(0, 55);
            manageScoreButton.Name = "manageScoreButton";
            manageScoreButton.Padding = new Padding(35, 0, 0, 0);
            manageScoreButton.Size = new Size(200, 55);
            manageScoreButton.TabIndex = 1;
            manageScoreButton.Text = "Manage Score";
            manageScoreButton.TextAlign = ContentAlignment.MiddleLeft;
            manageScoreButton.UseVisualStyleBackColor = false;
            manageScoreButton.Click += manageScoreButton_Click;
            // 
            // newScoreButton
            // 
            newScoreButton.BackColor = Color.DodgerBlue;
            newScoreButton.Dock = DockStyle.Top;
            newScoreButton.FlatAppearance.BorderSize = 0;
            newScoreButton.FlatStyle = FlatStyle.Flat;
            newScoreButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            newScoreButton.ForeColor = SystemColors.ButtonHighlight;
            newScoreButton.Location = new Point(0, 0);
            newScoreButton.Name = "newScoreButton";
            newScoreButton.Padding = new Padding(35, 0, 0, 0);
            newScoreButton.Size = new Size(200, 55);
            newScoreButton.TabIndex = 0;
            newScoreButton.Text = "New Score";
            newScoreButton.TextAlign = ContentAlignment.MiddleLeft;
            newScoreButton.UseVisualStyleBackColor = false;
            newScoreButton.Click += newScoreButton_Click;
            // 
            // scoreButton
            // 
            scoreButton.BackColor = Color.DodgerBlue;
            scoreButton.Dock = DockStyle.Top;
            scoreButton.FlatAppearance.BorderSize = 0;
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.ForeColor = SystemColors.ButtonHighlight;
            scoreButton.Location = new Point(0, 0);
            scoreButton.Name = "scoreButton";
            scoreButton.Padding = new Padding(10, 0, 0, 0);
            scoreButton.Size = new Size(200, 55);
            scoreButton.TabIndex = 1;
            scoreButton.Text = "Score";
            scoreButton.TextAlign = ContentAlignment.MiddleLeft;
            scoreButton.UseVisualStyleBackColor = false;
            scoreButton.Click += scoreButton_Click;
            // 
            // coursePanel
            // 
            coursePanel.BackColor = Color.DodgerBlue;
            coursePanel.Controls.Add(manageCourseButton);
            coursePanel.Controls.Add(newCourseButton);
            coursePanel.Dock = DockStyle.Top;
            coursePanel.Location = new Point(0, 0);
            coursePanel.Name = "coursePanel";
            coursePanel.Size = new Size(200, 113);
            coursePanel.TabIndex = 2;
            // 
            // manageCourseButton
            // 
            manageCourseButton.BackColor = Color.DodgerBlue;
            manageCourseButton.Dock = DockStyle.Top;
            manageCourseButton.FlatAppearance.BorderSize = 0;
            manageCourseButton.FlatStyle = FlatStyle.Flat;
            manageCourseButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            manageCourseButton.ForeColor = SystemColors.ButtonHighlight;
            manageCourseButton.Location = new Point(0, 55);
            manageCourseButton.Name = "manageCourseButton";
            manageCourseButton.Padding = new Padding(35, 0, 0, 0);
            manageCourseButton.Size = new Size(200, 55);
            manageCourseButton.TabIndex = 1;
            manageCourseButton.Text = "Manage Course";
            manageCourseButton.TextAlign = ContentAlignment.MiddleLeft;
            manageCourseButton.UseVisualStyleBackColor = false;
            manageCourseButton.Click += manageCourseButton_Click;
            // 
            // newCourseButton
            // 
            newCourseButton.BackColor = Color.DodgerBlue;
            newCourseButton.Dock = DockStyle.Top;
            newCourseButton.FlatAppearance.BorderSize = 0;
            newCourseButton.FlatStyle = FlatStyle.Flat;
            newCourseButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            newCourseButton.ForeColor = SystemColors.ButtonHighlight;
            newCourseButton.Location = new Point(0, 0);
            newCourseButton.Name = "newCourseButton";
            newCourseButton.Padding = new Padding(35, 0, 0, 0);
            newCourseButton.Size = new Size(200, 55);
            newCourseButton.TabIndex = 0;
            newCourseButton.Text = "New Course";
            newCourseButton.TextAlign = ContentAlignment.MiddleLeft;
            newCourseButton.UseVisualStyleBackColor = false;
            newCourseButton.Click += newCourseButton_Click;
            // 
            // courseButton
            // 
            courseButton.BackColor = Color.DodgerBlue;
            courseButton.Dock = DockStyle.Top;
            courseButton.FlatAppearance.BorderSize = 0;
            courseButton.FlatStyle = FlatStyle.Flat;
            courseButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            courseButton.ForeColor = SystemColors.ButtonHighlight;
            courseButton.Location = new Point(0, 350);
            courseButton.Name = "courseButton";
            courseButton.Padding = new Padding(10, 0, 0, 0);
            courseButton.Size = new Size(200, 55);
            courseButton.TabIndex = 3;
            courseButton.Text = "Course";
            courseButton.TextAlign = ContentAlignment.MiddleLeft;
            courseButton.UseVisualStyleBackColor = false;
            courseButton.Click += courseButton_Click;
            // 
            // studentPanel
            // 
            studentPanel.BackColor = Color.Brown;
            studentPanel.Controls.Add(statusButton);
            studentPanel.Controls.Add(manageButton);
            studentPanel.Controls.Add(registrationButton);
            studentPanel.Dock = DockStyle.Top;
            studentPanel.Location = new Point(0, 195);
            studentPanel.Name = "studentPanel";
            studentPanel.Size = new Size(200, 155);
            studentPanel.TabIndex = 2;
            // 
            // statusButton
            // 
            statusButton.BackColor = Color.DodgerBlue;
            statusButton.Dock = DockStyle.Top;
            statusButton.FlatAppearance.BorderSize = 0;
            statusButton.FlatStyle = FlatStyle.Flat;
            statusButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            statusButton.ForeColor = SystemColors.ButtonHighlight;
            statusButton.Location = new Point(0, 110);
            statusButton.Name = "statusButton";
            statusButton.Padding = new Padding(35, 0, 0, 0);
            statusButton.Size = new Size(200, 55);
            statusButton.TabIndex = 2;
            statusButton.Text = "Status";
            statusButton.TextAlign = ContentAlignment.MiddleLeft;
            statusButton.UseVisualStyleBackColor = false;
            statusButton.Click += statusButton_Click;
            // 
            // manageButton
            // 
            manageButton.BackColor = Color.DodgerBlue;
            manageButton.Dock = DockStyle.Top;
            manageButton.FlatAppearance.BorderSize = 0;
            manageButton.FlatStyle = FlatStyle.Flat;
            manageButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            manageButton.ForeColor = SystemColors.ButtonHighlight;
            manageButton.Location = new Point(0, 55);
            manageButton.Name = "manageButton";
            manageButton.Padding = new Padding(35, 0, 0, 0);
            manageButton.Size = new Size(200, 55);
            manageButton.TabIndex = 1;
            manageButton.Text = "Manage Student";
            manageButton.TextAlign = ContentAlignment.MiddleLeft;
            manageButton.UseVisualStyleBackColor = false;
            manageButton.Click += manageButton_Click;
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.DodgerBlue;
            registrationButton.Dock = DockStyle.Top;
            registrationButton.FlatAppearance.BorderSize = 0;
            registrationButton.FlatStyle = FlatStyle.Flat;
            registrationButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            registrationButton.ForeColor = SystemColors.ButtonHighlight;
            registrationButton.Location = new Point(0, 0);
            registrationButton.Name = "registrationButton";
            registrationButton.Padding = new Padding(35, 0, 0, 0);
            registrationButton.Size = new Size(200, 55);
            registrationButton.TabIndex = 0;
            registrationButton.Text = "Registration";
            registrationButton.TextAlign = ContentAlignment.MiddleLeft;
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // studentButton
            // 
            studentButton.BackColor = Color.DodgerBlue;
            studentButton.Dock = DockStyle.Top;
            studentButton.FlatAppearance.BorderSize = 0;
            studentButton.FlatStyle = FlatStyle.Flat;
            studentButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            studentButton.ForeColor = SystemColors.ButtonHighlight;
            studentButton.Location = new Point(0, 140);
            studentButton.Name = "studentButton";
            studentButton.Padding = new Padding(10, 0, 0, 0);
            studentButton.Size = new Size(200, 55);
            studentButton.TabIndex = 1;
            studentButton.Text = "Student";
            studentButton.TextAlign = ContentAlignment.MiddleLeft;
            studentButton.UseVisualStyleBackColor = false;
            studentButton.Click += studentButton_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.DodgerBlue;
            panelLogo.Controls.Add(label2);
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(nameLabel);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 140);
            panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 77);
            label2.Name = "label2";
            label2.Size = new Size(200, 25);
            label2.TabIndex = 2;
            label2.Text = "Mossmiery School";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 52);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 1;
            label1.Text = "Welcome From";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = SystemColors.ButtonHighlight;
            nameLabel.Location = new Point(0, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(200, 52);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Mossmiery ";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label13);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 70);
            panel1.TabIndex = 1;
            // 
            // label13
            // 
            label13.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DodgerBlue;
            label13.Location = new Point(6, 9);
            label13.Name = "label13";
            label13.Size = new Size(322, 58);
            label13.TabIndex = 0;
            label13.Text = "Mossmiery International School";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(200, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 70);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(735, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(138, 32);
            label6.Name = "label6";
            label6.Size = new Size(132, 35);
            label6.TabIndex = 3;
            label6.Text = "Admin";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(138, -1);
            label5.Name = "label5";
            label5.Size = new Size(132, 35);
            label5.TabIndex = 2;
            label5.Text = "Mossmiery";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 32);
            label4.Name = "label4";
            label4.Size = new Size(132, 35);
            label4.TabIndex = 1;
            label4.Text = "Role :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 35);
            label3.TabIndex = 0;
            label3.Text = "Welcome :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Controls.Add(courseHourLabel);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(femaleCountLabel);
            panel3.Controls.Add(maleCountLabel);
            panel3.Controls.Add(femaleLabel);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(courseBox);
            panel3.Controls.Add(maleLabel);
            panel3.Controls.Add(totalLabel);
            panel3.Location = new Point(200, 524);
            panel3.Name = "panel3";
            panel3.Size = new Size(863, 98);
            panel3.TabIndex = 3;
            // 
            // courseHourLabel
            // 
            courseHourLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            courseHourLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            courseHourLabel.ForeColor = SystemColors.ButtonHighlight;
            courseHourLabel.Location = new Point(572, 49);
            courseHourLabel.Name = "courseHourLabel";
            courseHourLabel.Size = new Size(82, 35);
            courseHourLabel.TabIndex = 15;
            courseHourLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(355, 49);
            label7.Name = "label7";
            label7.Size = new Size(211, 35);
            label7.TabIndex = 14;
            label7.Text = "Course Hours :";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // femaleCountLabel
            // 
            femaleCountLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            femaleCountLabel.ForeColor = SystemColors.ButtonHighlight;
            femaleCountLabel.Location = new Point(240, 46);
            femaleCountLabel.Name = "femaleCountLabel";
            femaleCountLabel.Size = new Size(45, 32);
            femaleCountLabel.TabIndex = 13;
            femaleCountLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // maleCountLabel
            // 
            maleCountLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            maleCountLabel.ForeColor = SystemColors.ButtonHighlight;
            maleCountLabel.Location = new Point(102, 46);
            maleCountLabel.Name = "maleCountLabel";
            maleCountLabel.Size = new Size(45, 32);
            maleCountLabel.TabIndex = 12;
            maleCountLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // femaleLabel
            // 
            femaleLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            femaleLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            femaleLabel.ForeColor = SystemColors.ButtonHighlight;
            femaleLabel.Location = new Point(144, 49);
            femaleLabel.Name = "femaleLabel";
            femaleLabel.Size = new Size(90, 35);
            femaleLabel.TabIndex = 11;
            femaleLabel.Text = "Female :";
            femaleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label12.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(355, 0);
            label12.Name = "label12";
            label12.Size = new Size(211, 35);
            label12.TabIndex = 10;
            label12.Text = "Select Class :";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // courseBox
            // 
            courseBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            courseBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            courseBox.ForeColor = Color.DodgerBlue;
            courseBox.FormattingEnabled = true;
            courseBox.Location = new Point(572, 4);
            courseBox.Name = "courseBox";
            courseBox.Size = new Size(288, 33);
            courseBox.TabIndex = 7;
            courseBox.Click += courseBox_Click;
            // 
            // maleLabel
            // 
            maleLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            maleLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            maleLabel.ForeColor = SystemColors.ButtonHighlight;
            maleLabel.Location = new Point(6, 49);
            maleLabel.Name = "maleLabel";
            maleLabel.Size = new Size(90, 35);
            maleLabel.TabIndex = 5;
            maleLabel.Text = "Male :";
            maleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            totalLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.ForeColor = SystemColors.ButtonHighlight;
            totalLabel.Location = new Point(17, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(217, 35);
            totalLabel.TabIndex = 4;
            totalLabel.Text = "Total Students :";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(200, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(863, 384);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // EnteranceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 620);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(subMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1081, 1000);
            Name = "EnteranceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnteranceForm";
            Load += EntranceFormLoad;
            subMenu.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            scorePanel.ResumeLayout(false);
            coursePanel.ResumeLayout(false);
            studentPanel.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel subMenu;
        private Panel panel4;
        private Panel panel6;
        private Button logOutButton;
        private Panel scorePanel;
        private Button manageScoreButton;
        private Button newScoreButton;
        private Button scoreButton;
        private Panel coursePanel;
        private Button manageCourseButton;
        private Button newCourseButton;
        private Button courseButton;
        private Panel studentPanel;
        private Button statusButton;
        private Button manageButton;
        private Button registrationButton;
        private Button studentButton;
        private Panel panelLogo;
        private Label label2;
        private Label label1;
        private Label nameLabel;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label12;
        private ComboBox courseBox;
        private Label maleLabel;
        private Label totalLabel;
        private PictureBox pictureBox2;
        private Label label13;
        private Label femaleLabel;
        private Label femaleCountLabel;
        private Label maleCountLabel;
        private Label courseHourLabel;
        private Label label7;
    }
}