namespace StudentManagamentSystem
{
    partial class ManageStudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudentsForm));
            backButton = new Button();
            label7 = new Label();
            label6 = new Label();
            phoneTextbox = new TextBox();
            label5 = new Label();
            adressTextbox = new TextBox();
            label4 = new Label();
            radioFemaleButton = new RadioButton();
            radioMaleButton = new RadioButton();
            lastNameTextbox = new TextBox();
            dateTimePicker = new DateTimePicker();
            label3 = new Label();
            firstnameTextbox = new TextBox();
            label2 = new Label();
            listDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            searchTextBox = new TextBox();
            searchButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            idTextbox = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)listDataGridView).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backButton.BackColor = SystemColors.Control;
            backButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.ForeColor = Color.DodgerBlue;
            backButton.Location = new Point(1056, 692);
            backButton.Name = "backButton";
            backButton.Size = new Size(138, 42);
            backButton.TabIndex = 39;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.DodgerBlue;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe MDL2 Assets", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(1207, 72);
            label7.TabIndex = 38;
            label7.Text = "Students Management";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(637, 537);
            label6.Name = "label6";
            label6.Size = new Size(172, 28);
            label6.TabIndex = 35;
            label6.Text = "Gender :";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // phoneTextbox
            // 
            phoneTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            phoneTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneTextbox.ForeColor = Color.DodgerBlue;
            phoneTextbox.Location = new Point(189, 647);
            phoneTextbox.Name = "phoneTextbox";
            phoneTextbox.Size = new Size(379, 30);
            phoneTextbox.TabIndex = 34;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(11, 647);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 33;
            label5.Text = "Phone :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // adressTextbox
            // 
            adressTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            adressTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adressTextbox.ForeColor = Color.DodgerBlue;
            adressTextbox.Location = new Point(189, 591);
            adressTextbox.Multiline = true;
            adressTextbox.Name = "adressTextbox";
            adressTextbox.Size = new Size(1005, 29);
            adressTextbox.TabIndex = 32;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(11, 592);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 31;
            label4.Text = "Adress :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radioFemaleButton
            // 
            radioFemaleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioFemaleButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioFemaleButton.ForeColor = Color.DodgerBlue;
            radioFemaleButton.Location = new Point(1008, 540);
            radioFemaleButton.Name = "radioFemaleButton";
            radioFemaleButton.Size = new Size(186, 29);
            radioFemaleButton.TabIndex = 30;
            radioFemaleButton.TabStop = true;
            radioFemaleButton.Text = "Female";
            radioFemaleButton.UseVisualStyleBackColor = true;
            // 
            // radioMaleButton
            // 
            radioMaleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioMaleButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioMaleButton.ForeColor = Color.DodgerBlue;
            radioMaleButton.Location = new Point(815, 540);
            radioMaleButton.Name = "radioMaleButton";
            radioMaleButton.Size = new Size(186, 30);
            radioMaleButton.TabIndex = 29;
            radioMaleButton.TabStop = true;
            radioMaleButton.Text = "Male";
            radioMaleButton.UseVisualStyleBackColor = true;
            // 
            // lastNameTextbox
            // 
            lastNameTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lastNameTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameTextbox.ForeColor = Color.DodgerBlue;
            lastNameTextbox.Location = new Point(815, 485);
            lastNameTextbox.Name = "lastNameTextbox";
            lastNameTextbox.Size = new Size(379, 30);
            lastNameTextbox.TabIndex = 28;
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
            dateTimePicker.Location = new Point(189, 535);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(379, 30);
            dateTimePicker.TabIndex = 27;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(11, 537);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 26;
            label3.Text = "Date Of Birth :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // firstnameTextbox
            // 
            firstnameTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            firstnameTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstnameTextbox.ForeColor = Color.DodgerBlue;
            firstnameTextbox.Location = new Point(189, 486);
            firstnameTextbox.Name = "firstnameTextbox";
            firstnameTextbox.Size = new Size(379, 30);
            firstnameTextbox.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(637, 488);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 24;
            label2.Text = "Last Name :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
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
            listDataGridView.Location = new Point(11, 123);
            listDataGridView.Name = "listDataGridView";
            listDataGridView.ReadOnly = true;
            listDataGridView.RowHeadersVisible = false;
            listDataGridView.RowHeadersWidth = 51;
            listDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            listDataGridView.RowTemplate.Height = 29;
            listDataGridView.Size = new Size(1183, 356);
            listDataGridView.TabIndex = 23;
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
            listDataGridView.Click += listDataGridView_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(11, 482);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 22;
            label1.Text = "First Name :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchTextBox.ForeColor = Color.DodgerBlue;
            searchTextBox.Location = new Point(818, 82);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(233, 30);
            searchTextBox.TabIndex = 40;
            searchTextBox.KeyPress += searchTextBox_KeyPress;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.BackColor = Color.DodgerBlue;
            searchButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(1057, 75);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(138, 42);
            searchButton.TabIndex = 41;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updateButton.BackColor = Color.DodgerBlue;
            updateButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(768, 692);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(138, 42);
            updateButton.TabIndex = 44;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.BackColor = Color.Red;
            deleteButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(912, 692);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(138, 42);
            deleteButton.TabIndex = 45;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // idTextbox
            // 
            idTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            idTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            idTextbox.ForeColor = Color.DodgerBlue;
            idTextbox.Location = new Point(815, 648);
            idTextbox.Name = "idTextbox";
            idTextbox.Size = new Size(379, 30);
            idTextbox.TabIndex = 47;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(637, 648);
            label8.Name = "label8";
            label8.Size = new Size(172, 28);
            label8.TabIndex = 46;
            label8.Text = "ID :";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ManageStudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 739);
            Controls.Add(idTextbox);
            Controls.Add(label8);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(backButton);
            Controls.Add(label7);
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
            Name = "ManageStudentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageStudentsForm";
            Load += ManageStudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)listDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label label7;
        private Button clearButton;
        private Button addButton;
        private Label label6;
        private TextBox phoneTextbox;
        private Label label5;
        private TextBox adressTextbox;
        private Label label4;
        private RadioButton radioFemaleButton;
        private RadioButton radioMaleButton;
        private TextBox lastNameTextbox;
        private DateTimePicker dateTimePicker;
        private Label label3;
        private TextBox firstnameTextbox;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView listDataGridView;
        private Label label1;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button updateButton;
        private Button deleteButton;
        private TextBox idTextbox;
        private Label label8;
    }
}