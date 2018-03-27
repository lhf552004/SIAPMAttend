namespace SIAPMAttend
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.TargetTranslateXMLopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SourceTranslateXMLopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TestButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ToTranslatedataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToTranslatelabel = new System.Windows.Forms.Label();
            this.IDCriteriaText = new System.Windows.Forms.TextBox();
            this.LabelCriteriaText = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AttendTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CurEmployeeAttendTypeTextBox = new System.Windows.Forms.TextBox();
            this.CurAttendTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CurEmployeeGenderTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CurEmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CurEmployeeAgeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CurEmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ToTranslatedataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TargetTranslateXMLopenFileDialog
            // 
            this.TargetTranslateXMLopenFileDialog.FileName = "openFileDialog1";
            // 
            // SourceTranslateXMLopenFileDialog
            // 
            this.SourceTranslateXMLopenFileDialog.FileName = "openFileDialog2";
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(962, 12);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(129, 52);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Visible = false;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(638, 537);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 52);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ToTranslatedataGridView
            // 
            this.ToTranslatedataGridView.AllowUserToAddRows = false;
            this.ToTranslatedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToTranslatedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.Age,
            this.AttendType,
            this.Gender});
            this.ToTranslatedataGridView.Location = new System.Drawing.Point(12, 233);
            this.ToTranslatedataGridView.Name = "ToTranslatedataGridView";
            this.ToTranslatedataGridView.Size = new System.Drawing.Size(1142, 189);
            this.ToTranslatedataGridView.TabIndex = 5;
            this.ToTranslatedataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ToTranslatedataGridView_CellBeginEdit);
            this.ToTranslatedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ToTranslatedataGridView_CellClick);
            this.ToTranslatedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ToTranslatedataGridView_CellContentClick);
            this.ToTranslatedataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ToTranslatedataGridView_CellEndEdit);
            this.ToTranslatedataGridView.Click += new System.EventHandler(this.ToTranslatedataGridView_Click);
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Width = 200;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 200;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.Width = 150;
            // 
            // AttendType
            // 
            this.AttendType.HeaderText = "AttendType";
            this.AttendType.Name = "AttendType";
            this.AttendType.Width = 300;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.Width = 200;
            // 
            // ToTranslatelabel
            // 
            this.ToTranslatelabel.AutoSize = true;
            this.ToTranslatelabel.Location = new System.Drawing.Point(9, 196);
            this.ToTranslatelabel.Name = "ToTranslatelabel";
            this.ToTranslatelabel.Size = new System.Drawing.Size(58, 13);
            this.ToTranslatelabel.TabIndex = 6;
            this.ToTranslatelabel.Text = "Employees";
            // 
            // IDCriteriaText
            // 
            this.IDCriteriaText.Enabled = false;
            this.IDCriteriaText.Location = new System.Drawing.Point(52, 196);
            this.IDCriteriaText.Name = "IDCriteriaText";
            this.IDCriteriaText.Size = new System.Drawing.Size(71, 20);
            this.IDCriteriaText.TabIndex = 11;
            this.IDCriteriaText.TextChanged += new System.EventHandler(this.IDCriteriaText_TextChanged);
            // 
            // LabelCriteriaText
            // 
            this.LabelCriteriaText.Enabled = false;
            this.LabelCriteriaText.Location = new System.Drawing.Point(253, 196);
            this.LabelCriteriaText.Name = "LabelCriteriaText";
            this.LabelCriteriaText.Size = new System.Drawing.Size(80, 20);
            this.LabelCriteriaText.TabIndex = 11;
            this.LabelCriteriaText.TextChanged += new System.EventHandler(this.LabelCriteriaText_TextChanged);
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(116, 26);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIDTextBox.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AttendTypeComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GenderTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EmployeeNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AgeTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EmployeeIDTextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 138);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New";
            // 
            // AttendTypeComboBox
            // 
            this.AttendTypeComboBox.FormattingEnabled = true;
            this.AttendTypeComboBox.Location = new System.Drawing.Point(397, 64);
            this.AttendTypeComboBox.Name = "AttendTypeComboBox";
            this.AttendTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.AttendTypeComboBox.TabIndex = 14;
            this.AttendTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AttendTypeComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "AttendType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gender";
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.Location = new System.Drawing.Point(116, 102);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenderTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Employee Name";
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(397, 26);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNameTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Age";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(116, 64);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "EmployeeID";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(603, 195);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(638, 37);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(129, 52);
            this.NewButton.TabIndex = 16;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CurEmployeeAttendTypeTextBox);
            this.groupBox2.Controls.Add(this.CurAttendTypeComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CurEmployeeGenderTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CurEmployeeNameTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CurEmployeeAgeTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CurEmployeeIDTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 178);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // CurEmployeeAttendTypeTextBox
            // 
            this.CurEmployeeAttendTypeTextBox.Enabled = false;
            this.CurEmployeeAttendTypeTextBox.Location = new System.Drawing.Point(397, 95);
            this.CurEmployeeAttendTypeTextBox.Name = "CurEmployeeAttendTypeTextBox";
            this.CurEmployeeAttendTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurEmployeeAttendTypeTextBox.TabIndex = 15;
            // 
            // CurAttendTypeComboBox
            // 
            this.CurAttendTypeComboBox.FormattingEnabled = true;
            this.CurAttendTypeComboBox.Location = new System.Drawing.Point(397, 68);
            this.CurAttendTypeComboBox.Name = "CurAttendTypeComboBox";
            this.CurAttendTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.CurAttendTypeComboBox.TabIndex = 14;
            this.CurAttendTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.CurAttendTypeComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "AttendType";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gender";
            // 
            // CurEmployeeGenderTextBox
            // 
            this.CurEmployeeGenderTextBox.Location = new System.Drawing.Point(116, 102);
            this.CurEmployeeGenderTextBox.Name = "CurEmployeeGenderTextBox";
            this.CurEmployeeGenderTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurEmployeeGenderTextBox.TabIndex = 12;
            this.CurEmployeeGenderTextBox.TextChanged += new System.EventHandler(this.CurEmployeeGenderTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Employee Name";
            // 
            // CurEmployeeNameTextBox
            // 
            this.CurEmployeeNameTextBox.Location = new System.Drawing.Point(397, 26);
            this.CurEmployeeNameTextBox.Name = "CurEmployeeNameTextBox";
            this.CurEmployeeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurEmployeeNameTextBox.TabIndex = 12;
            this.CurEmployeeNameTextBox.TextChanged += new System.EventHandler(this.CurEmployeeNameTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Age";
            // 
            // CurEmployeeAgeTextBox
            // 
            this.CurEmployeeAgeTextBox.Location = new System.Drawing.Point(116, 64);
            this.CurEmployeeAgeTextBox.Name = "CurEmployeeAgeTextBox";
            this.CurEmployeeAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurEmployeeAgeTextBox.TabIndex = 12;
            this.CurEmployeeAgeTextBox.TextChanged += new System.EventHandler(this.CurEmployeeAgeTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "EmployeeID";
            // 
            // CurEmployeeIDTextBox
            // 
            this.CurEmployeeIDTextBox.Enabled = false;
            this.CurEmployeeIDTextBox.Location = new System.Drawing.Point(116, 26);
            this.CurEmployeeIDTextBox.Name = "CurEmployeeIDTextBox";
            this.CurEmployeeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurEmployeeIDTextBox.TabIndex = 12;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(638, 455);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(129, 52);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 655);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelCriteriaText);
            this.Controls.Add(this.IDCriteriaText);
            this.Controls.Add(this.ToTranslatelabel);
            this.Controls.Add(this.ToTranslatedataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeesForm";
            this.Text = "Employee edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MBTranslator_FormClosing);
            this.Load += new System.EventHandler(this.MBTranslator_Load);
            this.Resize += new System.EventHandler(this.MBTranslator_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ToTranslatedataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog TargetTranslateXMLopenFileDialog;
        private System.Windows.Forms.OpenFileDialog SourceTranslateXMLopenFileDialog;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView ToTranslatedataGridView;
        private System.Windows.Forms.Label ToTranslatelabel;
        private System.Windows.Forms.TextBox IDCriteriaText;
        private System.Windows.Forms.TextBox LabelCriteriaText;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox AttendTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GenderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CurAttendTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CurEmployeeGenderTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CurEmployeeNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CurEmployeeAgeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CurEmployeeIDTextBox;
        private System.Windows.Forms.TextBox CurEmployeeAttendTypeTextBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}

