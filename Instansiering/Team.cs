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
        public int Score;

        //TEST
        /*
           public override string ToString()
            {
                var result = Name + " " + City + Environment.NewLine;
              foreach (Player p in PlayerList)
                   result += p.Name + Environment.NewLine;
                return result;
            }
        
*/ /*       //TEST
        public override string ToString()
        {
            var result = Name + " ";
            foreach (Player p in PlayerList)
                result += p.Name + " ";
            Console.Write(" ) ");
            return result;
        }
        */
         //V2
        public override string ToString()
        {
            var result = Name;
            return result;
        }
        
    }
}