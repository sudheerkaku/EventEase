using EventEase.Models;
using System.Collections.Generic;
using System.Linq;

namespace EventEase.Services
{
    public class EventService
    {
        public List<Event> events { get; set; } = new List<Event>();

        public EventService()
        {
            // Sample data for events, in a real app, this data would come from an API or database
            events.Add(new Event { Id = 1, EventName = "Corporate Gala", Date = DateTime.Now.AddDays(10), Location = "New York" });
            events.Add(new Event { Id = 2, EventName = "Tech Conference", Date = DateTime.Now.AddMonths(1), Location = "San Francisco" });
        }

        public List<Event> GetEvents()
        {
            return events;
        }

        public Event GetEventById(int id)
        {
            return events.FirstOrDefault(e => e.Id == id);
        }

        public void UpdateEvent(Event updatedEvent)
        {
            var existingEvent = events.FirstOrDefault(e => e.Id == updatedEvent.Id);
            if (existingEvent != null)
            {
                // Update event details
                existingEvent.EventName = updatedEvent.EventName;
                existingEvent.Date = updatedEvent.Date;
                existingEvent.Location = updatedEvent.Location;
            }
        }

        public void RegisterEvent(Event registerEvent)
        {
            var id = events.Max(e => e.Id) + 1;
            events.Add(new Event { Id = id, EventName = registerEvent.EventName, Date = registerEvent.Date, Location = registerEvent.Location });
        }
    }
}
