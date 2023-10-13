namespace StudentManagamentSystem
{
    partial class CourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            label7 = new Label();
            descriptionTextbox = new TextBox();
            label5 = new Label();
            hourTextbox = new TextBox();
            label4 = new Label();
            courseTextbox = new TextBox();
            courseDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            clearButton = new Button();
            addButton = new Button();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)courseDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.BackColor = Color.DodgerBlue;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe MDL2 Assets", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(1207, 70);
            label7.TabIndex = 28;
            label7.Text = "New Course";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            descriptionTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTextbox.ForeColor = Color.DodgerBlue;
            descriptionTextbox.Location = new Point(12, 578);
            descriptionTextbox.Multiline = true;
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.Size = new Size(517, 149);
            descriptionTextbox.TabIndex = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(12, 547);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 26;
            label5.Text = "Description :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hourTextbox
            // 
            hourTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            hourTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hourTextbox.ForeColor = Color.DodgerBlue;
            hourTextbox.Location = new Point(12, 515);
            hourTextbox.Multiline = true;
            hourTextbox.Name = "hourTextbox";
            hourTextbox.Size = new Size(272, 29);
            hourTextbox.TabIndex = 25;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(12, 484);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 24;
            label4.Text = "Hour :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // courseTextbox
            // 
            courseTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            courseTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            courseTextbox.ForeColor = Color.DodgerBlue;
            courseTextbox.Location = new Point(12, 451);
            courseTextbox.Name = "courseTextbox";
            courseTextbox.Size = new Size(272, 30);
            courseTextbox.TabIndex = 23;
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
            courseDataGridView.Location = new Point(12, 70);
            courseDataGridView.Name = "courseDataGridView";
            courseDataGridView.ReadOnly = true;
            courseDataGridView.RowHeadersVisible = false;
            courseDataGridView.RowHeadersWidth = 51;
            courseDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            courseDataGridView.RowTemplate.Height = 29;
            courseDataGridView.Size = new Size(1183, 347);
            courseDataGridView.TabIndex = 22;
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
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(12, 420);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 21;
            label1.Text = "Course Name :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearButton.BackColor = Color.DodgerBlue;
            clearButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(915, 685);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(138, 42);
            clearButton.TabIndex = 48;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.BackColor = Color.DodgerBlue;
            addButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(771, 685);
            addButton.Name = "addButton";
            addButton.Size = new Size(138, 42);
            addButton.TabIndex = 47;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backButton.BackColor = SystemColors.Control;
            backButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.ForeColor = Color.DodgerBlue;
            backButton.Location = new Point(1059, 685);
            backButton.Name = "backButton";
            backButton.Size = new Size(138, 42);
            backButton.TabIndex = 46;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 739);
            Controls.Add(clearButton);
            Controls.Add(addButton);
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
            Name = "CourseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CourseForm";
            Load += CourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)courseDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox descriptionTextbox;
        private Label label5;
        private TextBox hourTextbox;
        private Label label4;
        private TextBox courseTextbox;
        private Guna.UI2.WinForms.Guna2DataGridView courseDataGridView;
        private Label label1;
        private Button clearButton;
        private Button addButton;
        private Button backButton;
    }
}