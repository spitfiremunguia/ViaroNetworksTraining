using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    interface IEventService
    {
        Event[] CreateEvents(int nTimes);
        void PrintRepositories(Event[] Repos, Delegates.EventManager Manager);
    }
}
