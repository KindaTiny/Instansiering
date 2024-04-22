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
        public int Kampe; //Kampe
        public int VundneKampe; //Vundne kampe
        public int Uafgjordt; //Uafgjordte kampe
        public int TabteKampe; // Tabte Kampe
        public int scoring; // scoringer
        public int Mscore; // Scoret på
        public int Point; //point, (3 per vundet kamp)


        public override string ToString()
        {
            var result = Statistik_team + " " + Kampe + " " + VundneKampe + " " + Uafgjordt + " " + TabteKampe + " " + scoring + " " + Mscore + " " + Point + Environment.NewLine;
            return result;
        }
    }
}