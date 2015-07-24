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

        [Fact]
        public void EscapeName()
        {
            Pers pers = new Pers("Герой", 1, 2, 3, 4, 5, 6);
            Assert.Equal("Герой", pers.EscapeName());
            pers.name = "\\//:?";
            Assert.Equal("\\//:?", pers.EscapeName());
        }

        [Fact]
        public void SaveWithPredefinedName()
        {
            Pers pers = new Pers("Герой", 1, 2, 3, 4, 5, 6);
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
            Pers pers = new Pers("Герой", 1, 2, 3, 4, 5, 6);
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
