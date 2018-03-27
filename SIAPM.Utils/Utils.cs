using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using SIAPM.Entities;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Xml;
using ExcelLibrary.SpreadSheet;
using OfficeOpenXml;
using System.Xml.Linq;

namespace SIAPM.Utils
{
    public class Utils
    {
        private static List<Employee> employees = new List<Employee>();
        private static List<AttendType> attendTypes = new List<AttendType>();
        public static string RawDataFile { get; set; } = "C:\\temp\\attendlog.txt";
        public static string exportPath = "c:\\temp";
        //private static XmlDocument employeeDoc;
        //private static string sourcePath = "Employees.xml";
        //XmlNodeList static sourceElements;
        //private static XmlDocument configDoc;
        private static string sourcePath = Environment.CurrentDirectory + "\\config.xml";
        private static XDocument xConfigdoc;
        private static XElement xeleAttendTypes;
        private static XElement xeleEmployees;
        private static XElement xExportFolderElement;
        public static void initilizeOrReloadByLinq()
        {
            xConfigdoc = XDocument.Load(sourcePath);
            XElement xeleRoot = xConfigdoc.Root;
            xeleAttendTypes = xeleRoot.Element("attendTypes");
            foreach (var xAttendType in xeleAttendTypes.Elements())
            {
                var Name = xAttendType.Attribute("Name").Value;

                var IsShiftStr = xAttendType.Attribute("IsShift").Value;
                bool IsShift = false;
                bool.TryParse(IsShiftStr, out IsShift);

                var TargetHourInStr = xAttendType.Attribute("TargetHourIn").Value;
                int TargetHourIn = 9;
                int.TryParse(TargetHourInStr, out TargetHourIn);

                var TargetMinuteInStr = xAttendType.Attribute("TargetMinuteIn").Value;
                int TargetMinuteIn = 0;
                int.TryParse(TargetMinuteInStr, out TargetMinuteIn);

                var ShiftTimeStr = xAttendType.Attribute("ShiftTime").Value;
                int ShiftTime = 0;
                int.TryParse(ShiftTimeStr, out ShiftTime);

                var StartDinnerBreakHourStr = xAttendType.Attribute("StartDinnerBreakHour").Value;
                int StartDinnerBreakHour = 0;
                int.TryParse(StartDinnerBreakHourStr, out StartDinnerBreakHour);

                var StartDinnerBreakMinuteStr = xAttendType.Attribute("StartDinnerBreakMinute").Value;
                int StartDinnerBreakMinute = 0;
                int.TryParse(StartDinnerBreakMinuteStr, out StartDinnerBreakMinute);

                var DinnerBreakMinuteStr = xAttendType.Attribute("DinnerBreakMinute").Value;
                int DinnerBreakMinute = 0;
                int.TryParse(DinnerBreakMinuteStr, out DinnerBreakMinute);

                var TempBreakMinuteStr = xAttendType.Attribute("TempBreakMinute").Value;
                int TempBreakMinute = 0;
                int.TryParse(TempBreakMinuteStr, out TempBreakMinute);

                AttendType attendType = new AttendType()
                {
                    Name = Name,
                    IsShift = IsShift,
                    TargetHourIn = TargetHourIn,
                    TargetMinuteIn = TargetMinuteIn,
                    ShiftTime = ShiftTime,

                    StartDinnerBreakHour = StartDinnerBreakHour,
                    StartDinnerBreakMinute = StartDinnerBreakMinute,
                    DinnerBreakMinute = DinnerBreakMinute,
                    TempBreakMinute = TempBreakMinute
                };
                attendTypes.Add(attendType);


            }

            xeleEmployees = xeleRoot.Element("employees");
            foreach(var xEmployee in xeleEmployees.Elements())
            {
                var EmployeeID = xEmployee.Attribute("EmployeeID").Value;
                var AttendTypeName = xEmployee.Attribute("AttendType").Value;
                var AgeStr = xEmployee.Attribute("Age").Value;
                int Age = 9;
                int.TryParse(AgeStr, out Age);

                var GenderStr = xEmployee.Attribute("Gender").Value; 
                bool Gender = true;
                bool.TryParse(GenderStr, out Gender);

                var Name = xEmployee.Attribute("Name").Value;
                var AttendType = attendTypes.Where(a => a.Name == AttendTypeName).FirstOrDefault();
                Employee employee = new Employee()
                {
                    EmployeeID = EmployeeID,
                    AttendType = AttendType,
                    Age = Age,
                    Gender = Gender,
                    Name = Name
                };
                employees.Add(employee);
            }

            xExportFolderElement = xeleRoot.Element("exportPath");
            exportPath = xExportFolderElement.Value;
        }
        //public static void initilizeOrReload()
        //{
        //    //loadAttendTypes();
        //    //loadEmployees();

