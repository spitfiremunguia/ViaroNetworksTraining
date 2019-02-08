using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.WriteLine("\t\t\tEvents");
            EventService es = new EventService();
            es.PrintRepositories(es.CreateEvents(5), Utilities.PrintEvents);
            Console.WriteLine("\n\t\t\tWidgets");
            WidgetService ws = new WidgetService();
            ws.PrintRepositories(ws.CreateWidgets(15), Utilities.PrintWidgetRepos);
            Console.WriteLine("\n\t\t\tContainers");
            ContainerService cs = new ContainerService();
            cs.PrintRepositories(cs.CreateContainerRepos(5), Utilities.PrintContainerRepos);
            Console.ResetColor();
            Console.ReadLine();
            
        }
      
        
    }
}
