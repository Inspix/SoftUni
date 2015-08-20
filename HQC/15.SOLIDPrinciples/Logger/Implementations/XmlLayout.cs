using LoggerSOLID.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerSOLID.Implementations
{
    public class XmlLayout : ILayout
    {
        public string Convert(ReportLevel level, string msg, params object[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<log>").
                AppendFormat("  <date>{0}</date>\n", DateTime.Now).
                AppendLine("  <level>" + level + "</level>").
                AppendLine("  <message>" + string.Format(msg, args) + "</message>").
                Append("</log>");
            return sb.ToString();

        }
    }
}
