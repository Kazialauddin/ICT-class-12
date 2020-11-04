using CheckUp.Infrustucture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUp.Repo
{
    class Reposit : InterfaceAll
    {
        public void Details()
        {
            Console.WriteLine("Check");
        }
        public void AllFault()
        {
            Console.WriteLine("Next prob");
        }
    }

}
