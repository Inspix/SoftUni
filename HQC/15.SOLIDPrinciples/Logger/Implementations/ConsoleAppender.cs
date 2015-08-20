using System;
using LoggerSOLID.Structure;

namespace LoggerSOLID.Implementations
{
    public class ConsoleAppender : BaseAppender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }
        
        public override void Append(ReportLevel level, string msg, params object[] args)
        {
            Console.WriteLine(this.Layout.Convert(level,msg,args));
        }        
    }
}
