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
    }
}