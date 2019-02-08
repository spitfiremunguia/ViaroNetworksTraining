using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Project
{
    class ContainerService:IContainerService
    {
        public ContainerService()
        {

        }
        public ContainerRepository[] CreateContainerRepos(int nTimes)
        {
            ContainerRepository[] r = new ContainerRepository[nTimes];
            for (int i = 0; i < nTimes; i++)
            {
                r[i] = new ContainerRepository(i);
            }
            return r;
        }

        public void PrintRepositories(ContainerRepository[] Repos, Delegates.ContainerManager Manager)
        {
            for (int i = 0; i < Repos.Length; i++)
            {
                Manager(Repos[i]);
            }
        }
    }
}
