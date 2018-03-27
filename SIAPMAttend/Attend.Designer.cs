namespace SIAPMAttend
{
    partial class Attend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attend));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TargetAttendDateTextBox = new System.Windows.Forms.TextBox();
            this.generateLicenseKeyButton = new System.Windows.Forms.Button();
            this.CheckExceptionAttendButton = new System.Windows.Forms.Button();
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.EditAttendTypeButton = new System.Windows.Forms.Button();
            this.SetExportPathButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExportPathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import Attend Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "请设置打卡日期：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Office Excel Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "ExcelLibrary Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "EPPlus ExcelPackage Test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(6, 19);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(327, 122);
            this.ResultText.TabIndex = 6;
            this.ResultText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "当前打卡日期：";
            // 
            // TargetAttendDateTextBox
            // 
            this.TargetAttendDateTextBox.Enabled = false;
            this.TargetAttendDateTextBox.Location = new System.Drawing.Point(120, 101);
            this.TargetAttendDateTextBox.Name = "TargetAttendDateTextBox";
            this.TargetAttendDateTextBox.Size = new System.Drawing.Size(200, 20);
            this.TargetAttendDateTextBox.TabIndex = 8;
            // 
            // generateLicenseKeyButton
            // 
            this.generateLicenseKeyButton.Location = new System.Drawing.Point(12, 102);
            this.generateLicenseKeyButton.Name = "generateLicenseKeyButton";
            this.generateLicenseKeyButton.Size = new System.Drawing.Size(118, 40);
            this.generateLicenseKeyButton.TabIndex = 11;
            this.generateLicenseKeyButton.Text = "GenerateLicenseKey";
            this.generateLicenseKeyButton.UseVisualStyleBackColor = true;
            this.generateLicenseKeyButton.Visible = false;
            this.generateLicenseKeyButton.Click += new System.EventHandler(this.generateLicenseKeyButton_Click);
            // 
            // CheckExceptionAttendButton
            // 
            this.CheckExceptionAttendButton.Location = new System.Drawing.Point(351, 189);
            this.CheckExceptionAttendButton.Name = "CheckExceptionAttendButton";
            this.CheckExceptionAttendButton.Size = new System.Drawing.Size(120, 45);
            this.CheckExceptionAttendButton.TabIndex = 12;
            this.CheckExceptionAttendButton.Text = "Check Exception Attend";
            this.CheckExceptionAttendButton.UseVisualStyleBackColor = true;
            this.CheckExceptionAttendButton.Click += new System.EventHandler(this.CheckExceptionAttendButton_Click);
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.Location = new System.Drawing.Point(6, 19);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(98, 39);
            this.EditEmployeeButton.TabIndex = 13;
            this.EditEmployeeButton.Text = "Edit Employees";
            this.EditEmployeeButton.UseVisualStyleBackColor = true;
            this.EditEmployeeButton.Click += new System.EventHandler(this.EditEmployeeButton_Click);
            // 
            // EditAttendTypeButton
            // 
            this.EditAttendTypeButton.Location = new System.Drawing.Point(234, 19);
            this.EditAttendTypeButton.Name = "EditAttendTypeButton";
            this.EditAttendTypeButton.Size = new System.Drawing.Size(98, 39);
            this.EditAttendTypeButton.TabIndex = 14;
            this.EditAttendTypeButton.Text = "Edit Attend Type";
            this.EditAttendTypeButton.UseVisualStyleBackColor = true;
            this.EditAttendTypeButton.Click += new System.EventHandler(this.EditAttendTypeButton_Click);
            // 
            // SetExportPathButton
            // 
            this.SetExportPathButton.Location = new System.Drawing.Point(120, 19);
            this.SetExportPathButton.Name = "SetExportPathButton";
            this.SetExportPathButton.Size = new System.Drawing.Size(98, 39);
            this.SetExportPathButton.TabIndex = 15;
            this.SetExportPathButton.Text = "Set Export Path";
            this.SetExportPathButton.UseVisualStyleBackColor = true;
            this.SetExportPathButton.Click += new System.EventHandler(this.SetExportPathButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExportPathTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EditEmployeeButton);
            this.groupBox1.Controls.Add(this.EditAttendTypeButton);
            this.groupBox1.Controls.Add(this.SetExportPathButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.TargetAttendDateTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(139, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 158);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // ExportPathTextBox
            // 
            this.ExportPathTextBox.Enabled = false;
            this.ExportPathTextBox.Location = new System.Drawing.Point(120, 130);
            this.ExportPathTextBox.Name = "ExportPathTextBox";
            this.ExportPathTextBox.Size = new System.Drawing.Size(200, 20);
            this.ExportPathTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "导出路径：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResultText);
            this.groupBox2.Location = new System.Drawing.Point(139, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 160);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SIAPMAttend.Properties.Resources.logo;
            this.pictureBox1.Image = global::SIAPMAttend.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Attend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CheckExceptionAttendButton);
            this.Controls.Add(this.generateLicenseKeyButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attend";
            this.Text = "SIAPM Attend Form";
            this.Load += new System.EventHandler(this.Attend_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox ResultText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TargetAttendDateTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button generateLicenseKeyButton;
        private System.Windows.Forms.Button CheckExceptionAttendButton;
        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.Button EditAttendTypeButton;
        private System.Windows.Forms.Button SetExportPathButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ExportPathTextBox;
        private System.Windows.Forms.Label label3;
    }
}

