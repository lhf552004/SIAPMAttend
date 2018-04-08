namespace SIAPMAttend
{
    partial class AttendTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendTypeForm));
            this.TargetTranslateXMLopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SourceTranslateXMLopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TestButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ToTranslatedataGridView = new System.Windows.Forms.DataGridView();
            this.ToTranslatelabel = new System.Windows.Forms.Label();
            this.IDCriteriaText = new System.Windows.Forms.TextBox();
            this.LabelCriteriaText = new System.Windows.Forms.TextBox();
            this.TargetMinuteInTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShiftTimeTextBox = new System.Windows.Forms.TextBox();
            this.IsShiftCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AttendTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TargetHourInTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CurAttendTypeShiftTimeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CurAttendTypeTargetHourInTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CurAttendTypeTargetMinuteInTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CurAttendTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CurAttendTypeIsShiftCheckBox = new System.Windows.Forms.CheckBox();
            this.AttendTypeNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetHourInCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetMinuteInCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsShiftCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.AttendTypeNameCol,
            this.TargetHourInCol,
            this.TargetMinuteInCol,
            this.ShiftTimeCol,
            this.IsShiftCol});
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
            // TargetMinuteInTextBox
            // 
            this.TargetMinuteInTextBox.Location = new System.Drawing.Point(120, 70);
            this.TargetMinuteInTextBox.Name = "TargetMinuteInTextBox";
            this.TargetMinuteInTextBox.Size = new System.Drawing.Size(100, 20);
            this.TargetMinuteInTextBox.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShiftTimeTextBox);
            this.groupBox1.Controls.Add(this.IsShiftCheckBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AttendTypeNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TargetHourInTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TargetMinuteInTextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 138);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New";
            // 
            // ShiftTimeTextBox
            // 
            this.ShiftTimeTextBox.Location = new System.Drawing.Point(403, 70);
            this.ShiftTimeTextBox.Name = "ShiftTimeTextBox";
            this.ShiftTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShiftTimeTextBox.TabIndex = 16;
            // 
            // IsShiftCheckBox
            // 
            this.IsShiftCheckBox.AutoSize = true;
            this.IsShiftCheckBox.Location = new System.Drawing.Point(120, 113);
            this.IsShiftCheckBox.Name = "IsShiftCheckBox";
            this.IsShiftCheckBox.Size = new System.Drawing.Size(58, 17);
            this.IsShiftCheckBox.TabIndex = 15;
            this.IsShiftCheckBox.Text = "Is Shift";
            this.IsShiftCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Shift Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "AttendType Name";
            // 
            // AttendTypeNameTextBox
            // 
            this.AttendTypeNameTextBox.Location = new System.Drawing.Point(120, 25);
            this.AttendTypeNameTextBox.Name = "AttendTypeNameTextBox";
            this.AttendTypeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AttendTypeNameTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Target Hour In";
            // 
            // TargetHourInTextBox
            // 
            this.TargetHourInTextBox.Location = new System.Drawing.Point(403, 25);
            this.TargetHourInTextBox.Name = "TargetHourInTextBox";
            this.TargetHourInTextBox.Size = new System.Drawing.Size(100, 20);
            this.TargetHourInTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Target Minute In";
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
            this.groupBox2.Controls.Add(this.CurAttendTypeIsShiftCheckBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CurAttendTypeShiftTimeTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CurAttendTypeTargetHourInTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CurAttendTypeTargetMinuteInTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CurAttendTypeNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 178);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Shift Time";
            // 
            // CurAttendTypeShiftTimeTextBox
            // 
            this.CurAttendTypeShiftTimeTextBox.Location = new System.Drawing.Point(397, 64);
            this.CurAttendTypeShiftTimeTextBox.Name = "CurAttendTypeShiftTimeTextBox";
            this.CurAttendTypeShiftTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurAttendTypeShiftTimeTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Target Hour In";
            // 
            // CurAttendTypeTargetHourInTextBox
            // 
            this.CurAttendTypeTargetHourInTextBox.Location = new System.Drawing.Point(397, 26);
            this.CurAttendTypeTargetHourInTextBox.Name = "CurAttendTypeTargetHourInTextBox";
            this.CurAttendTypeTargetHourInTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurAttendTypeTargetHourInTextBox.TabIndex = 12;
            this.CurAttendTypeTargetHourInTextBox.TextChanged += new System.EventHandler(this.CurEmployeeNameTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Target Minute In";
            // 
            // CurAttendTypeTargetMinuteInTextBox
            // 
            this.CurAttendTypeTargetMinuteInTextBox.Location = new System.Drawing.Point(124, 64);
            this.CurAttendTypeTargetMinuteInTextBox.Name = "CurAttendTypeTargetMinuteInTextBox";
            this.CurAttendTypeTargetMinuteInTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurAttendTypeTargetMinuteInTextBox.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Name";
            // 
            // CurAttendTypeNameTextBox
            // 
            this.CurAttendTypeNameTextBox.Enabled = false;
            this.CurAttendTypeNameTextBox.Location = new System.Drawing.Point(124, 26);
            this.CurAttendTypeNameTextBox.Name = "CurAttendTypeNameTextBox";
            this.CurAttendTypeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurAttendTypeNameTextBox.TabIndex = 12;
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
            // CurAttendTypeIsShiftCheckBox
            // 
            this.CurAttendTypeIsShiftCheckBox.AutoSize = true;
            this.CurAttendTypeIsShiftCheckBox.Location = new System.Drawing.Point(123, 105);
            this.CurAttendTypeIsShiftCheckBox.Name = "CurAttendTypeIsShiftCheckBox";
            this.CurAttendTypeIsShiftCheckBox.Size = new System.Drawing.Size(58, 17);
            this.CurAttendTypeIsShiftCheckBox.TabIndex = 16;
            this.CurAttendTypeIsShiftCheckBox.Text = "Is Shift";
            this.CurAttendTypeIsShiftCheckBox.UseVisualStyleBackColor = true;
            // 
            // AttendTypeNameCol
            // 
            this.AttendTypeNameCol.HeaderText = "AttendTypeName";
            this.AttendTypeNameCol.Name = "AttendTypeNameCol";
            // 
            // TargetHourInCol
            // 
            this.TargetHourInCol.HeaderText = "TargetHourIn";
            this.TargetHourInCol.Name = "TargetHourInCol";
            // 
            // TargetMinuteInCol
            // 
            this.TargetMinuteInCol.HeaderText = "TargetMinuteIn";
            this.TargetMinuteInCol.Name = "TargetMinuteInCol";
            // 
            // ShiftTimeCol
            // 
            this.ShiftTimeCol.HeaderText = "ShiftTime";
            this.ShiftTimeCol.Name = "ShiftTimeCol";
            // 
            // IsShiftCol
            // 
            this.IsShiftCol.HeaderText = "IsShift";
            this.IsShiftCol.Name = "IsShiftCol";
            // 
            // AttendTypeForm
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
            this.Name = "AttendTypeForm";
            this.Text = "AttendType edit";
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
        private System.Windows.Forms.TextBox TargetMinuteInTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AttendTypeNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TargetHourInTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CurAttendTypeShiftTimeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CurAttendTypeTargetHourInTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CurAttendTypeTargetMinuteInTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CurAttendTypeNameTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.CheckBox IsShiftCheckBox;
        private System.Windows.Forms.TextBox ShiftTimeTextBox;
        private System.Windows.Forms.CheckBox CurAttendTypeIsShiftCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendTypeNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetHourInCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetMinuteInCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsShiftCol;
    }
}

