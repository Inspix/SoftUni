namespace ReformatCode
{
    using System.Text;

    public static class Messages
    {
        /// <summary>
        /// Get or set the current output reference used by all methods in the class
        /// </summary>
        public static StringBuilder Output { get; set; }

        /// <summary>
        /// Outputs a "Event added" message to the <see cref="StringBuilder"/> reference - <see cref="Output"/>
        /// </summary>
        public static void EventAdded()
        {
            Output.Append("Event added\n");
        }

        /// <summary>
        /// Outputs a "Event deleted" message to the <see cref="StringBuilder"/> reference - <see cref="Output"/>
        /// </summary>
        /// <param name="x">Number of deleted events</param>
        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
                return;
            }
            Output.AppendFormat("{0} events deleted\n", x);
        }

        /// <summary>
        /// Outputs a "No events found" message to the <see cref="StringBuilder"/> reference - <see cref="Output"/>
        /// </summary>
        public static void NoEventsFound()
        {
            Output.Append("No events found\n"); 
        }

        /// <summary>
        /// Appends <see cref="Event"/> info to the <see cref="StringBuilder"/> reference - <see cref="Output"/>
        /// </summary>
        /// <param name="eventToPrint"></param>
        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint + "\n");
            }
        }
    }
}
