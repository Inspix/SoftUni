using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LoggerSOLID.Structure;

namespace LoggerSOLID.Implementations
{
    public class FileAppender : BaseAppender
    {
        private string file;

        public FileAppender(ILayout layout) : base(layout)
        {
            this.File = "Log.txt";
        }

        public string File
        {
            get
            {
                return this.file;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The given file name cannot be null or empty.");
                }
                this.file = value;
            }
        }


        public override void Append(ReportLevel level, string msg, params object[] args)
        {
            using (var sr = new StreamWriter(file, true))
            {
                sr.WriteLine(this.Layout.Convert(level, msg, args));
            }
        }
    }
}
