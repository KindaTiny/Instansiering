using Instansiering;
using System.Collections.Generic;
using System.Runtime.Versioning;

public class Test {
    
    public static void Main(string[] args)
    {
        metode(); 
    }
    
    
    public static void metode() { 
        Game game = new Game();
        
        Player player1 = new Player { Name = "Mads", Note = "...", Born = new DateTime(1998, 3, 2) };
        Player player2 = new Player { Name = "Emil", Note = "...2", Born = new DateTime(2000, 4, 25) };
        Player player3 = new Player { Name = "Alfred", Note = "...3", Born = new DateTime(1995, 12, 11) };
        Player player4 = new Player { Name = "Mikkel", Note = "...4", Born = new DateTime(1998, 11, 16) };
        
        List<Player> PlayerList1 = new List<Player>();
        var PlayerList2 = new List<Player>();
        
        PlayerList1.Add(player1);
        PlayerList2.Add(player2);


        Team team1 = new Team { Name = "TestForsøg1", City = "skagen", PlayerList = PlayerList1, };
        Team team2 = new Team { Name = "testForsøg2", City = "Aalborg", PlayerList = PlayerList2 };



       
        Console.WriteLine(team1.ToString());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}  