using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class P2PWidget
    {
        private int widgetID;
        private int containerID;
        private Enumerators.Answere locked;
        private string properties;
        private int sortOrder;
        private string p2pWidgetTypeId;
        private Enumerators.Answere isRequired;
        private Enumerators.Answere isVisible;
        private int visibilityConditionTypeID;

        public P2PWidget()
        {

        }
        public P2PWidget(int widgetID,int containerID,Enumerators.Answere locked, string properties,int sortOrder
            ,string p2pwidgetTypeId,
            Enumerators.Answere isRequired
            , Enumerators.Answere isVisible,int visibilityConditionTypeID)
        {
            this.widgetID = widgetID;
            this.containerID = containerID;
            this.locked = locked;
            this.properties = properties;
            this.sortOrder = sortOrder;
            this.p2pWidgetTypeId = p2pwidgetTypeId;
            this.isRequired = isRequired;
            this.isVisible = isVisible;
            this.visibilityConditionTypeID = visibilityConditionTypeID;
        }

        public int WidgetId { get { return widgetID; } set { widgetID = value; } }
        public int ContainerID { get { return containerID; } set { widgetID = value; } }
        public Enumerators.Answere Locked { get { return locked; } set { locked = value; } }
        public string Properties { get { return properties; } set { properties = value; } }
        public int SortOrder { get { return sortOrder; } set { sortOrder = value; } }
        public string P2PWidgetTypeID { get { return p2pWidgetTypeId; } set { p2pWidgetTypeId = value; } }
        public Enumerators.Answere IsRequired { get { return isRequired; } set { isRequired = value; } }
        public Enumerators.Answere IsVisible { get { return isVisible; } set { isVisible = value; } }
        public int VisibilityConditionTypeID { get { return visibilityConditionTypeID; } set { visibilityConditionTypeID = value; } }
    }
}
