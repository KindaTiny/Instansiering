using Instansiering;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Versioning;


public class Test
{ 
    public static void Main(string[] args)
   {



        Team DK = new Team { Name = "DK" };
        Team Sverige = new Team { Name = "Sverige" };
        Team BR = new Team { Name = "Brasilien" };
        List<Team> Teams = new List<Team>();
        Teams.Add(DK);
        Teams.Add(Sverige);
        Teams.Add(BR);
        //List<Game> games = new List<Game>();
        Game game1 = new Game {Team1 = DK, Team2 = Sverige, Team1_goals = 2, Team2_goals = 4,};
        Game game2 = new Game {Team1 = DK, Team2 = BR, Team1_goals = 5, Team2_goals = 3,};
        Game game3 = new Game { Team1 = Sverige, Team2 = BR, Team1_goals = 3, Team2_goals= 2,};
        
        Turnering Tur = new Turnering(Teams);
   
        
        Tur.Register(game1);
        Tur.Register(game2);
        Tur.Register(game3);

        Tur.TurneringTest();
     
        
 
    }
    public static void EtGameSetup()
    {
        

        Player player1 = new Player { Name = "Mads", Note = "...", Born = new DateTime(1998, 3, 2) };
        Player player2 = new Player { Name = "Emil", Note = "...2", Born = new DateTime(2000, 4, 25) };
        Player player3 = new Player { Name = "Alfred", Note = "...3", Born = new DateTime(1995, 12, 11) };
        Player player4 = new Player { Name = "Mikkel", Note = "...4", Born = new DateTime(1998, 11, 16) };

        List<Player> PlayerList1 = new List<Player>();
        var PlayerList2 = new List<Player>();

        PlayerList1.Add(player1);
        PlayerList1.Add(player2);
        PlayerList2.Add(player3);
        PlayerList2.Add(player4);


    
       Team team1 = new Team { Name = "FBK", City = "KøbenHavn", PlayerList = PlayerList1, };
        Team team2 = new Team { Name = "Brændby", City = "Ikke Brøndby", PlayerList = PlayerList2 };
        Game game1 = new Game { Team1 = team1, Team2 = team2, Team1_goals = 4, Team2_goals = 2 };

        Console.WriteLine(game1);

    }
    public static void SimpelTurSetup()
    {
        Player player1 = new Player { Name = "Mads", Note = "...1", Born = new DateTime(1998, 3, 2) };
        Player player2 = new Player { Name = "Emil", Note = "...2", Born = new DateTime(2000, 4, 25) };
        Player player3 = new Player { Name = "Alfred", Note = "...3", Born = new DateTime(1995, 12, 11) };
        Player player4 = new Player { Name = "Mikkel", Note = "...4", Born = new DateTime(1998, 11, 16) };
        Player player5 = new Player { Name = "Kasper", Note = "...5", Born = new DateTime(2000, 3, 14) };
        Player player6 = new Player { Name = "Jakob", Note = "...6", Born = new DateTime(1999, 8, 4) };
        Player player7 = new Player { Name = "Jeremy", Note = "...7", Born = new DateTime(1997, 4, 22) };
        Player player8 = new Player { Name = "Sigurd", Note = "...8", Born = new DateTime(1999, 2, 17) };
        Player player9 = new Player { Name = "Theis", Note = "...9", Born = new DateTime(2000, 1, 28) };
        Player player10 = new Player { Name = "Alfred", Note = "...10", Born = new DateTime(2000, 1, 25) };
        Player player11 = new Player { Name = "August", Note = "...10", Born = new DateTime(2000, 1, 25) };
        Player player12 = new Player { Name = "December", Note = "...10", Born = new DateTime(2000, 1, 25) };
        List<Player> AabPlayers = new List<Player>();
        List<Player> SønderJyskePlayers = new List<Player>();
        List<Player> VendsysselPlayers = new List<Player>();
        List<Player> FCFredericicaPlayers = new List<Player>();
        List<Player> KoldingPlayers = new List<Player>();
        List<Player> HobroPlayers = new List<Player>();
        AabPlayers.Add(player1);
        AabPlayers.Add(player2);
        SønderJyskePlayers.Add(player3);
        SønderJyskePlayers.Add(player4);
        VendsysselPlayers.Add(player5);
        VendsysselPlayers.Add(player6);
        FCFredericicaPlayers.Add(player7);
        FCFredericicaPlayers.Add(player8);
        KoldingPlayers.Add(player9);
        KoldingPlayers.Add(player10);
        HobroPlayers.Add(player11);
        HobroPlayers.Add(player12);
        //BURDE STÆRKT FINDE UD AF AT LOOPE DET HER
        Team team1 = new Team { Name = "Aab", PlayerList = AabPlayers };
        Team team2 = new Team { Name = "SønderJyske", PlayerList = SønderJyskePlayers };
        Team team3 = new Team { Name = "Vendsyssel FF", PlayerList = VendsysselPlayers };
        Team team4 = new Team { Name = "FC Fredericia", PlayerList = FCFredericicaPlayers };
        Team team5 = new Team { Name = "Kolding IF", PlayerList = KoldingPlayers };
        Team team6 = new Team { Name = "Hobro IK", PlayerList = HobroPlayers };
     
        List<Team> HoldListe = new List<Team>();
        HoldListe.Add(team1);
        HoldListe.Add(team2);
        HoldListe.Add(team3);                                                                                                                                                                                                                                                                                                                                                                                                            
        HoldListe.Add(team4);
        HoldListe.Add(team5);
        HoldListe.Add(team6);
        
        Random rnd = new Random();

        //VELKOMMEN TILBAGE TIL LOOPING VILLE VÆRE EFFEKTIVT
        //  Console.WriteLine(HoldListe[rndresult]);
        //    Console.WriteLine(HoldListe[rndresult2]);


        //LAV FOR LOOPS FOR AT KUNNE ALLE KÆMPE MOD HINANDEN 5 GANGE
        //        Game game1 = new Game();
        List<Game> TurneringSpil = new List<Game>();

        foreach (Team h in HoldListe)
        {
            foreach (Team m in HoldListe)
            {
                if (m != h)
                {
                    Game game = new Game { Team1 = h, Team2 = m, Team1_goals = rnd.Next(1, 10), Team2_goals = rnd.Next(1, 10) };
                    TurneringSpil.Add(game);

                    // Console.WriteLine(h.Name + ", " + m.Name + ", T1M = " + game.Team1_goals + ", T2M = " + game.Team2_goals);

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
    

        //unit test, entity framework

    }

}