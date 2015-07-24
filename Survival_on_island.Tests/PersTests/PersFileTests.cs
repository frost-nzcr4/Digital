using System.IO;
using Xunit;
using Xunit.Extensions;

namespace Survival_on_island.Tests.PersTests
{
    public class PersFileTests
    {
        private string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        //private string projectPath = Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;

        [Theory]
        [InlineData("Герой", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)]
        public void Load(string name, int NavSob, int NavHunt, int NavFish, int NavCraft, int NavNauka, int NavMed,
            int hp, int def, int od, int damage)
        {
            string fixturePersIn = Path.Combine(projectPath, "PersTests", "fixtures", "Pers.json");

            Pers pers = PersFile.Load(fixturePersIn);
            Assert.Equal(name, pers.name);
            Assert.Equal(NavSob, pers.NavSob);
            Assert.Equal(NavHunt, pers.NavHunt);
            Assert.Equal(NavFish, pers.NavFish);
            Assert.Equal(NavCraft, pers.NavCraft);
            Assert.Equal(NavNauka, pers.NavNauka);
            Assert.Equal(NavMed, pers.NavMed);
            Assert.Equal(hp, pers.hp);
            Assert.Equal(def, pers.def);
            Assert.Equal(od, pers.od);
            Assert.Equal(damage, pers.damage);
        }

        [Theory]
        [InlineData("Герой", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)]
        public void Save(string name, int NavSob, int NavHunt, int NavFish, int NavCraft, int NavNauka, int NavMed,
            int hp, int def, int od, int damage)
        {
            Pers pers1 = new Pers(name, NavSob, NavHunt, NavFish, NavCraft, NavNauka, NavMed, hp, def, od, damage);
            string fixturePersOut = Path.Combine(projectPath, "PersTests", "fixtures", pers1.EscapeName() + ".json");

            PersFile.Save(pers1, fixturePersOut);
            Pers pers2 = PersFile.Load(fixturePersOut);
            File.Delete(fixturePersOut);
            Assert.Equal(pers1.name, pers2.name);
            Assert.Equal(pers1.NavSob, pers2.NavSob);
            Assert.Equal(pers1.NavHunt, pers2.NavHunt);
            Assert.Equal(pers1.NavFish, pers2.NavFish);
            Assert.Equal(pers1.NavCraft, pers2.NavCraft);
            Assert.Equal(pers1.NavNauka, pers2.NavNauka);
            Assert.Equal(pers1.NavMed, pers2.NavMed);
            Assert.Equal(pers1.hp, pers2.hp);
            Assert.Equal(pers1.def, pers2.def);
            Assert.Equal(pers1.od, pers2.od);
            Assert.Equal(pers1.damage, pers2.damage);
        }
    }
}
