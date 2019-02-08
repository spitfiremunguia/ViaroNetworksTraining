using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class P2PContainerContent
    {
        private int containerID;
        private Enumerators.LanguageCode languageCode;
        public P2PContainerContent()
        {

        }
        public P2PContainerContent(int containerID, Enumerators.LanguageCode languageCode)
        {
            this.containerID = containerID;
            this.languageCode = languageCode;
        }
        public int ContainerID { get { return containerID; } set { containerID = value; } }
        public Enumerators.LanguageCode LanguageCode { get { return languageCode; } set { languageCode = value; } }
    }
}
