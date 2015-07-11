namespace ReformatCode
{
    using System;
    using Wintellect.PowerCollections;

    public class EventHolder
    {
        /// <summary>
        /// Stores the event instances by Title
        /// </summary>
        private readonly MultiDictionary<string, Event> byTitle;

        /// <summary>
        /// Stores the Events ordered by date
        /// </summary>
        private readonly OrderedBag<Event> byDate;

        /// <summary>
        /// Initializes an instance of the <see cref="EventHolder"/> class.
        /// </summary>
        public EventHolder()
        {
            byTitle = new MultiDictionary<string, Event>(true);
            byDate = new OrderedBag<Event>();
        }

        /// <summary>
        /// Add an event to the current instance.
        /// </summary>
        /// <param name="date">Date of the event</param>
        /// <param name="title">The title of the event</param>
        /// <param name="location">The location of the event</param>
        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date,title,location);
            byTitle.Add(title.ToLower(),newEvent);
            byDate.Add(newEvent);
            Messages.EventAdded();
        }

        /// <summary>
        /// Delete an event from the current instance by title
        /// </summary>
        /// <param name="titleToDelete">The title of the event to delete</param>
        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;
            foreach (var eventToRemove in byTitle[title])
            {
                removed++;
                byDate.Remove(eventToRemove);
            }
            byTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        /// <summary>
        /// Lists the current events given starting date and count
        /// </summary>
        /// <param name="date">Starting Date</param>
        /// <param name="count">Count of the events to list</param>
        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = byDate.RangeFrom(new Event(date, "", ""),true);
            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count) break;
                Messages.PrintEvent(eventToShow);

                showed++;
            }
            if (showed == 0) Messages.NoEventsFound();
        }
    }
}
