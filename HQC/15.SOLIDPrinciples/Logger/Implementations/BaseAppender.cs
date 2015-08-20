using System;
using LoggerSOLID.Structure;

namespace LoggerSOLID.Implementations
{
    public abstract class BaseAppender : IAppender
    {
        protected BaseAppender(ILayout layout)
        {
            this.Layout = layout;
        }
        
        public ReportLevel ReportThreshold { get; set; }

        public ILayout Layout { get; private set; }

        public abstract void Append(ReportLevel level, string msg, params object[] args);

        public void AppendThresholdCheck(ReportLevel level, string msg, params object[] args)
        {
            if (this.ReportThreshold > level)
            {
                return;
            }
            this.Append(level, msg, args);
        }
    }
}
