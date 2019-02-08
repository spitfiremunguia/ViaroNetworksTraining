using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class Delegates
    {
        public delegate void EventManager(Event obj);
        public delegate void WidgetManager(WidgetRepository wr);
        public delegate void ContainerManager(ContainerRepository cr);
    }
}
