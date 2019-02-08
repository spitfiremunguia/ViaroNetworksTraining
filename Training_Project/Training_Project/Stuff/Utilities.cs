using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Training_Project
{
    class Utilities
    {
        private static Random r = new Random();
        public static int Random() 
        {
            
            return r.Next(0,100);
        }

        public static string getJson(string path) 
        {
            try
            {
                FileStream str = File.Open(path, FileMode.Open);
                StreamReader reader = new StreamReader(str);
                string line = reader.ReadLine();
                reader.Close();
                str.Close();
                return line;
            }
            catch (FileNotFoundException)
            {

                return "{\"key\":\"error\"}";
            }
        }


        public static void PrintEvents(Event ev)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|ID:{0}|Organization_ID:{1}|", ev.ID, ev.OrganizationID);
        }
        public static void PrintWidgetRepos(WidgetRepository wr)
        {
            P2PWidget w = wr.MyWidget;
            P2PWidgetContent wc0 = wr.MyWidgetContent_0;
            P2PWidgetContent wc1 = wr.MyWidgetContent_1;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(">|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", w.WidgetId, w.ContainerID, w.Locked, w.Properties, w.SortOrder, w.P2PWidgetTypeID, w.IsRequired, w.IsVisible, w.VisibilityConditionTypeID);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*|{0}|{1}|{2}|", wc0.WidgetId, wc0.LanguageCode, wc0.Content);
            Console.WriteLine("*|{0}|{1}|{2}|\n", wc1.WidgetId, wc1.LanguageCode, wc1.Content);


        }
        public static void PrintContainerRepos(ContainerRepository cr)
        {
            P2PContainer c = cr.MyContainer;
            P2PContainerContent cc = cr.MyContentContainer;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(">|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", c.ContainerId, c.EventID, c.P2PPageTypeID, c.Properties, c.IsHero, c.IsHeroLocked,
                c.SortOrder, c.ColumnOrder);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*|{0}|{1}|", cc.ContainerID, cc.LanguageCode);

        }

    }
}
