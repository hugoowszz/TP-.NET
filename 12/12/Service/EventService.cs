using _12.Models;

namespace _12.Service;

public class EventService
{
    public Action<Event> OnEventCreated;
    
    public void add(Event newEvent)
    {
        OnEventCreated?.Invoke(newEvent);
    }
}
