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
        public Team Team3;
        public Team Team4;
        public Team Team5;
        public Team Team6;

        public int team1_goals;
        public int team2_goals;
        public int team3_goals;
        public int team4_goals;
        public int team5_goals;
        public int team6_goals;


        public override string ToString()
        {
            var result = Team1 + " " + team1_goals + Environment.NewLine + Team2 + " " + team2_goals;

            return result;
        }
    }
}