        //    configDoc = new XmlDocument();
        //    sourcePath = Environment.CurrentDirectory + "\\config.xml";
        //    configDoc.Load(sourcePath);
        //    string xPath = "//attendType";
        //    var sourceElements = configDoc.SelectNodes(xPath);
        //    foreach (XmlNode theNode in sourceElements)
        //    {
        //        XmlElement theElement = (XmlElement)theNode;
        //        //get attributes of source element
        //        var Name = theElement.GetAttribute("Name");
        //        var IsShiftStr = theElement.GetAttribute("IsShift");
        //        bool IsShift = false;
        //        bool.TryParse(IsShiftStr, out IsShift);

        //        var TargetHourInStr = theElement.GetAttribute("TargetHourIn");
        //        int TargetHourIn = 9;
        //        int.TryParse(TargetHourInStr, out TargetHourIn);

        //        var TargetMinuteInStr = theElement.GetAttribute("TargetMinuteIn");
        //        int TargetMinuteIn = 0;
        //        int.TryParse(TargetMinuteInStr, out TargetMinuteIn);

        //        var ShiftTimeStr = theElement.GetAttribute("ShiftTime");
        //        int ShiftTime = 0;
        //        int.TryParse(ShiftTimeStr, out ShiftTime);

        //        AttendType attendType = new AttendType()
        //        {
        //            Name = Name,
        //            IsShift = IsShift,
        //            TargetHourIn = TargetHourIn,
        //            TargetMinuteIn = TargetMinuteIn,
        //            ShiftTime = ShiftTime
        //        };
        //        attendTypes.Add(attendType);
        //    }

        //    string xEmployeePath = "//employee";
        //    var sourceEmployeeElements = configDoc.SelectNodes(xEmployeePath);
        //    foreach (XmlNode theNode in sourceEmployeeElements)
        //    {
        //        XmlElement theElement = (XmlElement)theNode;
        //        //get attributes of source element
        //        var EmployeeID = theElement.GetAttribute("EmployeeID");
        //        var AttendTypeName = theElement.GetAttribute("AttendType");
        //        var AgeStr = theElement.GetAttribute("Age");
        //        int Age = 9;
        //        int.TryParse(AgeStr, out Age);

        //        var GenderStr = theElement.GetAttribute("Gender");
        //        bool Gender = true;
        //        bool.TryParse(GenderStr, out Gender);
        //        var Name = theElement.GetAttribute("Name");
        //        var AttendType = attendTypes.Where(a => a.Name == AttendTypeName).FirstOrDefault();
        //        Employee employee = new Employee()
        //        {
        //            EmployeeID = EmployeeID,
        //            AttendType = AttendType,
        //            Age = Age,
        //            Gender = Gender,
        //            Name = Name
        //        };
        //        employees.Add(employee);
        //    }
        //    string xExportFolderPath = "//exportPath";
        //    var sourceExportFolderElement = configDoc.SelectSingleNode(xExportFolderPath);
        //    exportPath = sourceExportFolderElement.InnerText;
            
        //}
        public static List<Employee> getEmployees()
        {
            return employees;
        }

