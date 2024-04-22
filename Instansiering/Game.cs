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

        public int Team1_goals;
        public int Team2_goals;
        public override string ToString()
        {
            var result = Team1 + ", " + Team2 + ", T1M = " + Team1_goals + ", T2M = " + Team2_goals + Environment.NewLine;
            return result;
        }
        
    }
}
