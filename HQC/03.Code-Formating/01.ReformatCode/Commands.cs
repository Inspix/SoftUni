namespace ReformatCode
{
    using System;

    public class Commands
    {
        /// <summary>
        /// Holds a reference of <see cref="EventHolder"/> class used by all methods in the class
        /// </summary>
        public static EventHolder Events { get; set; }

        /// <summary>
        /// Execute an command
        /// </summary>
        /// <returns>If the command execution is succesfull</returns>
        public static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();
            switch (command[0])
            {
                case 'A':
                    AddEvent(command);
                    return true;
                case 'D':
                    DeleteEvents(command);
                    return true;
                case 'L':
                    ListEvents(command);
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Add an event to the current <see cref="EventHolder"/> reference - <see cref="Events"/>.
        /// </summary>
        /// <param name="command">Command line parameters</param>
        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;
            GetParameters(command, "AddEvent", out date, out title, out location);
            Events.AddEvent(date, title, location);
        }

        /// <summary>
        /// Delete an event from the current <see cref="EventHolder"/> reference - <see cref="Events"/>
        /// </summary>
        /// <param name="command">Command line parameters</param>
        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);
            Events.DeleteEvents(title);
        }

        /// <summary>
        /// Lists an events from the current <see cref="EventHolder"/> reference - <see cref="Events"/>
        /// </summary>
        /// <param name="command">Command line parameters</param>
        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = GetDate(command,"ListEvents");
            string countString = command.Substring(pipeIndex + 1);
            
            int count = int.Parse(countString);
            Events.ListEvents(date,count);
        }

        /// <summary>
        /// Parses the passed command line
        /// </summary>
        /// <param name="commandForExecution">The command to parse</param>
        /// <param name="commandType">Type of the command</param>
        /// <param name="dateAndTime">DateTime to output to</param>
        /// <param name="eventTitle">String to output the title to</param>
        /// <param name="eventLocation">String to output the location to</param>
        private static void GetParameters(string commandForExecution, string commandType,
            out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');
            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = "";
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        /// <summary>
        /// Parses the Date from a command
        /// </summary>
        /// <param name="command">The command string</param>
        /// <param name="commandType">The command type string</param>
        /// <returns>Parsed DateTime</returns>
        private static DateTime GetDate(string command, string commandType)
        {
            return DateTime.Parse(command.Substring(commandType.Length + 1, 20));
        }
    }
}