        public static void addEmployee(Employee employee)
        {
            employees.Add(employee);
            //在已存在的节点上添加属性和数据  
            XElement xEmployee = new XElement("employee");
            xEmployee.SetAttributeValue("EmployeeID", employee.EmployeeID);
            xEmployee.SetAttributeValue("Age", employee.Age);
            xEmployee.SetAttributeValue("AttendType", employee.AttendType.Name);
            xEmployee.SetAttributeValue("Gender", employee.Gender.ToString());
            xEmployee.SetAttributeValue("Name", employee.Name);
            xeleEmployees.Add(xEmployee);
            xConfigdoc.Save(sourcePath);
        }
        public static void deleteEmployee(string emplpyeeID)
        {
            var theEmployee = employees.Where(e => e.EmployeeID == emplpyeeID).FirstOrDefault();
            if(theEmployee != null)
            {
                employees.Remove(theEmployee);
            }
            XElement xeleEmployee = xeleEmployees.Elements().Where(x => x.Attribute("EmployeeID").Value == emplpyeeID).Single(); //拉姆达表达式  
            xeleEmployee.Remove();

            xConfigdoc.Save(sourcePath);
        }
        public static void updateEmployee(Employee employee)
        {
            XElement xEmployee = xeleEmployees.Elements().Where(x => x.Attribute("EmployeeID").Value == employee.EmployeeID).Single(); //拉姆达表达式  
            xEmployee.SetAttributeValue("EmployeeID", employee.EmployeeID);
            xEmployee.SetAttributeValue("Age", employee.Age);
            xEmployee.SetAttributeValue("AttendType", employee.AttendType.Name);
            xEmployee.SetAttributeValue("Gender", employee.Gender.ToString());
            xEmployee.SetAttributeValue("Name", employee.Name);
            xConfigdoc.Save(sourcePath);
        }
        public static AttendType getAttendType(string attendTypeName)
        {          
            var attendType = attendTypes.Where(a => a.Name == attendTypeName).FirstOrDefault();
            return attendType;
        }
        public static Employee getEmployee(string employeeID)
        {
            var employee = employees.Where(a => a.EmployeeID == employeeID).FirstOrDefault();
            return employee;
        }
        public static List<AttendType> getAttendTypes()
        {
            return attendTypes;
        }
        public static void addAttendType(AttendType attendType)
        {
            //在已存在的节点上添加属性和数据  

            XElement xAttendType = new XElement("attendType");
            xAttendType.SetAttributeValue("Name", attendType.Name);
            xAttendType.SetAttributeValue("IsShift", attendType.IsShift);
            xAttendType.SetAttributeValue("TargetHourIn", attendType.TargetHourIn);
            xAttendType.SetAttributeValue("TargetMinuteIn", attendType.TargetMinuteIn);
            xAttendType.SetAttributeValue("ShiftTime", attendType.ShiftTime);

            xAttendType.SetAttributeValue("StartDinnerBreakHour", attendType.StartDinnerBreakHour);
            xAttendType.SetAttributeValue("StartDinnerBreakMinute", attendType.StartDinnerBreakMinute);
            xAttendType.SetAttributeValue("DinnerBreakMinute", attendType.DinnerBreakMinute);
            xAttendType.SetAttributeValue("TempBreakMinute", attendType.TempBreakMinute);
 
            xeleEmployees.Add(xAttendType);
            xConfigdoc.Save(sourcePath);
        }
        public static void deleteAttendType(string name)
        {
            var theAttendType = attendTypes.Where(e => e.Name == name).FirstOrDefault();
            if (theAttendType != null)
            {
                attendTypes.Remove(theAttendType);
            }
            XElement xeleAttendType = xeleAttendTypes.Elements().Where(x => x.Attribute("Name").Value == name).Single(); //拉姆达表达式  
            xeleAttendType.Remove();

            xConfigdoc.Save(sourcePath);
        }

