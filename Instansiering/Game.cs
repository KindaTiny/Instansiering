using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instansiering
{
    public class Game
    {
        public Team Team1;
        public Team Team2;

        public int team1_goals;
        public int team2_goals;

        /*//V1 
       public override string ToString()
       {
           var result = Team1 + "), // " + Team2 + "), T1M = " + team1_goals + ", T2M = " + team2_goals + Environment.NewLine;
           return result;
       }
       */
        //V2
        public override string ToString()
        {
            var result = Team1 + ", " + Team2 + ", T1M = " + team1_goals + ", T2M = " + team2_goals + Environment.NewLine;
            return result;
        }
        
    }
}
