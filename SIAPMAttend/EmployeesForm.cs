using SIAPM.Entities;
using SIAPM.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
//using System.Xml;

namespace SIAPMAttend
{
    public enum TranslateFromEnum
    {
        Undefined = 0,
        MandarinToEnglish = 1,
        EnglishToMandarin = 2
    }

    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        #region "Field"
        private string targetPath;
        private string sourcePath;
        private XmlDocument targetDoc;
        private XmlDocument sourceDoc;
        private List<string> IDList;
        //private List<int> rowIndexCellChangedList;
        private string log;
        private TranslateFromEnum translateOrientation;
        private bool isImported = false;
        private static readonly string[] ENTITY_SUBS = new string[] { "&amp;", "&apos;", "&quot;", "&gt;", "&lt;" };
        private static readonly string[] REPLACE_STRS = new string[] { "&", "'", "\"", ">", "<" };
        private string oldTranslateString;
        private string newTranslateString;
        private const int EMPTYCRITERIALENGTH = 8;
        private Dictionary<string, string> criteriaDic = new Dictionary<string, string>();
        private string selectedAttendType = "";
        private int age = -1;
        private bool gender = false;
        private Employee currentEmployee;
        #endregion

        #region "Handler Method"

        private void OpenTargetTranslateXMLButton_Click(object sender, EventArgs e)
        {
            if (TargetTranslateXMLopenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                targetPath = TargetTranslateXMLopenFileDialog.FileName.ToString();
                string targetName = targetPath.Substring(targetPath.LastIndexOf("\\") + 1);
                log = "Target Path: " + targetPath + Environment.NewLine +
                    "Target Name: " + targetName + Environment.NewLine;
                
                //LogHandler.DefaultLogHandler().log(log);
            }
        }

        private void OpenSourceTranslateXMLButton_Click(object sender, EventArgs e)
        {
            if (SourceTranslateXMLopenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourcePath = SourceTranslateXMLopenFileDialog.FileName.ToString();
                string sourceName = sourcePath.Substring(sourcePath.LastIndexOf("\\") + 1);
                log = "Source Path" + sourcePath + Environment.NewLine +
                    "Source Name" + sourceName + Environment.NewLine;
               
                //LogHandler.DefaultLogHandler().log(log);
            }
        }


        private void OverrideButton_Click(object sender, EventArgs e)
        {
            
            string tarID = "";
            string tarLabel = "";
            XmlElement targetElement;
            XmlElement sourceElement;
            XmlNodeList sourceElements;
            string srcLabel = "";
            string srcOrgText = "";
            string srcInnerText = "";
            //load source Doc
            sourceDoc = new XmlDocument();
            sourceDoc.Load(sourcePath);
            try
            {

                foreach (DataGridViewRow theText in this.ToTranslatedataGridView.Rows)
                {
                    targetElement = null;
                    sourceElement = null;
                    srcLabel = "";
                    srcOrgText = "";
                    srcInnerText = "";

                    if (theText.Cells[0].Value == null)
                    {

                        log = "The end. " + Environment.NewLine;
                        
                        //LogHandler.DefaultLogHandler().log(log);
                    }
                    else
                    {
                        tarID = theText.Cells["ID"].Value.ToString();
                        tarLabel = theText.Cells["Label"].Value.ToString();
                        //query by target id in source nodes and target nodes
                        string xPath = "//Text[@id='" + tarID + "']";
                        targetElement = (XmlElement)(targetDoc.SelectSingleNode(xPath));
                        sourceElement = (XmlElement)(sourceDoc.SelectSingleNode(xPath));
                        //To find all elements in source
                        sourceElements = sourceDoc.SelectNodes(xPath);
                        if (sourceElement == null)
                        {
                            log = "not existed id: " + tarID + " in source file." + Environment.NewLine;
                           
                            //LogHandler.DefaultLogHandler().log(log);
                            continue;
                        }
                        else
                        {


                            if (translateOrientation == TranslateFromEnum.EnglishToMandarin)
                            {
                                bool hasFound = false;
                                foreach (XmlNode theNode in sourceElements)
                                {
                                    XmlElement theElement = (XmlElement)theNode;
                                    //get attributes of source element
                                    srcLabel = theElement.GetAttribute("label");
                                    srcOrgText = theElement.GetAttribute("OriginalText");
                                    srcInnerText = theElement.InnerText;

                                    if (srcLabel == tarLabel)
                                    {

                                        //if label not match replace values and translated text
                                        targetElement.SetAttribute("label", srcLabel);
                                        targetElement.SetAttribute("OriginalText", srcOrgText);
                                        targetElement.InnerText = srcInnerText;

                                        //update the DataGridView
                                        theText.Cells["TranslateText"].Value = srcInnerText;

                                        hasFound = true;
                                        break;
                                    }
                                }
                                if (hasFound == false)
                                {
                                    log = "Don't find the matched label: " + tarLabel + " for ID: " + tarID + "in source doc" + Environment.NewLine;
                                  
                                    //LogHandler.DefaultLogHandler().log(log);
                                }
                                else
                                {
                                    log = "Find the matched ID and label in source doc.ID: " + tarID + Environment.NewLine;
                                   
                                    //LogHandler.DefaultLogHandler().log(log);
                                }

                            }
                            else
                            {
                                //Default translateOrientation = TranslateFromEnum.MandarinToEnglish
                                //get attributes of source element
                                srcLabel = sourceElement.GetAttribute("label");
                                srcOrgText = sourceElement.GetAttribute("OriginalText");
                                srcInnerText = sourceElement.InnerText;

                                if (srcLabel != tarLabel)
                                {
                                    //if label not match replace values and translated text
                                    targetElement.SetAttribute("label", srcLabel);
                                    targetElement.SetAttribute("OriginalText", srcOrgText);
                                    targetElement.InnerText = srcInnerText;

                                    //update the DataGridView
                                    theText.Cells["Label"].Value = srcLabel;
                                    theText.Cells["OrgText"].Value = srcOrgText;
                                    theText.Cells["TranslateText"].Value = srcInnerText;
                                }
                            }


                        }
                    }
                }
                SaveButton.Enabled = true;

            }
            catch (Exception ex)
            {
                log = ex.ToString() + Environment.NewLine;
               
                //LogHandler.DefaultLogHandler().log(log);
            }
        }

