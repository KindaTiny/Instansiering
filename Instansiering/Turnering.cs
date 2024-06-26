﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Instansiering
{
    public class Turnering
    {
        public List<Game> TurneringSpil;
        public List<Team> TurneringHold { get; set; }
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
        public List<Statistik> TurneringTest()
        {

            foreach (Team m in TurneringHold)
            {
                Statistik s = new Statistik { Statistik_team = m };
                hold_statistik.Add(s);
                Console.Write(s);
            }
            foreach (Game g in TurneringSpil)
            {
                {
                    Console.WriteLine(g.Team1 + " " + g.Team2);

                    var team1_stat_obj = hold_statistik.Find(s => s.Statistik_team == g.Team1);
                    var team2_stat_obj = hold_statistik.Find(s => s.Statistik_team == g.Team2);
                    team1_stat_obj.Kampe++;
                    team2_stat_obj.Kampe++;
                    team1_stat_obj.scoring = team1_stat_obj.scoring + g.Team1_goals;
                    team1_stat_obj.Mscore = team1_stat_obj.Mscore + g.Team2_goals;
                    team2_stat_obj.scoring = team2_stat_obj.scoring + g.Team2_goals;
                    team2_stat_obj.Mscore = team2_stat_obj.Mscore + g.Team1_goals;
                    if (g.Team1_goals > g.Team2_goals)
                    {
                        team1_stat_obj.VundneKampe++;
                        team1_stat_obj.Point += 3;
                        team2_stat_obj.TabteKampe++;
                    }
                    else if (g.Team1_goals == g.Team2_goals)
                    {
                        team1_stat_obj.Uafgjordt++;
                        team2_stat_obj.Uafgjordt++;
                        team1_stat_obj.Point++;
                        team2_stat_obj.Point++;
                    }
                    else
                    {
                        team2_stat_obj.VundneKampe++;
                        team2_stat_obj.Point += 3;
                        team1_stat_obj.TabteKampe++;
                    }
                    hold_statistik = hold_statistik.OrderByDescending(o => o.Point).ToList();
                    foreach (Statistik s in hold_statistik)
                    {


                        Console.Write(s);
                    }
                }
            }
            return hold_statistik;
        }
    }
}

