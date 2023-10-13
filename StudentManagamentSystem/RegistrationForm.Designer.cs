namespace StudentManagamentSystem
{
    partial class RegistrationForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            label1 = new Label();
            listDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            label2 = new Label();
            firstnameTextbox = new TextBox();
            label3 = new Label();
            dateTimePicker = new DateTimePicker();
            lastNameTextbox = new TextBox();
            radioMaleButton = new RadioButton();
            radioFemaleButton = new RadioButton();
            label4 = new Label();
            adressTextbox = new TextBox();
            phoneTextbox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            addButton = new Button();
            clearButton = new Button();
            label7 = new Label();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)listDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(12, 475);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 1;
            label1.Text = "First Name :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listDataGridView
            // 
            listDataGridView.AllowUserToAddRows = false;
            listDataGridView.AllowUserToDeleteRows = false;
            listDataGridView.AllowUserToResizeColumns = false;
            listDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            listDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            listDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listDataGridView.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            listDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            listDataGridView.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            listDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            listDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            listDataGridView.Location = new Point(0, 66);
            listDataGridView.Name = "listDataGridView";
            listDataGridView.ReadOnly = true;
            listDataGridView.RowHeadersVisible = false;
            listDataGridView.RowHeadersWidth = 51;
            listDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            listDataGridView.RowTemplate.Height = 29;
            listDataGridView.Size = new Size(1208, 392);
            listDataGridView.TabIndex = 3;
            listDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            listDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            listDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            listDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            listDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            listDataGridView.ThemeStyle.BackColor = Color.LightGray;
            listDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            listDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            listDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            listDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            listDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            listDataGridView.ThemeStyle.HeaderStyle.Height = 24;
            listDataGridView.ThemeStyle.ReadOnly = true;
            listDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            listDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            listDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            listDataGridView.ThemeStyle.RowsStyle.Height = 29;
            listDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            listDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(638, 481);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 4;
            label2.Text = "Last Name :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // firstnameTextbox
            // 
            firstnameTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            firstnameTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstnameTextbox.ForeColor = Color.DodgerBlue;
            firstnameTextbox.Location = new Point(190, 479);
            firstnameTextbox.Name = "firstnameTextbox";
            firstnameTextbox.Size = new Size(379, 30);
            firstnameTextbox.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(12, 530);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 7;
            label3.Text = "Date Of Birth :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePicker.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker.CalendarForeColor = Color.DodgerBlue;
            dateTimePicker.CalendarTitleBackColor = Color.DodgerBlue;
            dateTimePicker.CalendarTitleForeColor = Color.DodgerBlue;
            dateTimePicker.CalendarTrailingForeColor = Color.DodgerBlue;
            dateTimePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker.Location = new Point(190, 528);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(379, 30);
            dateTimePicker.TabIndex = 8;
            // 
            // lastNameTextbox
            // 
            lastNameTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lastNameTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameTextbox.ForeColor = Color.DodgerBlue;
            lastNameTextbox.Location = new Point(816, 478);
            lastNameTextbox.Name = "lastNameTextbox";
            lastNameTextbox.Size = new Size(379, 30);
            lastNameTextbox.TabIndex = 9;
            // 
            // radioMaleButton
            // 
            radioMaleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioMaleButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioMaleButton.ForeColor = Color.DodgerBlue;
            radioMaleButton.Location = new Point(816, 533);
            radioMaleButton.Name = "radioMaleButton";
            radioMaleButton.Size = new Size(186, 30);
            radioMaleButton.TabIndex = 10;
            radioMaleButton.TabStop = true;
            radioMaleButton.Text = "Male";
            radioMaleButton.UseVisualStyleBackColor = true;
            // 
            // radioFemaleButton
            // 
            radioFemaleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioFemaleButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioFemaleButton.ForeColor = Color.DodgerBlue;
            radioFemaleButton.Location = new Point(1009, 533);
            radioFemaleButton.Name = "radioFemaleButton";
            radioFemaleButton.Size = new Size(186, 29);
            radioFemaleButton.TabIndex = 11;
            radioFemaleButton.TabStop = true;
            radioFemaleButton.Text = "Female";
            radioFemaleButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(12, 585);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 13;
            label4.Text = "Adress :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // adressTextbox
            // 
            adressTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            adressTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adressTextbox.ForeColor = Color.DodgerBlue;
            adressTextbox.Location = new Point(190, 584);
            adressTextbox.Multiline = true;
            adressTextbox.Name = "adressTextbox";
            adressTextbox.Size = new Size(1005, 29);
            adressTextbox.TabIndex = 14;
            // 
            // phoneTextbox
            // 
            phoneTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            phoneTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneTextbox.ForeColor = Color.DodgerBlue;
            phoneTextbox.Location = new Point(190, 640);
            phoneTextbox.Name = "phoneTextbox";
            phoneTextbox.Size = new Size(379, 30);
            phoneTextbox.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(12, 640);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 15;
            label5.Text = "Phone :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(638, 530);
            label6.Name = "label6";
            label6.Size = new Size(172, 28);
            label6.TabIndex = 17;
            label6.Text = "Gender :";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.BackColor = Color.DodgerBlue;
            addButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(769, 685);
            addButton.Name = "addButton";
            addButton.Size = new Size(138, 42);
            addButton.TabIndex = 18;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearButton.BackColor = Color.DodgerBlue;
            clearButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(913, 685);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(138, 42);
            clearButton.TabIndex = 19;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = Color.DodgerBlue;
            label7.Font = new Font("Segoe MDL2 Assets", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(-1, -3);
            label7.Name = "label7";
            label7.Size = new Size(1211, 70);
            label7.TabIndex = 20;
            label7.Text = "Registration";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backButton.BackColor = SystemColors.Control;
            backButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.ForeColor = Color.DodgerBlue;
            backButton.Location = new Point(1057, 685);
            backButton.Name = "backButton";
            backButton.Size = new Size(138, 42);
            backButton.TabIndex = 21;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1207, 739);
            Controls.Add(backButton);
            Controls.Add(label7);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(label6);
            Controls.Add(phoneTextbox);
            Controls.Add(label5);
            Controls.Add(adressTextbox);
            Controls.Add(label4);
            Controls.Add(radioFemaleButton);
            Controls.Add(radioMaleButton);
            Controls.Add(lastNameTextbox);
            Controls.Add(dateTimePicker);
            Controls.Add(label3);
            Controls.Add(firstnameTextbox);
            Controls.Add(label2);
            Controls.Add(listDataGridView);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ((System.ComponentModel.ISupportInitialize)listDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView listDataGridView;
        private Label label2;
        private TextBox firstnameTextbox;
        private Label label3;
        private DateTimePicker dateTimePicker;
        private TextBox lastNameTextbox;
        private RadioButton radioMaleButton;
        private RadioButton radioFemaleButton;
        private Label label4;
        private TextBox adressTextbox;
        private TextBox phoneTextbox;
        private Label label5;
        private Label label6;
        private Button addButton;
        private Button clearButton;
        private Label label7;
        private Button backButton;
    }
}