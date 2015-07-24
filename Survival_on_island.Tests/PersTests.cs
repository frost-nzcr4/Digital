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
            Pers pers = new Pers(name, NavSob, NavHunt, NavFish, NavBuild, NavNauka, NavMed);
            Assert.Equal(name, pers.name);
            Assert.Equal(NavSob, pers.NavSob);
            Assert.Equal(NavHunt, pers.NavHunt);
            Assert.Equal(NavFish, pers.NavFish);
            Assert.Equal(NavBuild, pers.NavBuild);
            Assert.Equal(NavNauka, pers.NavNauka);
            Assert.Equal(NavMed, pers.NavMed);
        }

        [Theory]
        [InlineData("Герой", 1, 2, 3, 4, 5, 6, "PersTests/fixtures/pers.json")]
        public void Load(string name, int NavSob, int NavHunt, int NavFish, int NavBuild, int NavNauka, int NavMed, string filename)
        {
            Pers pers = Pers.Load(filename);
            Assert.Equal(name, pers.name);
            Assert.Equal(NavSob, pers.NavSob);
            Assert.Equal(NavHunt, pers.NavHunt);
            Assert.Equal(NavFish, pers.NavFish);
            Assert.Equal(NavBuild, pers.NavBuild);
            Assert.Equal(NavNauka, pers.NavNauka);
            Assert.Equal(NavMed, pers.NavMed);
        }

        [Theory]
        [InlineData("Герой", 1, 2, 3, 4, 5, 6, "PersTests/fixtures/pers.json", "PersTests/fixtures/pers-out.json")]
        public void Save(string name, int NavSob, int NavHunt, int NavFish, int NavBuild, int NavNauka, int NavMed, string filename, string filenameToSave)
        {
            Pers pers1 = new Pers(name, NavSob, NavHunt, NavFish, NavBuild, NavNauka, NavMed);
            Pers.Save(pers1, fixturePersOut);
            Pers pers2 = Pers.Load(filenameToSave);
            Assert.Equal(pers1.name, pers2.name);
            Assert.Equal(pers1.NavSob, pers2.NavSob);
            Assert.Equal(pers1.NavHunt, pers2.NavHunt);
            Assert.Equal(pers1.NavFish, pers2.NavFish);
            Assert.Equal(pers1.NavBuild, pers2.NavBuild);
            Assert.Equal(pers1.NavNauka, pers2.NavNauka);
            Assert.Equal(pers1.NavMed, pers2.NavMed);
        }
    }
}
