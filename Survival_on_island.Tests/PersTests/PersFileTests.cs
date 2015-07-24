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
        [InlineData("Герой", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18)]
        public void Load(string name, int NavSob, int NavHunt, int NavFish, int NavCraft, int NavMining, int NavWood,
            int hp, int def, int od, int damage, int morality,
            int Strength, int Perception, int Endurance, int Will, int Intelligence, int Agility, int Luck)
        {
            string fixturePersIn = Path.Combine(projectPath, "PersTests", "fixtures", "Pers.json");

            Pers pers = PersFile.Load(fixturePersIn);
            Assert.Equal(name, pers.name);
            Assert.Equal(NavSob, pers.NavSob);
            Assert.Equal(NavHunt, pers.NavHunt);
            Assert.Equal(NavFish, pers.NavFish);
            Assert.Equal(NavCraft, pers.NavCraft);
            Assert.Equal(NavMining, pers.NavMining);
            Assert.Equal(NavWood, pers.NavWood);

            Assert.Equal(hp, pers.hp);
            Assert.Equal(def, pers.def);
            Assert.Equal(od, pers.od);
            Assert.Equal(damage, pers.damage);
            Assert.Equal(morality, pers.morality);

            Assert.Equal(Strength, pers.Strength);
            Assert.Equal(Perception, pers.Perception);
            Assert.Equal(Endurance, pers.Endurance);
            Assert.Equal(Will, pers.Will);
            Assert.Equal(Intelligence, pers.Intelligence);
            Assert.Equal(Agility, pers.Agility);
            Assert.Equal(Luck, pers.Luck);

        }

        [Theory]
        [InlineData("Герой", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18)]
        public void Save(string name, int NavSob, int NavHunt, int NavFish, int NavCraft, int NavMining, int NavWood,
            int hp, int def, int od, int damage, int morality,
            int Strength, int Perception, int Endurance, int Will, int Intelligence, int Agility, int Luck)
        {
            Pers pers1 = new Pers(name, NavSob, NavHunt, NavFish, NavCraft, NavMining, NavWood,
                hp, def, od, damage, morality,
                Strength, Perception, Endurance, Will, Intelligence, Agility, Luck);
            string fixturePersOut = Path.Combine(projectPath, "PersTests", "fixtures", pers1.EscapeName() + ".json");

            PersFile.Save(pers1, fixturePersOut);
            Pers pers2 = PersFile.Load(fixturePersOut);
            File.Delete(fixturePersOut);
            Assert.Equal(pers1.name, pers2.name);
            Assert.Equal(pers1.NavSob, pers2.NavSob);
            Assert.Equal(pers1.NavHunt, pers2.NavHunt);
            Assert.Equal(pers1.NavFish, pers2.NavFish);
            Assert.Equal(pers1.NavCraft, pers2.NavCraft);
            Assert.Equal(pers1.NavMining, pers2.NavMining);
            Assert.Equal(pers1.NavWood, pers2.NavWood);

            Assert.Equal(pers1.hp, pers2.hp);
            Assert.Equal(pers1.def, pers2.def);
            Assert.Equal(pers1.od, pers2.od);
            Assert.Equal(pers1.damage, pers2.damage);
            Assert.Equal(pers1.morality, pers2.morality);

            Assert.Equal(pers1.Strength, pers2.Strength);
            Assert.Equal(pers1.Perception, pers2.Perception);
            Assert.Equal(pers1.Endurance, pers2.Endurance);
            Assert.Equal(pers1.Will, pers2.Will);
            Assert.Equal(pers1.Intelligence, pers2.Intelligence);
            Assert.Equal(pers1.Agility, pers2.Agility);
            Assert.Equal(pers1.Luck, pers2.Luck);
        }
    }
}
