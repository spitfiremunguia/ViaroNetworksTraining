using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class WidgetService:IWidgetService
    {

        public WidgetService()
        {

        }
        public WidgetRepository[] CreateWidgets(int nTimes)
        {
            WidgetRepository[] wr=new WidgetRepository[nTimes];
            for (int i = 0; i < nTimes; i++)
            {
                wr[i] = new WidgetRepository(i);
            }
            return wr;
        }

        public void PrintRepositories(WidgetRepository[] Repos, Delegates.WidgetManager Manager)
        {
            for (int i = 0; i < Repos.Length; i++)
            {
                Manager(Repos[i]);
            }
        }
    }
}
