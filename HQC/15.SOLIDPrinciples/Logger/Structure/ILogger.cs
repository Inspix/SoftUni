using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerSOLID.Structure
{
    public interface ILogger
    {
        IList<IAppender> Appenders { get; }
        void Info(string msg, params object[] args);
        void Warning(string msg, params object[] args);
        void Error(string msg, params object[] args);
        void Critical(string msg, params object[] args);
        void Fatal(string msg, params object[] args);
    }
}
