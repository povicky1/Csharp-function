using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Class2
{
    internal class Nigeria
    {
        public int id { get; set; }
        public string Region { get; set; }
        public string Name { get; set; }

        public Nigeria()
        {
            
        }
        public Nigeria(int id, string region, string name)
        {
           id = id;
            Region = region;
            Name = name;
            
        }

        public string NameofTribe()
        {
            return "this is the major tribe in : " + Region + " Region";

        }
        
    }

}
