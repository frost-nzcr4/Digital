using Xunit;
using Xunit.Extensions;

namespace Survival_on_island.Tests
{
    public class PersTests
    {
        [Theory]
        [InlineData("Герой", 1, 2, 3, 4, 5, 6)]
        public void Pers(string name, int NavSob, int NavHunt, int NavFish, int NavBuild, int NavNauka, int NavMed)
        {
            Items pers = new Pers(name, NavSob, NavHunt, NavFish, NavBuild, NavNauka, NavMed);
            Assert.Equal(name, pers.name);
            Assert.Equal(NavSob, pers.NavSob);
            Assert.Equal(NavHunt, pers.NavHunt);
            Assert.Equal(NavFish, pers.NavFish);
            Assert.Equal(NavBuild, pers.NavBuild);
            Assert.Equal(NavNauka, pers.NavNauka);
            Assert.Equal(NavMed, pers.NavMed);
        }
    }
}
