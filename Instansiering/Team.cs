using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instansiering
{
    public class Team
    {
        public string Name;
        public string City;
       public List<Player> PlayerList;
      
        public override string ToString()
        {
            var result = Name;
            return result;
        }
        
    }
}