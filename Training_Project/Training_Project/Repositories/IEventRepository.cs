using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    interface IEventRepository
    {
        Event CreateEvent(int id, int organizationID);
    }
}
