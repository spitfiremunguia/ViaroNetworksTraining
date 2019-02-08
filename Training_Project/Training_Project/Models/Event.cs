using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class Event
    {
        private int id;
        private int organizationID;
        public Event()
        {

        }
        public Event(int id,int organizationID)
        {
            this.id = id;
            this.organizationID = organizationID;
        }
        public int ID { get { return id; } set { id = value; } }
        public int OrganizationID { get { return organizationID; } set { organizationID = value; } }
    }
}
