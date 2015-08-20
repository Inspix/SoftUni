using LoggerSOLID.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerSOLID.Implementations
{
    public class Logger : ILogger
    {

        public Logger(IAppender baseapender, params IAppender[] moreappenders)
        {
            this.Appenders = new List<IAppender>();
            this.Appenders.Add(baseapender);
            foreach (var appender in moreappenders)
            {
                this.Appenders.Add(appender);
            }
        }

        public IList<IAppender> Appenders { get; private set;}

        private void Log(ReportLevel level, string msg, params object[] args)
        {
            foreach (var appender in Appenders)
            {
                appender.AppendThresholdCheck(level, msg, args);
            }
        }

        public void Critical(string msg, params object[] args)
        {
            this.Log(ReportLevel.Critical, msg, args);
        }

        public void Error(string msg, params object[] args)
        {
            this.Log(ReportLevel.Error, msg, args);

        }

        public void Fatal(string msg, params object[] args)
        {
            this.Log(ReportLevel.Fatal, msg, args);

        }

        public void Info(string msg, params object[] args)
        {
            this.Log(ReportLevel.Info, msg, args);

        }

        public void Warning(string msg, params object[] args)
        {
            this.Log(ReportLevel.Warning, msg, args);
        }
    }
}
