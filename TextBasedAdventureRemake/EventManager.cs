using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureRemake
{
    public class Event
    {
        public int eventID { get; protected set; }
        public string eventName { get; protected set; }
        public int difficulty { get; protected set; }
        public List<Item> loot = new List<Item>();

        public Event(int eventID,string eventName, int difficulty)
        {
            this.eventID = eventID;
            this.eventName = eventName;
            this.difficulty = difficulty;
        }
    }
    internal class EventManager
    {
        private Random rand = new Random();
        public List<Event> events = new List<Event>();
        public EventManager()
        {
            // Példa események hozzáadása
            events.Add(new Event(1,"Goblin támadás", 1));
            events.Add(new Event(2, "Elveszett kincs", 2));
            events.Add(new Event(3,"Sárkány ébredése", 5));
        }

        public Event GetEventByID(int id)
        {
            if (id < 0 || id >= events.Count)
            {
                Console.WriteLine("HIBA!");
                return events[0];//Később megcsináljuk jól, csak azért van itt hogy ne dőljön össze a program
            }
            else
            {
                return events[id];
            }
        }

        public Event GetRandomEvent() {
            
            return events[rand.Next(events.Count)];

        }
    }
}
