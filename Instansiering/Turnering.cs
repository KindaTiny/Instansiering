using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instansiering
{
    public class Turnering
    {
        public List<Game> TurneringSL;
        public Team Team1;
        public Team Team2;
        public Team Team3;
        public Team Team4;
        public Team Team5;
        public Team Team6;

        public void Turnerings()
        {
            List<Team> HoldListe = [Team1, Team2, Team3, Team4, Team5, Team6];

            Random rnd = new Random();

            //VELKOMMEN TILBAGE TIL LOOPING VILLE VÆRE EFFEKTIVT
            //  Console.WriteLine(HoldListe[rndresult]);
            //    Console.WriteLine(HoldListe[rndresult2]);


            //LAV FOR LOOPS FOR AT KUNNE ALLE KÆMPE MOD HINANDEN 5 GANGE
            //        Game game1 = new Game();
            List<Game> TurneringSL = new List<Game>();

            foreach (Team h in HoldListe)
            {
                foreach (Team m in HoldListe)
                {
                    if (m != h)
                    {
                        Game game = new Game { Team1 = h, Team2 = m, team1_goals = rnd.Next(1, 10), team2_goals = rnd.Next(1, 10) };
                        TurneringSL.Add(game);

                        // Console.WriteLine(h.Name + ", " + m.Name + ", T1M = " + game.team1_goals + ", T2M = " + game.team2_goals);

                    }
                }
            }
            List<Statistik> hold_statistik = new List<Statistik>();

            foreach (Team m in HoldListe)
            {
                Statistik s = new Statistik { Statistik_team = m };
                hold_statistik.Add(s);
                Console.Write(s);
            }


            //initializier vores hold først, så brug Foreach loop og gå igennem gamesne  (g) hvor du indsætter per                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  };
            foreach (Game g in TurneringSL)
            {
                Console.WriteLine(g.Team1 + " " + g.Team2);

                var team1_stat_obj = hold_statistik.Find(s => s.Statistik_team == g.Team1);
                var team2_stat_obj = hold_statistik.Find(s => s.Statistik_team == g.Team2);
                team1_stat_obj.K++;
                team2_stat_obj.K++;
                team1_stat_obj.Pscore = team1_stat_obj.Pscore + g.team1_goals;
                team1_stat_obj.Mscore = team1_stat_obj.Mscore + g.team2_goals;
                team2_stat_obj.Pscore = team2_stat_obj.Pscore + g.team2_goals;
                team2_stat_obj.Mscore = team2_stat_obj.Mscore + g.team1_goals;
                if (g.team1_goals > g.team2_goals)
                {
                    team1_stat_obj.V++;
                    team1_stat_obj.Point += 3;
                    team2_stat_obj.T++;
                }
                else if (g.team1_goals == g.team2_goals)
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
                }
                 ;
                //team2_stat_obj.Pscore = g.team2_goals;
            }

            List<Statistik> SortedListS = hold_statistik.OrderByDescending(o => o.Point).ToList();
            foreach (Statistik s in SortedListS)
            {

                Console.Write(s);
            }

            //unit test, entity framework
        }
    }
}

