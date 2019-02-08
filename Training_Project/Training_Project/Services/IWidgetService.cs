using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    interface IWidgetService
    {
        WidgetRepository[] CreateWidgets(int nTimes);
        void PrintRepositories(WidgetRepository[] Repos, Delegates.WidgetManager Manager);
    }
}
