using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSLibrary.Interfaces;
using HSLibrary.Models;
using HSLibrary.Models.Dinghy;

namespace HSLibrary.Services
{
    public class EventRepository : IEventRepository
    {
        Dictionary<int, Event> _events;
        public int Count
        {
            get
            {
                return _events.Count;
            }
        }

        public EventRepository()
        {
            _events = new Dictionary<int, Event>();
        }

        public void Add(Event Event)
        {
            _events.Add(Event.Id, Event);
        }
        public void Remove(int id)
        {
            _events.Remove(id);
        }
        public Event Get(int id)
        {
            return _events[id];
        }
        public List<Event> GetAll()
        {
            return _events.Values.ToList();
        }
        public List<Event> GetAllOnDate(DateOnly date)
        {
            List<Event> list = new List<Event>();
            foreach (Event Event in _events.Values)
            {
                if (DateOnly.FromDateTime(Event.Date) == date) list.Add(Event);
            }
            return list;
        }
        public List<Event> GetAllByMember(Member member)
        {
            List<Event> list = new List<Event>();
            foreach (Event Event in _events.Values) //skal Event ikke være med småt 2. gang?
            {
                if (Event.Organiser == member) list.Add(Event);
            }
            return list;
        }
        public override string ToString()
        {
            string result = $"Der er et total af {Count} begivenheder";
            foreach (Event Event in _events.Values)
            {
                result += $"\n\t{Event}";
            }
            return result;
        }
    }
}
