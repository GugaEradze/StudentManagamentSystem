namespace StudentManagamentSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label4 = new Label();
            loginButton = new Button();
            registrationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DodgerBlue;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -6);
            label1.Name = "label1";
            label1.Size = new Size(933, 77);
            label1.TabIndex = 1;
            label1.Text = "Mossmiery International School\r\n";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(374, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(348, 203);
            label2.Name = "label2";
            label2.Size = new Size(229, 34);
            label2.TabIndex = 1;
            label2.Text = "Please Login First";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Sitka Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(297, 237);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 2;
            label3.Text = "User name :";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userNameTextBox.ForeColor = Color.DodgerBlue;
            userNameTextBox.Location = new Point(297, 272);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(329, 27);
            userNameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.DodgerBlue;
            passwordTextBox.Location = new Point(297, 337);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(329, 27);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.KeyPress += passwordTextBox_KeyPress;
            // 
            // label4
            // 
            label4.Font = new Font("Sitka Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(297, 302);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 4;
            label4.Text = "Password :";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DodgerBlue;
            loginButton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(297, 386);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(160, 40);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.DodgerBlue;
            registrationButton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            registrationButton.ForeColor = Color.White;
            registrationButton.Location = new Point(466, 386);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(160, 40);
            registrationButton.TabIndex = 7;
            registrationButton.Text = "Registration";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(932, 603);
            Controls.Add(label1);
            Controls.Add(registrationButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label4);
            Controls.Add(userNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label label4;
        private Button loginButton;
        private Button registrationButton;
    }
}