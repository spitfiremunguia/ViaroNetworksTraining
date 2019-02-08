using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    interface IContainerService
    {
        ContainerRepository[] CreateContainerRepos(int nTimes);
        void PrintRepositories(ContainerRepository[]Repos,Delegates.ContainerManager Manager);
    }
}
