using System.Collections.Generic;
using System.Linq;

public class EventService
{
    private List<Event> _events = new List<Event>();

    public List<Event> GetEvents()
    {
        return _events;
    }

    public void AddEvent(Event eventItem)
    {
        _events.Add(eventItem);
    }

    public void MarkEventAsCompleted(int id)
    {
        var eventItem = _events.FirstOrDefault(e => e.Id == id);
        if (eventItem != null)
        {
            eventItem.IsCompleted = true;
        }
    }

    public void DeleteEvent(int id)
    {
        var eventItem = _events.FirstOrDefault(e => e.Id == id);
        if (eventItem != null)
        {
            _events.Remove(eventItem);
        }
    }
}
