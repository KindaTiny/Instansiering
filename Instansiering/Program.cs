using Instansiering;
using System.Collections.Generic;
using System.Runtime.Versioning;

public class Test
{

    public static void Main(string[] args)
    {
        randomMetode();
    }

    
    public static void Metode()
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

        Game game1 = new Game { Team1 = team1, Team2 = team2, team1_goals = 4, team2_goals = 2 };

        Console.WriteLine(game1);

    }
    public static void randomMetode()
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
        List<Player> PlayerList1 = new List<Player>();
        List<Player> PlayerList2 = new List<Player>();
        List<Player> PlayerList3 = new List<Player>();
        List<Player> PlayerList4 = new List<Player>();
        List<Player> PlayerList5 = new List<Player>();
        List<Player> PlayerList6 = new List<Player>();
        PlayerList1.Add(player1);
        PlayerList1.Add(player2);
        PlayerList2.Add(player3);
        PlayerList2.Add(player4);
        PlayerList3.Add(player5);
        PlayerList3.Add(player6);
        PlayerList4.Add(player7);
        PlayerList4.Add(player8);
        PlayerList5.Add(player9);
        PlayerList5.Add(player10);
        PlayerList6.Add(player11);
        PlayerList6.Add(player12);
        //BURDE STÆRKT FINDE UD AF AT LOOPE DET HER
        Team team1 = new Team { Name = "Aab" };
        Team team2 = new Team { Name = "SønderJyske" };
        Team team3 = new Team { Name = "Vendsyssel FF" };
        Team team4 = new Team { Name = "FC Fredericia" };
        Team team5 = new Team { Name = "Kolding IF" };
        Team team6 = new Team { Name = "Hobro IK" };

        List<Team> HoldListe = new List<Team>();
        HoldListe.Add(team1);
        HoldListe.Add(team2);
        HoldListe.Add(team3);
        HoldListe.Add(team4);
        HoldListe.Add(team5);
        HoldListe.Add(team6);

        Random rnd = new Random();
        int rndresult = rnd.Next(1, 6);
        int rndresult2 = rnd.Next(1, 6);
        //VELKOMMEN TILBAGE TIL LOOPING VILLE VÆRE EFFEKTIVT
        int rndgoalresult = rnd.Next(1, 10);
        int rndgoalresult2 = rnd.Next(1, 10);
        Console.WriteLine(HoldListe[rndresult]);
        Console.WriteLine(HoldListe[rndresult2]);
        //LAV FOR LOOPS FOR AT KUNNE ALLE KÆMPE MOD HINANDEN 5 GANGE
        foreach (Team h in HoldListe)
        {
            foreach (Team m in HoldListe)
            {
                if (m != h)
                {
                    Console.WriteLine(h + "vs" + m);
                }
            }
        }
    }
}