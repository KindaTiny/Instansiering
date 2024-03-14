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


        public override string ToString()
        {
            var result = Team1 + " " + team1_goals + Environment.NewLine + Team2 + " " + team2_goals + Environment.NewLine;

            return result;
        }
    }
}
