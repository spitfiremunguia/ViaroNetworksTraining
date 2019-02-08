using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class EventService:IEventService
    {
        public EventService()
        {

        }


        public Event[] CreateEvents(int nTimes)
        {
            Event[] ev = new Event[nTimes];
            EventRepository evr = new EventRepository();
            for (int i = 0; i <nTimes; i++)
            {
                ev[i]=evr.CreateEvent(i,Utilities.Random());
            }
            return ev;
        }

        public void PrintRepositories(Event[] Repos, Delegates.EventManager Manager)
        {
            for (int i = 0; i < Repos.Length; i++)
            {
                Manager(Repos[i]);
            }
        }
    }
}
