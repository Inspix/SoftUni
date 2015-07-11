namespace ReformatCode
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        /// <summary>
        /// Initializes an instance of the <see cref="Event"/> class.
        /// </summary>
        /// <param name="date">Date of the event</param>
        /// <param name="title">The name of the event</param>
        /// <param name="location">The event location</param>
        public Event(DateTime date, string title, string location)
        {
            this.Date = date;

            this.Title = title;
            this.Location = location;
        }

        /// <summary>
        /// Gets or sets the Date of the event
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or set the Title of the event;
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the location of the event;
        /// </summary>
        public string Location { get; set; }


        /// <summary>
        /// Compares the given object with the current Event instance
        /// </summary>
        /// <param name="obj">Object to compare with</param>
        /// <remarks>Compares first by date, than by title, and if they are equal compares by location</remarks>
        /// <returns>If the instance is less than, equal or more than the compared object(-1,0,1) </returns>
        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.Date.CompareTo(other.Date);
            int byTitle = this.Title.CompareTo(other.Title);

            int byLocation = this.Location.CompareTo(other.Location);
            if (byDate == 0)
            {
                if (byTitle == 0)
                    return byLocation;
                else
                {
                    return byTitle;
                }
            }
            return byDate;
        }

        /// <summary>
        /// String representation of the <see cref="Event"/>> class instance.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(Date.ToString("yyyy-MM-ddTHH:mm:ss"));

            toString.Append(" | " + Title);
            if (!string.IsNullOrEmpty(Location))
            {
                toString.Append(" | " + Location);
            }
            return toString.ToString();
        }
    }
}

