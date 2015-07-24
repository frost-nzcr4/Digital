using System.IO;
using Xunit;
using Xunit.Extensions;

namespace Survival_on_island.Tests
{
    public class PersTests
    {
        private static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        //private static string projectPath = Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;

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
        [InlineData("Герой", 1, 2, 3, 4, 5, 6)]
        public void Load(string name, int NavSob, int NavHunt, int NavFish, int NavBuild, int NavNauka, int NavMed)
        {
            string fixturePersIn = Path.Combine(projectPath, "PersTests", "fixtures", "Pers.json");

            Pers pers = PersFile.Load(fixturePersIn);
            Assert.Equal(name, pers.name);
            Assert.Equal(NavSob, pers.NavSob);
            Assert.Equal(NavHunt, pers.NavHunt);
            Assert.Equal(NavFish, pers.NavFish);
            Assert.Equal(NavBuild, pers.NavBuild);
            Assert.Equal(NavNauka, pers.NavNauka);
            Assert.Equal(NavMed, pers.NavMed);
        }

        [Theory]
        [InlineData("Герой", 1, 2, 3, 4, 5, 6)]
        public void Save(string name, int NavSob, int NavHunt, int NavFish, int NavBuild, int NavNauka, int NavMed)
        {
            Pers pers1 = new Pers(name, NavSob, NavHunt, NavFish, NavBuild, NavNauka, NavMed);
            string fixturePersOut = Path.Combine(projectPath, "PersTests", "fixtures", pers1.name + ".json");

            PersFile.Save(pers1, fixturePersOut);
            Pers pers2 = PersFile.Load(fixturePersOut);
            File.Delete(fixturePersOut);
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
