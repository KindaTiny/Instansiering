using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instansiering
{
    public class Turnering
    {
        public List<Game> TurneringSpil;
        public List<Team> TurneringHold {  get; set; }
        List<Statistik> hold_statistik = new List<Statistik>();

        public Turnering()
        {
            List<Team> TurneringHold; //VIl gerne lave hold her!



        }
        public void TTurnering()
        {
            foreach (Game g in TurneringSpil)
            {
                Console.WriteLine(g.Team1 + " " + g.Team2);

                var team1_stat_obj = hold_statistik.Find(s => s.Statistik_team == g.Team1);
                var team2_stat_obj = hold_statistik.Find(s => s.Statistik_team == g.Team2);
            }
        }
    }
}

