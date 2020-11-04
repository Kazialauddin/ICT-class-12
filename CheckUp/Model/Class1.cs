using CheckUp.Infrustucture;
using CheckUp.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUp.Model
{
    public class Men
    {
        private readonly InterfaceAll idata;
    
        public Men()
        {

             this.idata = new Reposit(); 
              
        }
        public string Name;
        public int Age;
        public void newSearch()
        {
            
            idata.Details();
        }

    }

}
