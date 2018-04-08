using EasyLicense.Lib;
using EasyLicense.Lib.License;
using EasyLicense.Lib.License.Validator;
using SIAPM.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAPMAttend
{
    public partial class Attend : Form
    {
        public Attend()
        {
            InitializeComponent();
            //countManager.Initialize(new Dictionary<string, int>()
            //{
            //    {"ButtonClick", 3}
            //});

            //countManager.ExceedLimitation += CountManager_ExceedLimitation;
        }
        //private static CountManager countManager = new CountManager();

        //private void CountManager_ExceedLimitation(string obj)
        //{
        //    if (Validation() == false)
        //    {
        //        MessageBox.Show("No license provided");
        //    }
        //}

        private bool Validation()
        {
            var keyFile = "publicKey.xml";
            string publicKey = "";
            if (File.Exists(keyFile))
            {
                publicKey = File.ReadAllText(keyFile);
            }

            var licenseValidator = new LicenseValidator(publicKey, "license.lic");
            try
            {
                licenseValidator.AssertValidLicense();

                var log =$"{licenseValidator.Name} authorized License to {licenseValidator.LicenseAttributes["name"]}\n";
                this.Text = "SIAPM Attend Form authorized"; 
                LogHelper.Info(log);
                ResultText.AppendText(log);
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error("Validation", ex);
                ResultText.AppendText("No license provided or validation is failed.\n");
            }

            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation() == false)
            {
                MessageBox.Show("No license provided\n");
                return;
            }
            if (targetDate.CompareTo(default(DateTime))==0)
            {
                MessageBox.Show("please set target time", "Attend log", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var fName = openFileDialog1.FileName;

                    Utils.CalucateEmployeAttendence(fName, targetDate);
                    MessageBox.Show("Successful imported.", "Attend log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch(Exception ex)
            {
                ResultText.AppendText(ex.Message);
            }
            
        }
        private DateTime targetDate = DateTime.Now;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            targetDate = dateTimePicker1.Value;
            TargetAttendDateTextBox.Text = targetDate.ToShortDateString();
        }

        private void Attend_Load(object sender, EventArgs e)
        {
            //generateKeys(true);
            //try
            //{
            //    Validation();
            //}
            //catch (Exception ex)
            //{
            //    ResultText.AppendText("No license provided or validation is failed.\n");
            //}

            Utils.initilizeOrReloadByLinq();
            TargetAttendDateTextBox.Text = targetDate.ToShortDateString();
            ExportPathTextBox.Text = Utils.getExportPath();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.button1_Click(null, null);
            MessageBox.Show("Office Excel");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utils.ExcelLibraryTest();
            MessageBox.Show("Excel Liberay");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Utils.ExcelPackageTest();
            MessageBox.Show("EPPlus Excel Liberay");
        }

        private void generateKeys(bool isLoad = false)
        {
            if (File.Exists("privateKey.xml") || File.Exists("publicKey.xml"))
            {
                if (isLoad == false)
                {
                    var result = MessageBox.Show("The key is existed, override it?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            var privateKey = "";
            var publicKey = "";
            LicenseGenerator.GenerateLicenseKey(out privateKey, out publicKey);

            File.WriteAllText("privateKey.xml", privateKey);
            File.WriteAllText("publicKey.xml", publicKey);

            ResultText.AppendText("The Key is created, please backup it.\n");
        }

        private void generateLicenseKeyButton_Click(object sender, EventArgs e)
        {
            generateKeys();
        }

        private void CheckExceptionAttendButton_Click(object sender, EventArgs e)
        {
            if (Validation() == false)
            {
                MessageBox.Show("No license provided.\n");
                return;
            }
            if (targetDate.CompareTo(default(DateTime)) == 0)
            {
                MessageBox.Show("please set target time", "Attend log", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var fName = openFileDialog1.FileName;

                    Utils.CheckExceptionAttendence(fName, targetDate);
                    MessageBox.Show("Successful checked attend log.", "Attend log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                ResultText.AppendText(ex.Message);
            }
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeesForm theFrom = new EmployeesForm();
            theFrom.ShowDialog();

        }

        private void SetExportPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog theBrowser = new FolderBrowserDialog();
            if(theBrowser.ShowDialog() == DialogResult.OK)
            {
                var selectedPath = theBrowser.SelectedPath;
                Utils.setExportPath(selectedPath);
                ExportPathTextBox.Text = selectedPath;
            }
        }

        private void EditAttendTypeButton_Click(object sender, EventArgs e)
        {
            //todo
            //MessageBox.Show("TODO!");
            AttendTypeForm attendTypeForm = new AttendTypeForm();
            attendTypeForm.ShowDialog();
        }
    }
}
