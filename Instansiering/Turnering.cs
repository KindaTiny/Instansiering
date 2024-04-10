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

        public Turnering(List<Team> mylist)
        {
            TurneringHold = mylist;
            TurneringSpil = new List<Game>();
        }

        public void Register(Game g)
        {
            TurneringSpil.Add(g);
        }
        public void TTurnering()
        {       
            foreach (Game g in TurneringSpil)
            {
                {
                    Console.WriteLine(g.Team1 + " " + g.Team2);

                    var team1_stat_obj = hold_statistik.Find(s => s.Statistik_team == g.Team1);
                    var team2_stat_obj = hold_statistik.Find(s => s.Statistik_team == g.Team2);
                    team1_stat_obj.K++;
                    team2_stat_obj.K++;
                    team1_stat_obj.Pscore = team1_stat_obj.Pscore + g.Team1_goals;
                    team1_stat_obj.Mscore = team1_stat_obj.Mscore + g.Team2_goals;
                    team2_stat_obj.Pscore = team2_stat_obj.Pscore + g.Team2_goals;
                    team2_stat_obj.Mscore = team2_stat_obj.Mscore + g.Team1_goals;
                    if (g.Team1_goals > g.Team2_goals)
                    {
                        team1_stat_obj.V++;
                        team1_stat_obj.Point += 3;
                        team2_stat_obj.T++;
                    }
                    else if (g.Team1_goals == g.Team2_goals)
                    {
                        team1_stat_obj.U++;
                        team2_stat_obj.U++;
                        team1_stat_obj.Point++;
                        team2_stat_obj.Point++;
                    }
                    else
                    {
                        team2_stat_obj.V++;
                        team2_stat_obj.Point += 3;
                        team1_stat_obj.T++;
                    };
                    //team2_stat_obj.Pscore = g.team2_goals;

                }
            }
       } 
        
    }
}

