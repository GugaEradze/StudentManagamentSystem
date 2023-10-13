namespace StudentManagamentSystem
{
    partial class ManageScoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageScoresForm));
            deleteButton = new Button();
            updateButton = new Button();
            backButton = new Button();
            label7 = new Label();
            listDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            courseComboBox = new ComboBox();
            label2 = new Label();
            scoreTextbox = new TextBox();
            descriptionTextbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            studentIdTextbox = new TextBox();
            label1 = new Label();
            searchTextBox = new TextBox();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)listDataGridView).BeginInit();
            SuspendLayout();
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
            deleteButton.TabIndex = 52;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
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
            updateButton.TabIndex = 51;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
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
            backButton.TabIndex = 48;
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
            label7.TabIndex = 47;
            label7.Text = "Manage Scores";
            label7.TextAlign = ContentAlignment.MiddleCenter;
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
            listDataGridView.TabIndex = 46;
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
            // courseComboBox
            // 
            courseComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            courseComboBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            courseComboBox.ForeColor = Color.DodgerBlue;
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Location = new Point(190, 541);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(272, 33);
            courseComboBox.TabIndex = 84;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(12, 641);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 83;
            label2.Text = "Description :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // scoreTextbox
            // 
            scoreTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            scoreTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreTextbox.ForeColor = Color.DodgerBlue;
            scoreTextbox.Location = new Point(190, 590);
            scoreTextbox.Multiline = true;
            scoreTextbox.Name = "scoreTextbox";
            scoreTextbox.Size = new Size(272, 29);
            scoreTextbox.TabIndex = 82;
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            descriptionTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTextbox.ForeColor = Color.DodgerBlue;
            descriptionTextbox.Location = new Point(190, 641);
            descriptionTextbox.Multiline = true;
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.Size = new Size(517, 93);
            descriptionTextbox.TabIndex = 81;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(12, 541);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 80;
            label5.Text = "Select Course :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(12, 591);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 79;
            label4.Text = "Score :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // studentIdTextbox
            // 
            studentIdTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            studentIdTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            studentIdTextbox.ForeColor = Color.DodgerBlue;
            studentIdTextbox.Location = new Point(190, 490);
            studentIdTextbox.Name = "studentIdTextbox";
            studentIdTextbox.Size = new Size(272, 30);
            studentIdTextbox.TabIndex = 78;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(12, 491);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 77;
            label1.Text = "Student ID :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            searchTextBox.ForeColor = Color.DodgerBlue;
            searchTextBox.Location = new Point(835, 82);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(216, 29);
            searchTextBox.TabIndex = 85;
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
            searchButton.TabIndex = 86;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // ManageScoresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 739);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(courseComboBox);
            Controls.Add(label2);
            Controls.Add(scoreTextbox);
            Controls.Add(descriptionTextbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(studentIdTextbox);
            Controls.Add(label1);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(backButton);
            Controls.Add(label7);
            Controls.Add(listDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManageScoresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageScoresForm";
            Load += ManageScoresForm_Load;
            ((System.ComponentModel.ISupportInitialize)listDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteButton;
        private Button updateButton;
        private Button backButton;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView listDataGridView;
        private ComboBox courseComboBox;
        private Label label2;
        private TextBox scoreTextbox;
        private TextBox descriptionTextbox;
        private Label label5;
        private Label label4;
        private TextBox studentIdTextbox;
        private Label label1;
        private TextBox searchTextBox;
        private Button searchButton;
    }
}