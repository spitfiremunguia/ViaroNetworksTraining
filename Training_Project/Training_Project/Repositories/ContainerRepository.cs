using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class ContainerRepository:IContainerRepository
    {


        public P2PContainer MyContainer { get; set; }
        public P2PContainerContent MyContentContainer { get; set; }
        public ContainerRepository(int ID)
        {
            CreateContainer(ID);
        }

        public void CreateContainer(int ID)
        {
            MyContainer = new P2PContainer(ID,
                0,Enumerators.PageType.Dontaion,Utilities.getJson("json.txt"),Enumerators.Answere.n,Enumerators.Answere.n,
                Utilities.Random(),Utilities.Random());

            MyContentContainer = new P2PContainerContent(ID,Enumerators.LanguageCode.en_CA);
        }
    }
}
