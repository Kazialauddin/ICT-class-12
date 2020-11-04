using CheckUp.Infrustucture;
using CheckUp.Model;
using CheckUp.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUp
{
    class Program
    {
        //private readonly Idata _idata;
        //private readonly Repo repo;
        public Program()
        {
        
        }

        static void Main(string[] args)
        {

            Men men = new Men();
            men.newSearch();
           
            Console.ReadKey();
        }
    }
    

    
    
}
