using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Training_Project
{
    class P2PWidgetContent
    {
        private int widgetID;
        private Enumerators.LanguageCode languageCode;
        private string content;

        public P2PWidgetContent()
        {

        }
        public P2PWidgetContent(int widgetID, Enumerators.LanguageCode languageCode, string content)
        {
            this.content = content;
            this.widgetID = widgetID;
            this.languageCode = languageCode;
            
        }
        public int WidgetId { get { return widgetID; } set { widgetID = value; } }
        public Enumerators.LanguageCode LanguageCode { get { return languageCode; } set { languageCode = value; } }
        public string Content { get { return content; } set { content = value; } }

    }
}
