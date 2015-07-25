using System.IO;
using Xunit;
using Xunit.Extensions;

namespace Survival_on_island.Tests.PersTests
{
    public class PersTests
    {
        private string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        //private string projectPath = Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;

        [Theory]
        [InlineData("Герой", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19)]
        public void Pers(string name, int NavSob, int NavHunt, int NavFish, int NavCraft, int NavMining, int NavWood,
            int hp, int hpMax, int def, int od, int damage, int morality,
            int Strength, int Perception, int Endurance, int Will, int Intelligence, int Agility, int Luck)
        {
            Pers pers = new Pers(name, NavSob, NavHunt, NavFish, NavCraft, NavMining, NavWood,
                hp, hpMax, def, od, damage, morality,
                Strength, Perception, Endurance, Will, Intelligence, Agility, Luck);
            Assert.Equal(name, pers.name);
            Assert.Equal(NavSob, pers.NavSob);
            Assert.Equal(NavHunt, pers.NavHunt);
            Assert.Equal(NavFish, pers.NavFish);
            Assert.Equal(NavCraft, pers.NavCraft);
            Assert.Equal(NavMining, pers.NavMining);
            Assert.Equal(NavWood, pers.NavWood);

            Assert.Equal(hp, pers.hp);
            Assert.Equal(hpMax, pers.hpMax);
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

        [Fact]
        public void ChangeHP()
        {
            Pers pers = new Pers("Герой", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19);
            pers.ChangeHP(999999);
            Assert.Equal(pers.hpMax, pers.hp);
            pers.ChangeHP(-7);
            Assert.Equal(pers.hpMax - 7, pers.hp);
            pers.ChangeHP(5);
            Assert.Equal(pers.hpMax - 7 + 5, pers.hp);
            pers.ChangeHP(-999999);
            Assert.Equal(0, pers.hp);
        }

        [Fact]
        public void EscapeName()
        {
            Pers pers = new Pers("Герой", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19);
            Assert.Equal("Герой", pers.EscapeName());
            pers.name = "\\//:?";
            Assert.Equal("\\//:?", pers.EscapeName());
        }

        [Fact]
        public void IsDead()
        {
            Pers pers = new Pers("Герой", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19);
            Assert.False(pers.IsDead());
            pers.hp = 0;
            Assert.True(pers.IsDead());
        }

        [Fact]
        public void SaveWithPredefinedName()
        {
            Pers pers = new Pers("Герой", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19);
            string save_folder = Path.Combine(projectPath, "saves");
            string pers_saved = Path.Combine(projectPath, "saves", pers.EscapeName() + ".json");

            Directory.CreateDirectory(save_folder);
            pers.Save();
            Assert.True(File.Exists(pers_saved));
            File.Delete(pers_saved);
            Directory.Delete(save_folder);
        }

        [Fact]
        public void SaveWithSpecifiedName()
        {
            Pers pers = new Pers("Герой", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19);
            string save_folder = Path.Combine(projectPath, "saves");
            string pers_saved = Path.Combine(projectPath, "saves", pers.EscapeName() + "-specified-name.json");

            Directory.CreateDirectory(save_folder);
            pers.Save(pers_saved);
            Assert.True(File.Exists(pers_saved));
            File.Delete(pers_saved);
            Directory.Delete(save_folder);
        }
    }
}
