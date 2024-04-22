using Instansiering;
using System.ComponentModel.DataAnnotations;

namespace FodboldTest
{
    public class UnitTest1
    {


        [Fact]
        public void HoldSpillere()
        {
            List<Player> players1 = new List<Player>();
            players1.Add(new Player());
            players1.Add(new Player());
            Assert.Equal(2, (players1.Count));
        }
        [Fact]
        public void Kamp1()
        {
            Team DK = new Team { Name = "DK" };
            Team Sverige = new Team { Name = "Sverige" };
            Team BR = new Team { Name = "Brasilien" };
            List<Team> Teams = new List<Team>();
            Teams.Add(DK);
            Teams.Add(Sverige);
            Teams.Add(BR);

            //List<Game> games = new List<Game>();
            Game game1 = new Game { Team1 = DK, Team2 = Sverige, Team1_goals = 2, Team2_goals = 4, };
            Game game2 = new Game { Team1 = DK, Team2 = BR, Team1_goals = 5, Team2_goals = 3, };
            Game game3 = new Game { Team1 = Sverige, Team2 = BR, Team1_goals = 3, Team2_goals = 2, };

            Turnering Tur = new Turnering(Teams);

            Tur.Register(game1);
            Tur.Register(game2);
            Tur.Register(game3);

            List<Statistik> statistiks = Tur.TurneringTest();


            Team tophold = statistiks[0].Statistik_team;
            int TopPoints = statistiks[0].Point;
            Team BundHold = statistiks[2].Statistik_team;
            int BundPoints = statistiks[2].Point;
            int SverigeScoringer = statistiks[0].scoring; 

            Assert.Equal(Teams.Count, statistiks.Count);

            Assert.Equal(Sverige, tophold);

            Assert.Equal(6, TopPoints);

            Assert.Equal(BR, BundHold);

            Assert.Equal(0, BundPoints);
            
            Assert.Equal(7, SverigeScoringer);
        








        }
    }
}