        private void MBTranslator_Load(object sender, EventArgs e)
        {
            //test
            //targetPath = "C:\\Allen\\Projects\\Eastcom Peace1\\普通话\\普通话_ErrorTexts.xml";
            //sourcePath = "C:\\Allen\\Projects\\Eastcom Peace1\\English\\English_ErrorTexts.xml";
            //rowIndexCellChangedList = new List<int>();
            //Initialize the Translate Com box
            //TranslateFromComboBox.Items.Clear();
            //TranslateFromComboBox.Items.Add(TranslateFromEnum.MandarinToEnglish);
            //TranslateFromComboBox.Items.Add(TranslateFromEnum.EnglishToMandarin);

            //load employees
            updateDataGridView();
            loadAttendType();
            //criteriaDic.Add("id", "");
            //criteriaDic.Add("label", "");
            //criteriaDic.Add("OriginalText", "");
            //criteriaDic.Add("innerTex", "");
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            targetDoc = new XmlDocument();
            targetDoc.Load(targetPath);

            //string xPath = "//Text[contains(text(),'controlling') and contains(@OriginalText,\"Check job's configuration.\") and contains(@label,'WSPMSG')]";
            string xPath = "//Text[contains(@OriginalText,\"Check job's configuration.\")]";
            XmlElement targetRootElem = targetDoc.DocumentElement;

            XmlNodeList targetTextNodes;
            targetTextNodes = targetRootElem.SelectNodes(xPath);
            this.ToTranslatedataGridView.Rows.Clear();
            //XmlNodeList sourceTextNodes = sourceRootElem.GetElementsByTagName("Text");

            int index = 0;
            foreach (XmlNode node in targetTextNodes)
            {
                XmlElement targetElement = (XmlElement)node;
                string strID = targetElement.GetAttribute("id");   //get the value of attribute "id"  
                string strLabel = targetElement.GetAttribute("label");   //get the value of attribute "label"  
                string strOrgText = targetElement.GetAttribute("OriginalText");
                string strInnerText = targetElement.InnerText;
               
                index = this.ToTranslatedataGridView.Rows.Add();

                this.ToTranslatedataGridView.Rows[index].Cells["ID"].Value = strID;

                this.ToTranslatedataGridView.Rows[index].Cells["Label"].Value = strLabel;

                this.ToTranslatedataGridView.Rows[index].Cells["OrgText"].Value = strOrgText;

                this.ToTranslatedataGridView.Rows[index].Cells["TranslateText"].Value = strInnerText;

                if (isImported == false)
                {
                    log = "Imported ID: " + strID + Environment.NewLine;
                    
                    //LogHandler.DefaultLogHandler().log(log);
                }


            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            //string strID = "";
            //string innerText;
            //XmlElement translateElement;
            //List<int> toDeleteList = new List<int>();
            //save the translate text to the targetDoc
            try
            {


                if (currentEmployee != null)
                {
                    Utils.updateEmployee(currentEmployee);
                    updateDataGridView();
                    SaveButton.Enabled = false;
                    MessageBox.Show("Update successfully.");
                }
                //LogHandler.DefaultLogHandler().log(log);

            }
            catch (Exception ex)
            {
                log = ex.ToString() + Environment.NewLine;
               
                //LogHandler.DefaultLogHandler().log(log);
            }
        }

        private bool checkNewEmployee()
        {
            if (string.IsNullOrEmpty(EmployeeIDTextBox.Text))
            {
                MessageBox.Show("Please enter employee ID!");
                return false;
            }
            if (string.IsNullOrEmpty(EmployeeNameTextBox.Text))
            {
                MessageBox.Show("Please enter employee Name!");
                return false;
            }
            if (string.IsNullOrEmpty(selectedAttendType))
            {
                MessageBox.Show("Please select attendtype!");
                return false;
            }
            if (!int.TryParse(AgeTextBox.Text, out age))
            {
                MessageBox.Show("Please enter correct number for age!");
                return false;
            }
            if (!bool.TryParse(GenderTextBox.Text, out gender))
            {
                MessageBox.Show("Please enter true or false for gender!");
                return false;
            }
            return true;
        }

        private void ImportTranslationButton_Click(object sender, EventArgs e)
        {
            try
            {
                targetDoc = new XmlDocument();
                targetDoc.Load(targetPath);

                updateDataGridView(null);
                SaveButton.Enabled = true;


                //sourceDoc = new XmlDocument();
                //sourceDoc.Load(sourcePath);
                //IDList = new List<string>();
                //List<XmlNode> duplicateElems = new List<XmlNode>();


                //XmlReaderSettings settings = new XmlReaderSettings();

                //settings.IgnoreComments = true;//ignore the comment

                ////get target root
                //XmlElement targetRootElem = targetDoc.DocumentElement;
                ////get source root
                //XmlElement sourceRootElem = sourceDoc.DocumentElement;

                ////get all text nodes
                //XmlNodeList targetTextNodes = targetRootElem.GetElementsByTagName("Text");
                ////XmlNodeList sourceTextNodes = sourceRootElem.GetElementsByTagName("Text");

                //int index = 0;
                //foreach (XmlNode node in targetTextNodes)
                //{
                //    XmlElement targetElement = (XmlElement)node;
                //    string strID = targetElement.GetAttribute("id");   //get the value of attribute "id"  
                //    string strLabel = targetElement.GetAttribute("label");   //get the value of attribute "label"  
                //    string strOrgText = targetElement.GetAttribute("OriginalText");
                //    string strInnerText = targetElement.InnerText;
                //    if (IDList.IndexOf(strID) == -1)
                //    {
                //        //it is a new line, add it to IDlist and add it to show list
                //        IDList.Add(strID);
                //        index = this.ToTranslatedataGridView.Rows.Add();

                //        this.ToTranslatedataGridView.Rows[index].Cells["ID"].Value = strID;

                //        this.ToTranslatedataGridView.Rows[index].Cells["Label"].Value = strLabel;

                //        this.ToTranslatedataGridView.Rows[index].Cells["OrgText"].Value = strOrgText;

                //        this.ToTranslatedataGridView.Rows[index].Cells["TranslateText"].Value = strInnerText;

                //        log = "Imported ID: " + strID + Environment.NewLine;
                //        ResultTextBox.AppendText(log);
                //        LogHandler.DefaultLogHandler().log(log);
                //    }
                //    else
                //    {
                //        //The id should be unique
                //        if (duplicateElems.IndexOf(node) == -1)
                //        {
                //            duplicateElems.Add(node);
                //        }                     
                //    } 
                //}
                ////delete duplicate element
                //foreach (XmlNode deleteNode in duplicateElems)
                //{
                //    string strID = ((XmlElement)deleteNode).GetAttribute("id");

                //    targetRootElem.RemoveChild(deleteNode);
                //    log = "Deleted element: " + strID + Environment.NewLine;
                //    ResultTextBox.AppendText(log);
                //    LogHandler.DefaultLogHandler().log(log);
                //}


                //duplicateElems = null;

            }
            catch (Exception ex)
            {
                log = ex.ToString() + Environment.NewLine;
              
                //LogHandler.DefaultLogHandler().log(log);
            }


        }

        private void ToTranslatedataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            DataGridViewRow theRow = this.ToTranslatedataGridView.Rows[rowIndex];
            if (theRow.Cells[columnIndex].Value != null)
            {
                newTranslateString = theRow.Cells[columnIndex].Value.ToString();
            }
            if (!string.IsNullOrEmpty(newTranslateString) &&
                    !string.IsNullOrEmpty(oldTranslateString) &&
                    newTranslateString != oldTranslateString)
            {
                //if (rowIndexCellChangedList.IndexOf(rowIndex) == -1)
                //{
                //    rowIndexCellChangedList.Add(rowIndex);
                //}
                //save the text to doc
                string strID = this.ToTranslatedataGridView.Rows[rowIndex].Cells["ID"].Value.ToString();
                string xPath = "//Text[@id='" + strID + "']";
                XmlElement theElement = (XmlElement)targetDoc.SelectSingleNode(xPath);
                theElement.InnerText = newTranslateString;

                log = "edited row index: " + rowIndex + " ID: " + strID + 
                    Environment.NewLine +
                    "Old value: " + oldTranslateString +
                    Environment.NewLine +
                    "New value: " + newTranslateString + 
                    Environment.NewLine;
                
                //LogHandler.DefaultLogHandler().log(log);
            }

        }

