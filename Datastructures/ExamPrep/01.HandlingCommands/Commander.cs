namespace _01.HandlingCommands
{
    using System;
    using System.Collections;
    using System.Linq;

    public class Commander<T> where T : IList, new()
    {

        private static readonly char[] Delimiters = { '|' };
        private const string Command1 = "Add";
        private const string Command1Output = "{0}{1}{2}";
        private const string Command2 = "2";
        private const string Command2Output = "{0}{1}{2}";
        private const string Command3 = "3";
        private const string Command3Output = "{0}{1}{2}";
        private const string Command4 = "4";
        private const string Command4Output = "{0}{1}{2}";
        private const string Command5 = "5";
        private const string Command5Output = "{0}{1}{2}";
        private const string Command6 = "6";
        private const string Command6Output = "{0}{1}{2}";
        private const string Command7 = "7";
        private const string Command7Output = "{0}{1}{2}";
        private const string Command8 = "8";
        private const string Command8Output = "{0}{1}{2}";
        private const string Command9 = "9";
        private const string Command9Output = "{0}{1}{2}";
        private const string Command10 = "0";
        private const string Command10Output = "{0}{1}{2}";
        private string[] currentArgs;
        private T collection;


        public Commander()
        {
            this.collection = new T();
        }

        public void ProcessArgs(string command)
        {
            this.CurrentArgs = command.Split(Delimiters).Select(s => s.Trim()).ToArray();
        }

        private string[] CurrentArgs
        {

            get
            {
                return this.currentArgs;
            }

            set
            {
                if (value == null || value.Length < 1)
                {
                    throw new NullReferenceException();
                }
                this.currentArgs = value;
            }
        }

        public void ExecuteCommand()
        {
            switch (this.CurrentArgs[0])
            {
                case Command1:
                    // TODO: 
                    Console.WriteLine(string.Format(Command1Output  /* args */ ));
                    break;
                case Command2:
                    // TODO: 
                    Console.WriteLine(string.Format(Command2Output /* args */ ));
                    break;
                case Command3:
                    // TODO: 
                    Console.WriteLine(string.Format(Command3Output /* args */ ));
                    break;
                case Command4:
                    // TODO: 
                    Console.WriteLine(string.Format(Command4Output /* args */ ));
                    break;
                case Command5:
                    // TODO: 
                    Console.WriteLine(string.Format(Command5Output /* args */ ));
                    break;
                case Command6:
                    // TODO: 
                    Console.WriteLine(string.Format(Command6Output /* args */ ));
                    break;
                case Command7:
                    // TODO: 
                    Console.WriteLine(string.Format(Command7Output /* args */ ));
                    break;
                case Command8:
                    // TODO: 
                    Console.WriteLine(string.Format(Command8Output /* args */ ));
                    break;
                case Command9:
                    // TODO: 
                    Console.WriteLine(string.Format(Command9Output /* args */ ));
                    break;
                case Command10:
                    // TODO: 
                    Console.WriteLine(string.Format(Command10Output /* args */ ));
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }

        private T CreateObject(string p1)
        {
            throw new NotImplementedException();
        }

        private T CreateObject(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        private T CreateObject(string p1, string p2,string p3)
        {
            throw new NotImplementedException();
        }
    }
}