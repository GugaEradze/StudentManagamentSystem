namespace StudentManagamentSystem
{
    partial class UserRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistrationForm));
            label1 = new Label();
            button1 = new Button();
            passwordTextBox = new TextBox();
            label4 = new Label();
            userNameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            loginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DodgerBlue;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, -3);
            label1.Name = "label1";
            label1.Size = new Size(929, 77);
            label1.TabIndex = 9;
            label1.Text = "Mossmiery International School\r\n";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(296, 383);
            button1.Name = "button1";
            button1.Size = new Size(329, 40);
            button1.TabIndex = 16;
            button1.Text = "Registrate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.DodgerBlue;
            passwordTextBox.Location = new Point(296, 334);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(329, 27);
            passwordTextBox.TabIndex = 14;
            passwordTextBox.KeyPress += passwordTextBox_KeyPress;
            // 
            // label4
            // 
            label4.Font = new Font("Sitka Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(296, 299);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 13;
            label4.Text = "Password :";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userNameTextBox.ForeColor = Color.DodgerBlue;
            userNameTextBox.Location = new Point(296, 269);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(329, 27);
            userNameTextBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.Font = new Font("Sitka Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(296, 234);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 11;
            label3.Text = "User name :";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(347, 200);
            label2.Name = "label2";
            label2.Size = new Size(229, 34);
            label2.TabIndex = 10;
            label2.Text = "Registration";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(373, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DodgerBlue;
            loginButton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(347, 429);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(229, 40);
            loginButton.TabIndex = 17;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // UserRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(passwordTextBox);
            Controls.Add(label4);
            Controls.Add(userNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox passwordTextBox;
        private Label label4;
        private TextBox userNameTextBox;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button loginButton;
    }
}