        private void TranslateFromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //translateOrientation = (TranslateFromEnum)Enum.Parse(typeof(TranslateFromEnum), TranslateFromComboBox.Text);

        }

        private void MBTranslator_Resize(object sender, EventArgs e)
        {

        }

        private void MBTranslator_FormClosing(object sender, FormClosingEventArgs e)
        {
            log = "Form has been closed" + Environment.NewLine;
           
            //LogHandler.DefaultLogHandler().log(log);
        }

        private void ToTranslatedataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            DataGridViewRow theRow = this.ToTranslatedataGridView.Rows[rowIndex];
            if (theRow.Cells[columnIndex].Value != null)
            {
                oldTranslateString = theRow.Cells[columnIndex].Value.ToString();
                //log = "Original string: " + oldTranslateString + Environment.NewLine;
                //ResultTextBox.AppendText(log);
                //LogHandler.DefaultLogHandler().log(log);
            }


        }
        private void IDCriteriaText_TextChanged(object sender, EventArgs e)
        {
            string criteriaString = IDCriteriaText.Text;

            updateDataGridView(criteriaString, "id");
        }

        private void LabelCriteriaText_TextChanged(object sender, EventArgs e)
        {
            string criteriaString = LabelCriteriaText.Text;

            updateDataGridView(criteriaString, "label");
        }

        private void OrgTextCriteriaText_TextChanged(object sender, EventArgs e)
        {
            //string criteriaString = OrgTextCriteriaText.Text;

            //updateDataGridView(criteriaString, "OriginalText");
        }

        private void TranslateTextCriteriaText_TextChanged(object sender, EventArgs e)
        {
            //string criteriaString = TranslateTextCriteriaText.Text;

            //updateDataGridView(criteriaString);
        }
        #endregion


        #region "Private Method"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text">original string</param>
        /// <returns>keep entity string</returns>
        private string GetKeepEntityString(string text)
        {
            string keepEntityString = text;
            for (int i = 0; i < REPLACE_STRS.Length; i++)
            {
                keepEntityString = keepEntityString.Replace(REPLACE_STRS[i], ENTITY_SUBS[i]);
            }
            return keepEntityString;
        }

        /// <summary>
        /// Only need to convert the "'" substring for xPath
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string GetKeepEscapeString(string text)
        {
            //REPLACE_STRS[1] = "'"
            int index = text.IndexOf(REPLACE_STRS[1]);
            if (index != -1)
            {
                text = "\"" + text + "\"";
            }
            else
            {
                text = "\'" + text + "\'";
            }
            //text = text.Replace(REPLACE_STRS[1], "\'");
            return text;
        }
        /// <summary>
        /// to keep character like "&apos;t" in the XML file.
        /// Not to parse
        /// </summary>
        private void keepEntity()
        {
            targetDoc = new XmlDocument();
            targetDoc.Load(targetPath);
            //targetPath = "C:\\Allen\\Projects\\Eastcom Peace1\\普通话\\普通话_ErrorTexts1.xml";

            XmlWriterSettings setting = new XmlWriterSettings();
            setting.Indent = true;
            setting.IndentChars = "\t";
            setting.Encoding = Encoding.Unicode;
            using (XmlWriter writer = XmlWriter.Create(targetPath, setting))
            {
                writer.WriteStartDocument(false);
                //writer.WriteStartElement("Bundle");
                writer.WriteStartElement("xsi", "Bundle", "http://www.w3.org/2001/XMLSchema-instance");
                //writer.WriteAttributeString("xmlns", "http://www.w3.org/2001/XMLSchema-instance");
                writer.WriteAttributeString("info", "Bundle");
                XmlNodeList targetTextNodes = targetDoc.GetElementsByTagName("Text");
                foreach (XmlNode node in targetTextNodes)
                {
                    XmlElement targetElement = (XmlElement)node;
                    string strID = targetElement.GetAttribute("id");   //get the value of attribute "id"  
                    string strLabel = targetElement.GetAttribute("label");   //get the value of attribute "label"  
                    string strOriginalText = targetElement.GetAttribute("OriginalText");   //get the value of attribute "OriginalText"  
                    string strInnerText = targetElement.InnerText;
                    //convert to "keep entity string"
                    strOriginalText = GetKeepEntityString(strOriginalText);
                    strInnerText = GetKeepEntityString(strInnerText);


                    writer.WriteStartElement("Text");
                    writer.WriteAttributeString("id", strID);
                    writer.WriteAttributeString("label", strLabel);
                    writer.WriteAttributeString("length", "");
                    //write attribute with no parse string
                    writer.WriteStartAttribute("OriginalText");
                    writer.WriteRaw(strOriginalText);
                    writer.WriteEndAttribute();
                    //write inner text with no parse string
                    writer.WriteRaw(strInnerText);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();

            }
        }
        private void updateDataGridView()
        {
            this.ToTranslatedataGridView.Rows.Clear();
            
            int index = 0;
            foreach (var employee in Utils.getEmployees())
            {

                index = this.ToTranslatedataGridView.Rows.Add();

                this.ToTranslatedataGridView.Rows[index].Cells["EmployeeID"].Value = employee.EmployeeID;

                this.ToTranslatedataGridView.Rows[index].Cells["EmployeeName"].Value = employee.Name;

                this.ToTranslatedataGridView.Rows[index].Cells["Age"].Value = employee.Age;

                this.ToTranslatedataGridView.Rows[index].Cells["AttendType"].Value = employee.AttendType.Name;

                this.ToTranslatedataGridView.Rows[index].Cells["Gender"].Value = employee.Gender.ToString();
                
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="criteriaString"></param>
        /// <param name="attributeName"></param>
        private void updateDataGridView(string criteriaString, string attributeName = "")
        {
            try
            {
                if (targetDoc == null)
                {
                    log = "Doc hasn't been imported " + Environment.NewLine;
                   
                    //LogHandler.DefaultLogHandler().log(log);
                    return;
                }
                IDList = new List<string>();
                List<XmlNode> duplicateElems = new List<XmlNode>();


                XmlReaderSettings settings = new XmlReaderSettings();

                settings.IgnoreComments = true;//ignore the comment

                //get target root
                XmlElement targetRootElem = targetDoc.DocumentElement;

                XmlNodeList targetTextNodes;


                //get all text nodes
                if (criteriaString != null)
                {
                    string partPath = "";
                    string key = "";
                    //Define the key
                    if (string.IsNullOrEmpty(attributeName))
                    {
                        key = "innerTex";

                    }
                    else
                    {
                        key = attributeName;
                    }
                    //whether the criteria is empty
                    if (criteriaString == "")
                    {
                        criteriaDic.Remove(key);
                    }
                    else
                    {
                        criteriaString = GetKeepEscapeString(criteriaString);
                        //for innerText is the text, not the attribute
                        if (string.IsNullOrEmpty(attributeName))
                        {

                            partPath = "contains(text()," + criteriaString + ")";
                        }
                        else
                        {
                            partPath = "contains(@" + attributeName + "," + criteriaString + ")";
                        }
                        //fill into the dictionary
                        if (criteriaDic.ContainsKey(key))
                        {
                            criteriaDic[key] = partPath;
                        }
                        else
                        {
                            criteriaDic.Add(key, partPath);
                        }



                    }
                    if (criteriaDic.Count == 0)
                    {
                        targetTextNodes = targetRootElem.GetElementsByTagName("Text");
                    }
                    else
                    {
                        targetTextNodes = targetRootElem.SelectNodes(getCriteriaString(criteriaDic));
                    }

                }
                else
                {
                    //First time to import the XML doc
                    targetTextNodes = targetRootElem.GetElementsByTagName("Text");
                }
                this.ToTranslatedataGridView.Rows.Clear();
                //XmlNodeList sourceTextNodes = sourceRootElem.GetElementsByTagName("Text");

                int index = 0;
                foreach (XmlNode node in targetTextNodes)
                {
                    XmlElement targetElement = (XmlElement)node;
                    string strID = targetElement.GetAttribute("id");   //get the value of attribute "id"  
                    string strLabel = targetElement.GetAttribute("label");   //get the value of attribute "label"  
                    string strOrgText = targetElement.GetAttribute("OriginalText");
                    string strInnerText = targetElement.InnerText;
                    if (IDList.IndexOf(strID) == -1)
                    {
                        //it is a new line, add it to IDlist and add it to show list
                        IDList.Add(strID);
                        index = this.ToTranslatedataGridView.Rows.Add();

                        this.ToTranslatedataGridView.Rows[index].Cells["ID"].Value = strID;

                        this.ToTranslatedataGridView.Rows[index].Cells["Label"].Value = strLabel;

                        this.ToTranslatedataGridView.Rows[index].Cells["OrgText"].Value = strOrgText;

                        this.ToTranslatedataGridView.Rows[index].Cells["TranslateText"].Value = strInnerText;

                        if (isImported == false)
                        {
                            log = "Imported ID: " + strID + Environment.NewLine;
                          
                            //LogHandler.DefaultLogHandler().log(log);
                        }
                    }
                    else
                    {
                        //The id should be unique
                        if (duplicateElems.IndexOf(node) == -1)
                        {
                            duplicateElems.Add(node);
                        }
                    }
                }
                //It is the first time to import. After this, do not log
                if (criteriaString == null)
                {
                    isImported = true;
                }
                //delete duplicate element
                foreach (XmlNode deleteNode in duplicateElems)
                {
                    string strID = ((XmlElement)deleteNode).GetAttribute("id");

                    targetRootElem.RemoveChild(deleteNode);
                    log = "Deleted element: " + strID + Environment.NewLine;
                  
                }


                duplicateElems = null;

            }
            catch (Exception ex)
            {
                log = ex.ToString() + Environment.NewLine;
               
            }


        }
        private void loadAttendType()
        {
            AttendTypeComboBox.Items.Clear();
            CurAttendTypeComboBox.Items.Clear();
            foreach (var attendType in Utils.getAttendTypes())
            {
                CurAttendTypeComboBox.Items.Add(attendType.Name);
                AttendTypeComboBox.Items.Add(attendType.Name);

            }
        }
        /// <summary>
        /// There is four type text to criteria
        /// id,attribute
        /// label,attribute
        /// OriginalText,attribute
        /// innerText, this is the value between the text tag
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        private string getCriteriaString(Dictionary<string, string> dic)
        {
            StringBuilder criteriaPath = new StringBuilder();
            criteriaPath.Append("//Text[");
            criteriaPath.Append("]");
            foreach (string value in dic.Values)
            {
                string partPath = value;
                if (criteriaPath.Length > EMPTYCRITERIALENGTH)
                {
                    partPath = " and " + value;
                    criteriaPath.Insert(criteriaPath.Length - 1, partPath);
                }
                else
                {
                    criteriaPath.Insert(EMPTYCRITERIALENGTH - 1, partPath);
                }
            }
            return criteriaPath.ToString();

        }







        #endregion

        private void AttendTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAttendType = AttendTypeComboBox.Text;

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            if (checkNewEmployee())
            {
                var attendType = Utils.getAttendType(selectedAttendType);
                Employee newEmployee = new Employee()
                {
                    EmployeeID = EmployeeIDTextBox.Text,
                    Name = EmployeeNameTextBox.Text,
                    Age = age,
                    Gender = gender,
                    AttendType = attendType
                };
                Utils.addEmployee(newEmployee);
                updateDataGridView();
            }
        }

        private void ToTranslatedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            DataGridViewRow theRow = this.ToTranslatedataGridView.Rows[rowIndex];
            string employeeID = theRow.Cells[0].Value.ToString();

            updateCurEmployee(employeeID);

            //int rowIndex = e.RowIndex;
            //int columnIndex = e.ColumnIndex;
            //DataGridViewRow theRow = this.ToTranslatedataGridView.Rows[rowIndex];
            //MessageBox.Show(theRow.Cells[0].Value.ToString());
            //if (theRow.Cells[0].Value != null)
            //{
            //    MessageBox.Show(theRow.Cells[0].Value.ToString());
            //    //oldTranslateString = theRow.Cells[columnIndex].Value.ToString();
            //    //log = "Original string: " + oldTranslateString + Environment.NewLine;
            //    //ResultTextBox.AppendText(log);
            //    //LogHandler.DefaultLogHandler().log(log);
            //}
        }

        private void ToTranslatedataGridView_Click(object sender, EventArgs e)
        {

        }
        private void updateCurEmployee(string employeeID)
        {
            currentEmployee = Utils.getEmployee(employeeID);
            CurEmployeeIDTextBox.Text = currentEmployee.EmployeeID;
            CurEmployeeNameTextBox.Text = currentEmployee.Name;
            CurEmployeeAgeTextBox.Text = currentEmployee.Age.ToString();
            CurEmployeeGenderTextBox.Text = currentEmployee.Gender.ToString();
            CurEmployeeAttendTypeTextBox.Text = currentEmployee.AttendType.Name;
        }
        private void ToTranslatedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            DataGridViewRow theRow = this.ToTranslatedataGridView.Rows[rowIndex];
            string employeeID = theRow.Cells[0].Value.ToString();

            updateCurEmployee(employeeID);
            //if (theRow.Cells[0].Value != null)
            //{
            //    MessageBox.Show(theRow.Cells[0].Value.ToString());
            //    //oldTranslateString = theRow.Cells[columnIndex].Value.ToString();
            //    //log = "Original string: " + oldTranslateString + Environment.NewLine;
            //    //ResultTextBox.AppendText(log);
            //    //LogHandler.DefaultLogHandler().log(log);
            //}
        }

        private void CurEmployeeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            currentEmployee.Name = CurEmployeeNameTextBox.Text.Trim();

            SaveButton.Enabled = true;
        }

        private void CurEmployeeAgeTextBox_TextChanged(object sender, EventArgs e)
        {
            int age = -1;
            if(int.TryParse(CurEmployeeAgeTextBox.Text,out age))
            {
                currentEmployee.Age = age;
                SaveButton.Enabled = true;
            }
            
        }

        private void CurAttendTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var theAttendTypeStr = CurAttendTypeComboBox.Text;
            var attendType = Utils.getAttendType(theAttendTypeStr);
            if(attendType != null)
            {
                currentEmployee.AttendType = attendType;
                SaveButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("could not found attendType");
            }
           
        }

        private void CurEmployeeGenderTextBox_TextChanged(object sender, EventArgs e)
        {
            bool gender = false;
            if (bool.TryParse(CurEmployeeGenderTextBox.Text, out gender))
            {
                currentEmployee.Gender = gender;
                SaveButton.Enabled = true;
            }
            SaveButton.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (currentEmployee != null)
            {
                Utils.deleteEmployee(currentEmployee.EmployeeID);
                updateDataGridView();
                CurEmployeeIDTextBox.Text = "";
                CurEmployeeAgeTextBox.Text = "";
                CurEmployeeGenderTextBox.Text = "";
                CurEmployeeNameTextBox.Text = "";
                CurEmployeeAttendTypeTextBox.Text = "";
                currentEmployee = null;
                MessageBox.Show("Delete successfully.");
            }
        }
    }
}
