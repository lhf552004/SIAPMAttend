using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAPM.Utils
{
    public class LogHelper
    {
        private LogHelper()
        {
        }

        public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");

        public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");

        public static readonly log4net.ILog logdebug = log4net.LogManager.GetLogger("logdebug");

        public static readonly log4net.ILog logwarn = log4net.LogManager.GetLogger("logwarn");
        public static void SetConfig()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void SetConfig(FileInfo configFile)
        {
            log4net.Config.XmlConfigurator.Configure(configFile);
        }

        public static void Info(string info)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info);
            }
        }
        public static void Debug(string debug)
        {
            if (logdebug.IsDebugEnabled)
            {
                logdebug.Debug(debug);
            }
        }
        public static void Warn(string warn)
        {
            if (logwarn.IsWarnEnabled)
            {
                logwarn.Warn(warn);
            }
        }
        public static void Error(string info, Exception se)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info, se);
            }
        }
        public static void Error(string info)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info);
            }
        }
    }
}