        public static string getExportPath()
        {
            return exportPath;
        }
        public static void setExportPath(string newExportPath)
        {
            //string xExportFolderPath = "//exportPath";
            //var sourceExportFolderElement = configDoc.SelectSingleNode(xExportFolderPath);
            xExportFolderElement.Value = newExportPath;
            xConfigdoc.Save(sourcePath);
        }
        private static void loadAttendTypes()
        {
            var attendTypeDoc = new XmlDocument();
            var sourcePath = Environment.CurrentDirectory + "\\AttendTypes.xml";
            attendTypeDoc.Load(sourcePath);
            string xPath = "//attendType";
            var sourceElements = attendTypeDoc.SelectNodes(xPath);
            foreach (XmlNode theNode in sourceElements)
            {
                XmlElement theElement = (XmlElement)theNode;
                //get attributes of source element
                var Name = theElement.GetAttribute("Name");
                var IsShiftStr = theElement.GetAttribute("IsShift");
                bool IsShift = false;
                bool.TryParse(IsShiftStr, out IsShift);

                var TargetHourInStr = theElement.GetAttribute("TargetHourIn");
                int TargetHourIn = 9;
                int.TryParse(TargetHourInStr, out TargetHourIn);

                var TargetMinuteInStr = theElement.GetAttribute("TargetMinuteIn");
                int TargetMinuteIn = 0;
                int.TryParse(TargetMinuteInStr, out TargetMinuteIn);

                var ShiftTimeStr = theElement.GetAttribute("ShiftTime");
                int ShiftTime = 0;
                int.TryParse(ShiftTimeStr, out ShiftTime);

                AttendType attendType = new AttendType()
                {
                    Name = Name,
                    IsShift = IsShift,
                    TargetHourIn = TargetHourIn,
                    TargetMinuteIn = TargetMinuteIn,
                    ShiftTime = ShiftTime
                };
                attendTypes.Add(attendType);
            }
        }
        private static void loadEmployees()
        {

            var employeeDoc = new XmlDocument();
            var sourcePath = Environment.CurrentDirectory + "\\Employees.xml";
            employeeDoc.Load(sourcePath);
            string xPath = "//employee";
            var sourceElements = employeeDoc.SelectNodes(xPath);
            foreach (XmlNode theNode in sourceElements)
            {
                XmlElement theElement = (XmlElement)theNode;
                //get attributes of source element
                var EmployeeID = theElement.GetAttribute("EmployeeID");
                var AttendTypeName = theElement.GetAttribute("AttendType");
                var AgeStr = theElement.GetAttribute("Age");
                int Age = 9;
                int.TryParse(AgeStr, out Age);

                var GenderStr = theElement.GetAttribute("Gender");
                bool Gender = true;
                bool.TryParse(GenderStr, out Gender);
                var Name = theElement.GetAttribute("Name");
                var AttendType = attendTypes.Where(a => a.Name == AttendTypeName).FirstOrDefault();
                Employee employee = new Employee()
                {
                    EmployeeID = EmployeeID,
                    AttendType = AttendType,
                    Age = Age,
                    Gender = Gender,
                    Name = Name
                };
                employees.Add(employee);
            }
        }
        private static string checkFormatDatetime(string dateTimeString)
        {
            string formatedDatetime = dateTimeString;
            if (formatedDatetime.Length == 22)
            {
                return formatedDatetime;
            }
            //format datetime string
            string[] strs = formatedDatetime.Split(' ');
            if (strs.Length == 3)
            {
                var strsDate = strs[0].Split('/');
                var monthStr = strsDate[0].PadLeft(2, '0');
                var dateStr = strsDate[1].PadLeft(2, '0');
                var yearStr = strsDate[2].PadLeft(4, '0');

                var strsTime = strs[1].Split(':');
                var hourStr = strsTime[0].PadLeft(2, '0');
                var minuteStr = strsTime[1].PadLeft(2, '0');
                var secondStr = strsTime[2].PadLeft(2, '0');
                formatedDatetime = monthStr + "/" + dateStr + "/" + yearStr + " " + hourStr + ":" + minuteStr + ":" + secondStr + " " + strs[2];
            }
            else
            {
                LogHelper.Error($"time format not correct: {dateTimeString}");

            }
            return formatedDatetime;
        }
        private static Dictionary<string, List<Log>> importData(string filePath)
        {
            TextReader theDataFile = new StreamReader(filePath);
            string stringTotal = theDataFile.ReadToEnd();
            string[] stringRows = stringTotal.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            Dictionary<string, List<Log>> employeeLogs = new Dictionary<string, List<Log>>();
            //List<AttendLog> logs = new List<AttendLog>();
            foreach (var curStr in stringRows)
            {
                if (i == 0)
                {
                    //header
                    i++;
                    continue;
                }
                i++;
                string[] strs = curStr.Split(';');
                if (strs.Length == 7)
                {
                    string clockStr = strs[1];
                    string employeeID = strs[2];
                    string reader_name = strs[6];
                    string entryType = reader_name.Substring(reader_name.LastIndexOf('>') + 1);
                    DateTime dt;
                    //System.Globalization.DateTimeFormatInfo dtfi = new System.Globalization.CultureInfo("en-US", false).DateTimeFormat;
                    //dtfi.ShortTimePattern = "t";
                    clockStr = checkFormatDatetime(clockStr);
                    dt = DateTime.ParseExact(clockStr, "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    //if (DateTime.TryParseExact(clockStr, "MM/dd/yyyy hh:mm:ss tt",
                    //                           CultureInfo.InvariantCulture, DateTimeStyles.None,
                    //                           out dt))
                    //{

                    //}
                    try
                    {
                        Log log = new Log()
                        {
                            EmployeeID = employeeID,
                            Clock = dt,
                            EntryType = entryType.ToEnum<EntryType>()
                        };
                        if (employeeLogs.ContainsKey(employeeID))
                        {
                            List<Log> logs = employeeLogs[employeeID];
                            logs.Add(log);
                        }
                        else
                        {
                            List<Log> logs = new List<Log>();
                            logs.Add(log);
                            employeeLogs.Add(employeeID, logs);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogHelper.Error("parse string", ex);
                    }

                }
                else
                {
                    LogHelper.Error($"attend log format is wrong: {curStr}");
                }
            }
            return employeeLogs;
        }
        public static void CheckExceptionAttendence(string filePath, DateTime targetDate)
        {
            try
            {
                Dictionary<string, List<Log>> employeeLogs = importData(filePath);

                //var targetDate = employeeLogs.Values.ElementAt(0).First().Clock;
                foreach (var employee in employees)
                {
                    if (employeeLogs.ContainsKey(employee.EmployeeID))
                    {
                        var logs = employeeLogs[employee.EmployeeID];

                        var attendExLogs = checkExceptionAttend(logs, employee, targetDate);

                        var dateFolder = exportPath + "\\checkExResults\\" + targetDate.ToString("MM-dd-yyyy");
                        if (Directory.Exists(dateFolder) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(dateFolder);
                        }
                        
                        var fileName = dateFolder +"\\"+ employee.EmployeeID + ".xlsx";
                        SaveDataToExcelFile(attendExLogs, fileName);
                    }
                    else
                    {
                        Exception ex = new Exception($"no data of checking exception found for {employee.EmployeeID}");
                        LogHelper.Error("checking exception", ex);
                        throw ex;
                    }
                }

            }
            catch (Exception ex)
            {
                LogHelper.Error("calcucate attend: ", ex);
                throw ex;
            }
        }
        public static void CalucateEmployeAttendence(string filePath, DateTime targetDate)
        {
            LogHelper.Debug("start to calucate attendence log.");
            try
            {
                Dictionary<string, List<Log>> employeeLogs = importData(filePath);
                var attendLogs = new List<AttendLog>();
                //var targetDate = employeeLogs.Values.ElementAt(0).First().Clock;
                foreach (var employee in employees)
                {
                    if (employeeLogs.ContainsKey(employee.EmployeeID))
                    {
                        var logs = employeeLogs[employee.EmployeeID];

                        //logs.Sort((x, y) => x.Clock.CompareTo(y.Clock));
                        //var firstAttendLog = logs.First();
                        //var lastAttendLog = logs.Last();
                        AttendLog attendLog = checkAttendStatus(logs, employee, targetDate);
                        attendLogs.Add(attendLog);
                    }
                    else
                    {
                        //absent
                        AttendLog attendLog = new AttendLog()
                        {
                            Year = targetDate.Year,
                            Month = targetDate.Month,
                            Day = targetDate.Day,
                            EmployeeID = employee.EmployeeID,
                            AttendStatus = AttendStatus.Absent
                        };
                        attendLogs.Add(attendLog);
                    }
                }
                if (Directory.Exists(exportPath) == false)//如果不存在就创建file文件夹
                {
                    Directory.CreateDirectory(exportPath);
                }
                var fileName = exportPath + "\\attendlog" + targetDate.ToString("MM-dd-yyyy") + ".xlsx";
                SaveDataToExcelFile(attendLogs, fileName);
            }
            catch (Exception ex)
            {
                LogHelper.Error("calcucate attend: ", ex);
                throw ex;
            }


        }
        private static List<AttendExceptionLog> checkExceptionAttend(List<Log> logs, Employee employee, DateTime targetDate)
        {
            logs.Sort((x, y) => x.Clock.CompareTo(y.Clock));
            var dateFolder = exportPath + "\\Logs2\\" + targetDate.ToString("MM-dd-yyyy");
            if (Directory.Exists(dateFolder) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(dateFolder);
            }
            var logFile = dateFolder + "\\" + employee.EmployeeID + ".xlsx";
            SaveDataToExcelFile(logs, logFile);
            var dinnerBreakTime = new DateTime(targetDate.Year, targetDate.Month, targetDate.Day, employee.AttendType.StartDinnerBreakHour, employee.AttendType.DinnerBreakMinute, 0);
            var isOut = false;
            Log logout = null;
            List<AttendExceptionLog> exLogs = new List<AttendExceptionLog>();
            foreach (var log in logs)
            {
                if (isOut == false)
                {
                    if (log.EntryType == EntryType.Out)
                    {
                        logout = log;
                        isOut = true;
                    }
                }
                else
                {
                    if (log.EntryType == EntryType.In)
                    {
                        //one cycle out in
                        isOut = false;
                        if (logout.Clock.CompareTo(dinnerBreakTime) < 0)
                        {
                            //在中间休息之前出去的
                            var duration = log.Clock - logout.Clock;
                            if (duration.TotalMinutes > employee.AttendType.TempBreakMinute)
                            {
                                //出去时间异常
                                AttendExceptionLog exLog = new AttendExceptionLog()
                                {
                                    EmployeeID = employee.EmployeeID,
                                    OutClock = logout.Clock,
                                    InClock = log.Clock,
                                    ExceptionType = ExceptionType.TempBreak
                                };
                                exLogs.Add(exLog);
                            }
                        }
                        else
                        {
                            var duration = log.Clock - logout.Clock;
                            if (duration.TotalMinutes > employee.AttendType.DinnerBreakMinute)
                            {
                                //吃饭休息时间异常
                                AttendExceptionLog exLog = new AttendExceptionLog()
                                {
                                    EmployeeID = employee.EmployeeID,
                                    OutClock = logout.Clock,
                                    InClock = log.Clock,
                                    ExceptionType = ExceptionType.TempBreak
                                };
                                exLogs.Add(exLog);
                            }
                        }
                    }
                    else
                    {
                        //twice out: exception
                        AttendExceptionLog exLog = new AttendExceptionLog()
                        {
                            EmployeeID = employee.EmployeeID,
                            OutClock = logout.Clock,
                            ExceptionType = ExceptionType.AttendException
                        };
                        exLogs.Add(exLog);
                    }
                }
            }
            return exLogs;
        }
        private static AttendLog checkAttendStatus(List<Log> logs, Employee employee, DateTime targetDate)
        {
            logs.Sort((x, y) => x.Clock.CompareTo(y.Clock));
            var dateFolder = exportPath + "\\logs\\" + targetDate.ToString("MM-dd-yyyy");
            if (Directory.Exists(dateFolder) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(dateFolder);
            }
            var logFile = dateFolder + "\\" + employee.EmployeeID + ".xlsx";
            SaveDataToExcelFile(logs, logFile);
            //var firstAttendIn = logs.Where(l => l.EntryType == EntryType.In).FirstOrDefault();
            //var lastAttendOut = logs.Where(l => l.EntryType == EntryType.Out).LastOrDefault();
            //var firstAttendLog = logs.Where(l => l.Clock.Year == targetDate.Year
            //&& l.Clock.Month == targetDate.Month
            //&& l.Clock.Day == targetDate.Day);
            var targetYear = targetDate.Year;
            var targetMonth = targetDate.Month;
            var targetDay = targetDate.Day;

            var firstAttendLog = logs.FirstOrDefault(l => l.Clock.Year == targetYear
            && l.Clock.Month == targetMonth
            && l.Clock.Day == targetDay);

            var lastAttendLog = logs.LastOrDefault(l => l.Clock.Year == targetYear
            && l.Clock.Month == targetMonth
            && l.Clock.Day == targetDay);



            AttendLog attendLog = new AttendLog()
            {
                Year = targetYear,
                Month = targetMonth,
                Day = targetDay,
                EmployeeID = employee.EmployeeID
            };
            if (firstAttendLog == null || firstAttendLog.EntryType != EntryType.In)
            {
                attendLog.AttendStatus = AttendStatus.MissIn;
                return attendLog;
            }
            attendLog.EarlyIn = firstAttendLog.Clock;
            if (lastAttendLog == null || lastAttendLog.EntryType != EntryType.Out)
            {
                attendLog.AttendStatus = AttendStatus.MissOut;
                return attendLog;
            }
            attendLog.LastOut = lastAttendLog.Clock;

            var targetTimeIn = new DateTime(targetYear, targetMonth, targetDay, 9, 3, 0);
            var targetTimeOut = new DateTime(targetYear, targetMonth, targetDay, 17, 27, 0);
            if (employee.AttendType.IsShift)
            {
                targetTimeIn = new DateTime(targetYear, targetMonth, targetDay, employee.AttendType.TargetHourIn, employee.AttendType.TargetHourIn, 0);

                targetTimeOut = targetTimeIn.AddHours(employee.AttendType.ShiftTime);
            }
            if (targetTimeIn.CompareTo(firstAttendLog.Clock) >= 0)
            {
                TimeSpan ts = lastAttendLog.Clock - targetTimeOut;
                if (targetTimeOut.CompareTo(lastAttendLog.Clock) <= 0)
                {
                    //normal off work
                    if (ts.Hours >= 1)
                    {
                        attendLog.AttendStatus = AttendStatus.OverTime;
                        attendLog.Overtime = ts.TotalMinutes;
                    }
                }
                else
                {
                    //early leave
                    attendLog.AttendStatus = AttendStatus.EarlyLeave;
                    attendLog.EarlyLeaveMinute = ts.TotalMinutes;
                }
            }
            else
            {
                //late

                TimeSpan ts = firstAttendLog.Clock - targetTimeIn;
                if (ts.TotalHours <= 1)
                {
                    attendLog.AttendStatus = AttendStatus.Late;
                    attendLog.LateMinute = ts.TotalMinutes;
                }
                else
                {
                    attendLog.AttendStatus = AttendStatus.Absent;
                    attendLog.LateMinute = ts.TotalMinutes;
                }

            }

            return attendLog;
        }
        private static void SaveDataToExcelFile(List<Log> logs, string filePath)
        {

            //var filePath = @"c:\\temp\\Sample.xlsx";
            if (File.Exists(filePath)) File.Delete(filePath);
            using (var excel = new ExcelPackage(new FileInfo(filePath)))
            {
                var ws = excel.Workbook.Worksheets.Add("Log");
                ws.Cells[1, 1].Value = "EmployeeID";
                ws.Cells[1, 2].Value = "EntryType";
                ws.Cells[1, 3].Value = "Clock";

                var length = logs.Count;
                int i = 0;
                foreach (var log in logs)
                {
                    ws.Cells[i + 2, 1].Value = log.EmployeeID;
                    ws.Cells[i + 2, 2].Value = log.EntryType.ToName();

                    ws.Cells[i + 2, 3].Value = log.Clock;
                    ws.Cells[i + 2, 3].Style.Numberformat.Format = "dd/MM/yyyy hh:mm:ss";
                    //ws.Column(i).AutoFit();
                    i++;
                }

                ws.Column(1).AutoFit();
                ws.Column(2).AutoFit();
                // ws.Column(3).AutoFit();

                excel.Save();
            }


        }

        private static void SaveDataToExcelFile(List<AttendLog> attendlogs, string filePath)
        {

            //var filePath = @"c:\\temp\\Sample.xlsx";
            if (File.Exists(filePath)) File.Delete(filePath);
            using (var excel = new ExcelPackage(new FileInfo(filePath)))
            {
                var ws = excel.Workbook.Worksheets.Add("AttendLog");
                ws.Cells[1, 1].Value = "EmployeeID";
                ws.Cells[1, 2].Value = "Attend Date";
                ws.Cells[1, 3].Value = "In&Out";
                ws.Cells[1, 4].Value = "AttendStatus";
                ws.Cells[1, 5].Value = "Late Minute";
                ws.Cells[1, 6].Value = "Overtime";
                ws.Cells[1, 7].Value = "Early Leave Minute";


                var length = attendlogs.Count;
                int i = 0;
                foreach (var attendlog in attendlogs)
                {
                    ws.Cells[i + 2, 1].Value = attendlog.EmployeeID;
                    ws.Cells[i + 2, 2].Value = attendlog.Month + "/" + attendlog.Day + "/" + attendlog.Year;
                    string inout = "";
                    if (attendlog.EarlyIn.CompareTo(default(DateTime)) != 0)
                    {
                        inout = attendlog.EarlyIn.ToShortTimeString();
                    }
                    //if (attendlog.EarlyIn != null)
                    //{

                    //}
                    inout += "&";
                    if (attendlog.LastOut.CompareTo(default(DateTime)) != 0)
                    {
                        inout += attendlog.LastOut.ToShortTimeString();
                    }
                    ws.Cells[i + 2, 3].Value = inout;

                    ws.Cells[i + 2, 4].Value = attendlog.AttendStatus.ToName();

                    ws.Cells[i + 2, 5].Value = attendlog.LateMinute + "m";
                    //ws.Cells[i + 2, 5].Style.Numberformat.Format = "#,##0m";
                    ws.Cells[i + 2, 6].Value = attendlog.Overtime + "m";
                    //ws.Cells[i + 2, 6].Style.Numberformat.Format = "#,##0m";
                    ws.Cells[i + 2, 7].Value = attendlog.EarlyLeaveMinute + "m";
                    //ws.Cells[i + 2, 7].Style.Numberformat.Format = "#,##0m";
                    //ws.Cells[i + 2, 8].Value = attendlog.EarlyIn.ToLocalTime();
                    //ws.Cells[i + 2, 8].Style.Numberformat.Format = "dd/MM/yyyy hh:mm:ss";
                    //ws.Cells[i + 2, 9].Value = attendlog.LastOut.ToLocalTime();
                    //ws.Cells[i + 2, 9].Style.Numberformat.Format = "dd/MM/yyyy hh:mm:ss";
                    //ws.Column(i).AutoFit();
                    i++;
                }


                //ws.Cells[2, 1, 11, 1].Style.Numberformat.Format = "dd/MM/yyyy";
                //ws.Cells[2, 2, 11, 2].Style.Numberformat.Format = "#,##0.000000";
                //ws.Cells[2, 5, 11, 5].Style.Numberformat.Format = "#,##0";
                //ws.Cells[2, 6, 11, 7].Style.Numberformat.Format = "#,##0";
                //ws.Cells[2, 7, 11, 7].Style.Numberformat.Format = "#,##0";
                ws.Column(1).AutoFit();
                ws.Column(2).AutoFit();
                ws.Column(3).AutoFit();
                ws.Column(4).AutoFit();
                ws.Column(5).AutoFit();
                ws.Column(6).AutoFit();
                ws.Column(7).AutoFit();
                excel.Save();
            }

            //object misValue = System.Reflection.Missing.Value;
            //Application xlApp = new Application();
            //Workbook xlWorkBook = xlApp.Workbooks.Add(misValue);
            //Worksheet xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //PropertyInfo[] props = GetPropertyInfoArray();
            //for (int i = 0; i < props.Length; i++)
            //{
            //    xlWorkSheet.Cells[1, i + 1] = props[i].Name; //write the column name
            //}
            //for (int i = 0; i < attendlogs.Count; i++)
            //{
            //    xlWorkSheet.Cells[i + 2, 1] = attendlogs[i].EmployeeID;
            //    xlWorkSheet.Cells[i + 2, 2] = attendlogs[i].AttendStatus.ToName();
            //    xlWorkSheet.Cells[i + 2, 3] = attendlogs[i].EarlyIn.ToShortDateString() + "&" + attendlogs[i].LastOut.ToShortDateString();
            //} 
            //try
            //{
            //    xlWorkBook.SaveAs(filePath, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //    xlWorkBook.Close(true, misValue, misValue);
            //    xlApp.Quit();
            //}
            //catch (Exception ex)
            //{
            //    LogHelper.Error("save excel: ", ex);
            //}

        }

        private static void SaveDataToExcelFile(List<AttendExceptionLog> attendExceptionLogs, string filePath)
        {

            //var filePath = @"c:\\temp\\Sample.xlsx";
            if (File.Exists(filePath)) File.Delete(filePath);
            using (var excel = new ExcelPackage(new FileInfo(filePath)))
            {
                var ws = excel.Workbook.Worksheets.Add("AttendExceptionLog");
                ws.Cells[1, 1].Value = "EmployeeID";
                ws.Cells[1, 2].Value = "Out Clock";
                ws.Cells[1, 3].Value = "In Clock";
                ws.Cells[1, 4].Value = "Exception Type";



                var length = attendExceptionLogs.Count;
                int i = 0;
                foreach (var attendExceptionLog in attendExceptionLogs)
                {
                    ws.Cells[i + 2, 1].Value = attendExceptionLog.EmployeeID;
                    if (attendExceptionLog.OutClock.CompareTo(default(DateTime)) != 0)
                    {
                        ws.Cells[i + 2, 2].Value = attendExceptionLog.OutClock.ToShortTimeString();
                    }
                    if (attendExceptionLog.InClock.CompareTo(default(DateTime)) != 0)
                    {
                        ws.Cells[i + 2, 3].Value = attendExceptionLog.InClock.ToShortTimeString();
                    }

                    ws.Cells[i + 2, 4].Value = attendExceptionLog.ExceptionType.ToName();

                    i++;
                }



                ws.Column(1).AutoFit();
                ws.Column(2).AutoFit();
                ws.Column(3).AutoFit();
                ws.Column(4).AutoFit();
                excel.Save();
            }



        }
        /// <summary>
        /// test excel library
        /// </summary>
        public static void ExcelLibraryTest()
        {
            //create new xls file 
            string file = "C:\\temp\\newdoc.xls";
            ExcelLibrary.SpreadSheet.Workbook workbook = new ExcelLibrary.SpreadSheet.Workbook();
            ExcelLibrary.SpreadSheet.Worksheet worksheet = new ExcelLibrary.SpreadSheet.Worksheet("First Sheet");
            worksheet.Cells[0, 1] = new Cell((short)1);
            worksheet.Cells[2, 0] = new Cell(9999999);
            worksheet.Cells[3, 3] = new Cell((decimal)3.45);
            worksheet.Cells[2, 2] = new Cell("Text string");
            worksheet.Cells[2, 4] = new Cell("Second string");
            worksheet.Cells[4, 0] = new Cell(32764.5, "#,##0.00");
            //worksheet.Cells[5, 1] = new Cell(DateTime.Now, @"YYYY-MM-DD");
            worksheet.Cells.ColumnWidth[0, 1] = 3000;
            workbook.Worksheets.Add(worksheet);
            workbook.Save(file);


        }
        private static PropertyInfo[] GetPropertyInfoArray()
        {
            PropertyInfo[] props = null;
            try
            {
                Type type = typeof(AttendLog);
                object obj = Activator.CreateInstance(type);
                props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            }
            catch (Exception ex)
            {
                LogHelper.Error("GetPropertyInfo from attendlog", ex);
            }
            return props;
        }
        /// <summary>
        /// test
        /// </summary>
        public static void ExcelPackageTest()
        {
            var file = @"c:\\temp\\Sample.xlsx";
            if (File.Exists(file)) File.Delete(file);
            using (var excel = new ExcelPackage(new FileInfo(file)))
            {
                var ws = excel.Workbook.Worksheets.Add("Sheet1");
                ws.Cells[1, 1].Value = "Date";
                ws.Cells[1, 2].Value = "Price";
                ws.Cells[1, 3].Value = "Volume";
                var random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    ws.Cells[i + 2, 1].Value = DateTime.Today.AddDays(i);
                    ws.Cells[i + 2, 2].Value = random.NextDouble() * 1e3;
                    ws.Cells[i + 2, 3].Value = random.Next() / 1e3;
                }

                ws.Cells[2, 1, 11, 1].Style.Numberformat.Format = "dd/MM/yyyy";
                ws.Cells[2, 2, 11, 2].Style.Numberformat.Format = "#,##0.000000";
                ws.Cells[2, 3, 11, 3].Style.Numberformat.Format = "#,##0";
                ws.Column(1).AutoFit();
                ws.Column(2).AutoFit();
                ws.Column(3).AutoFit();
                excel.Save();
            }
        }
    }
}
