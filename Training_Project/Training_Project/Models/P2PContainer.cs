using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class P2PContainer
    {
        private int containerID;
        private int eventID;
        private Enumerators.PageType p2pPageTypeID;
        private string properties;
        private Enumerators.Answere isHero;
        private Enumerators.Answere isHeroLocked;
        private int sortOrder;
        private int columnOrder;

        public P2PContainer()
        {

        }
        public P2PContainer(int containerID, int eventID, Enumerators.PageType p2pPageTypeID, string properties,
            Enumerators.Answere isHero, Enumerators.Answere isHeroLocked, int sortOrder, int columnOrder)
        {
            this.containerID = containerID;
            this.eventID = eventID;
            this.p2pPageTypeID = p2pPageTypeID;
            this.properties = properties;
            this.isHero = isHero;
            this.isHeroLocked = isHeroLocked;
            this.sortOrder = sortOrder;
            this.columnOrder = columnOrder;

        }

        public int ContainerId { get { return containerID; } set { containerID = value; } }
        public int EventID { get { return eventID; } set { eventID = value; } }
        public Enumerators.PageType P2PPageTypeID { get { return p2pPageTypeID; } set { p2pPageTypeID = value; } }

        public string Properties { get { return properties; } set { properties = value; } }
        public Enumerators.Answere IsHeroLocked { get { return isHeroLocked; } set { isHeroLocked = value; } }
        public Enumerators.Answere IsHero { get { return isHero; } set { isHero = value; } }

        public int SortOrder { get { return sortOrder; } set { sortOrder = value; } }
        public int ColumnOrder { get { return columnOrder; } set { columnOrder = value; } }


    }
}
