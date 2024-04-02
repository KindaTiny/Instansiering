using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instansiering
{
    public class Statistik
    {
        public Team Statistik_team; //holdet                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        public int K; //Kampe
        public int V; //Vundne kampe
        public int U; //Uafgjordte kampe
        public int T; // Tabte Kampe
        public int Pscore; // scoringer
        public int Mscore; // Scoret på
        public int Point; //point, (3 per vundet kamp)


        public override string ToString()
        {
            var result = Statistik_team + " " + K + " " + V + " " + U + " " + T + " " + Pscore + " " + Mscore + Environment.NewLine;
            return result;
        }
    }
}