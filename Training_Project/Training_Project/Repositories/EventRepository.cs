using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class EventRepository:IEventRepository
    {
        public Event CreateEvent(int id, int organizationID)
        {
            return new Event(id, organizationID);
        }
    }
}
