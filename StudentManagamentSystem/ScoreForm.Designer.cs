namespace StudentManagamentSystem
{
    partial class ScoreForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreForm));
            clearButton = new Button();
            addButton = new Button();
            backButton = new Button();
            label7 = new Label();
            descriptionTextbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            studentIdTextbox = new TextBox();
            studentDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            scoreTextbox = new TextBox();
            label2 = new Label();
            scoreDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new Label();
            courseComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scoreDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearButton.BackColor = Color.DodgerBlue;
            clearButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(913, 692);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(138, 42);
            clearButton.TabIndex = 70;
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
            addButton.Location = new Point(769, 692);
            addButton.Name = "addButton";
            addButton.Size = new Size(138, 42);
            addButton.TabIndex = 69;
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
            backButton.Location = new Point(1057, 692);
            backButton.Name = "backButton";
            backButton.Size = new Size(138, 42);
            backButton.TabIndex = 68;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = Color.DodgerBlue;
            label7.Font = new Font("Segoe MDL2 Assets", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(-2, 4);
            label7.Name = "label7";
            label7.Size = new Size(602, 70);
            label7.TabIndex = 67;
            label7.Text = "Student List";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            descriptionTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionTextbox.ForeColor = Color.DodgerBlue;
            descriptionTextbox.Location = new Point(188, 576);
            descriptionTextbox.Multiline = true;
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.Size = new Size(517, 149);
            descriptionTextbox.TabIndex = 66;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(10, 477);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 65;
            label5.Text = "Select Course :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(10, 527);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 63;
            label4.Text = "Score :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // studentIdTextbox
            // 
            studentIdTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            studentIdTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            studentIdTextbox.ForeColor = Color.DodgerBlue;
            studentIdTextbox.Location = new Point(188, 426);
            studentIdTextbox.Name = "studentIdTextbox";
            studentIdTextbox.Size = new Size(272, 30);
            studentIdTextbox.TabIndex = 62;
            // 
            // studentDataGridView
            // 
            studentDataGridView.AllowUserToAddRows = false;
            studentDataGridView.AllowUserToDeleteRows = false;
            studentDataGridView.AllowUserToResizeColumns = false;
            studentDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            studentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            studentDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            studentDataGridView.BackgroundColor = Color.LightGray;
            studentDataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            studentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            studentDataGridView.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            studentDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            studentDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            studentDataGridView.Location = new Point(10, 77);
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.ReadOnly = true;
            studentDataGridView.RowHeadersVisible = false;
            studentDataGridView.RowHeadersWidth = 51;
            studentDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            studentDataGridView.RowTemplate.Height = 29;
            studentDataGridView.Size = new Size(590, 343);
            studentDataGridView.TabIndex = 61;
            studentDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            studentDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            studentDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            studentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            studentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            studentDataGridView.ThemeStyle.BackColor = Color.LightGray;
            studentDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            studentDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            studentDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            studentDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            studentDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            studentDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            studentDataGridView.ThemeStyle.HeaderStyle.Height = 24;
            studentDataGridView.ThemeStyle.ReadOnly = true;
            studentDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            studentDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            studentDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            studentDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            studentDataGridView.ThemeStyle.RowsStyle.Height = 29;
            studentDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            studentDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            studentDataGridView.Click += studentDataGridView_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(10, 427);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 60;
            label1.Text = "Student ID :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // scoreTextbox
            // 
            scoreTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            scoreTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreTextbox.ForeColor = Color.DodgerBlue;
            scoreTextbox.Location = new Point(188, 526);
            scoreTextbox.Multiline = true;
            scoreTextbox.Name = "scoreTextbox";
            scoreTextbox.Size = new Size(272, 29);
            scoreTextbox.TabIndex = 71;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(10, 577);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 72;
            label2.Text = "Description :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // scoreDataGridView
            // 
            scoreDataGridView.AllowUserToAddRows = false;
            scoreDataGridView.AllowUserToDeleteRows = false;
            scoreDataGridView.AllowUserToResizeColumns = false;
            scoreDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            scoreDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            scoreDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            scoreDataGridView.BackgroundColor = Color.LightGray;
            scoreDataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            scoreDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            scoreDataGridView.ColumnHeadersHeight = 24;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            scoreDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            scoreDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            scoreDataGridView.Location = new Point(606, 77);
            scoreDataGridView.Name = "scoreDataGridView";
            scoreDataGridView.ReadOnly = true;
            scoreDataGridView.RowHeadersVisible = false;
            scoreDataGridView.RowHeadersWidth = 51;
            scoreDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            scoreDataGridView.RowTemplate.Height = 29;
            scoreDataGridView.Size = new Size(589, 343);
            scoreDataGridView.TabIndex = 74;
            scoreDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            scoreDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            scoreDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            scoreDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            scoreDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            scoreDataGridView.ThemeStyle.BackColor = Color.LightGray;
            scoreDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            scoreDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            scoreDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            scoreDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            scoreDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            scoreDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            scoreDataGridView.ThemeStyle.HeaderStyle.Height = 24;
            scoreDataGridView.ThemeStyle.ReadOnly = true;
            scoreDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            scoreDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            scoreDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            scoreDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            scoreDataGridView.ThemeStyle.RowsStyle.Height = 29;
            scoreDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            scoreDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.DodgerBlue;
            label3.Font = new Font("Segoe MDL2 Assets", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(606, 4);
            label3.Name = "label3";
            label3.Size = new Size(600, 70);
            label3.TabIndex = 75;
            label3.Text = "Score List";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // courseComboBox
            // 
            courseComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            courseComboBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            courseComboBox.ForeColor = Color.DodgerBlue;
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Location = new Point(188, 477);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(272, 33);
            courseComboBox.TabIndex = 76;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 739);
            Controls.Add(courseComboBox);
            Controls.Add(label3);
            Controls.Add(scoreDataGridView);
            Controls.Add(label2);
            Controls.Add(scoreTextbox);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(backButton);
            Controls.Add(label7);
            Controls.Add(descriptionTextbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(studentIdTextbox);
            Controls.Add(studentDataGridView);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ScoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScoreForm";
            Load += ScoreForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)scoreDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clearButton;
        private Button addButton;
        private Button backButton;
        private Label label7;
        private TextBox descriptionTextbox;
        private Label label5;
        private Label label4;
        private TextBox studentIdTextbox;
        private Guna.UI2.WinForms.Guna2DataGridView studentDataGridView;
        private Label label1;
        private TextBox scoreTextbox;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView scoreDataGridView;
        private Label label3;
        private ComboBox courseComboBox;
    }
}