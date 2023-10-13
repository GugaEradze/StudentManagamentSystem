namespace StudentManagamentSystem
{
    partial class ManageCoursesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCoursesForm));
            deleteButton = new Button();
            updateButton = new Button();
            backButton = new Button();
            label7 = new Label();
            descriptionTextbox = new TextBox();
            label5 = new Label();
            hourTextbox = new TextBox();
            label4 = new Label();
            courseTextbox = new TextBox();
            courseDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            idTextbox = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)courseDataGridView).BeginInit();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.BackColor = Color.Red;
            deleteButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(913, 692);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(138, 42);
            deleteButton.TabIndex = 59;
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
            updateButton.Location = new Point(769, 692);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(138, 42);
            updateButton.TabIndex = 58;
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
            backButton.Location = new Point(1057, 692);
            backButton.Name = "backButton";
            backButton.Size = new Size(138, 42);
            backButton.TabIndex = 57;
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
            label7.Size = new Size(1207, 74);
            label7.TabIndex = 56;
            label7.Text = "Manage Course";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            descriptionTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTextbox.ForeColor = Color.DodgerBlue;
            descriptionTextbox.Location = new Point(10, 585);
            descriptionTextbox.Multiline = true;
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.Size = new Size(517, 149);
            descriptionTextbox.TabIndex = 55;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(10, 554);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 54;
            label5.Text = "Description :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hourTextbox
            // 
            hourTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            hourTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hourTextbox.ForeColor = Color.DodgerBlue;
            hourTextbox.Location = new Point(10, 522);
            hourTextbox.Multiline = true;
            hourTextbox.Name = "hourTextbox";
            hourTextbox.Size = new Size(272, 29);
            hourTextbox.TabIndex = 53;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(10, 491);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 52;
            label4.Text = "Hour :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // courseTextbox
            // 
            courseTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            courseTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            courseTextbox.ForeColor = Color.DodgerBlue;
            courseTextbox.Location = new Point(10, 458);
            courseTextbox.Name = "courseTextbox";
            courseTextbox.Size = new Size(272, 30);
            courseTextbox.TabIndex = 51;
            // 
            // courseDataGridView
            // 
            courseDataGridView.AllowUserToAddRows = false;
            courseDataGridView.AllowUserToDeleteRows = false;
            courseDataGridView.AllowUserToResizeColumns = false;
            courseDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            courseDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            courseDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            courseDataGridView.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            courseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            courseDataGridView.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            courseDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            courseDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            courseDataGridView.Location = new Point(10, 77);
            courseDataGridView.Name = "courseDataGridView";
            courseDataGridView.ReadOnly = true;
            courseDataGridView.RowHeadersVisible = false;
            courseDataGridView.RowHeadersWidth = 51;
            courseDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            courseDataGridView.RowTemplate.Height = 29;
            courseDataGridView.Size = new Size(1183, 347);
            courseDataGridView.TabIndex = 50;
            courseDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            courseDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            courseDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            courseDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            courseDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            courseDataGridView.ThemeStyle.BackColor = Color.LightGray;
            courseDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            courseDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            courseDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            courseDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            courseDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            courseDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            courseDataGridView.ThemeStyle.HeaderStyle.Height = 24;
            courseDataGridView.ThemeStyle.ReadOnly = true;
            courseDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            courseDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            courseDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            courseDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            courseDataGridView.ThemeStyle.RowsStyle.Height = 29;
            courseDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            courseDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            courseDataGridView.Click += courseDataGridView_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(10, 427);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 49;
            label1.Text = "Course Name :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idTextbox
            // 
            idTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            idTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            idTextbox.ForeColor = Color.DodgerBlue;
            idTextbox.Location = new Point(288, 458);
            idTextbox.Name = "idTextbox";
            idTextbox.Size = new Size(239, 30);
            idTextbox.TabIndex = 61;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(288, 427);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 60;
            label2.Text = "ID :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ManageCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 739);
            Controls.Add(idTextbox);
            Controls.Add(label2);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(backButton);
            Controls.Add(label7);
            Controls.Add(descriptionTextbox);
            Controls.Add(label5);
            Controls.Add(hourTextbox);
            Controls.Add(label4);
            Controls.Add(courseTextbox);
            Controls.Add(courseDataGridView);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManageCoursesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCourses";
            Load += ManageCourses_Load;
            ((System.ComponentModel.ISupportInitialize)courseDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteButton;
        private Button updateButton;
        private Button backButton;
        private Label label7;
        private TextBox descriptionTextbox;
        private Label label5;
        private TextBox hourTextbox;
        private Label label4;
        private TextBox courseTextbox;
        private Guna.UI2.WinForms.Guna2DataGridView courseDataGridView;
        private Label label1;
        private TextBox idTextbox;
        private Label label2;
    }
}