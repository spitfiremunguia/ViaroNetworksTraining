using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    interface IContainerRepository
    {
        P2PContainer MyContainer { get; set; }
        P2PContainerContent MyContentContainer { get; set; }
        void CreateContainer(int ID);
    }
}
