using System;
using LoggerSOLID.Structure;

namespace LoggerSOLID.Implementations
{
    class SimpleLayout : ILayout
    {
        public string Convert(ReportLevel level, string input, params object[] args)
        {
            return string.Format("{0} - {1} - {2}", DateTime.Now, level, string.Format(input,args));
        }
    }
}
