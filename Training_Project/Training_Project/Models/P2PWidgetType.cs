using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class P2PWidgetType
    {

        private string p2pWidgetIdType;
        private string documentation;
        public P2PWidgetType()
        {

        }

        public P2PWidgetType(string p2pWidgetIdType,string documentation)
        {
            this.p2pWidgetIdType = p2pWidgetIdType;
            this.documentation = documentation;
        }

        public string P2PWidgetIDType { get { return p2pWidgetIdType; } set { p2pWidgetIdType = value; } }
        public string Documentation { get { return Documentation; } set { documentation = value; } }
    }
}
