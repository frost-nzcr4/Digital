using System.IO;

namespace Survival_on_island
{
    public class Pers
    {
        public string name;

        //навыки
        public int NavSob;
        public int NavHunt;
        public int NavFish;
        public int NavBuild;
        public int NavNauka;
        public int NavMed;

        /// <summary>
        /// Initializes a new instance of the <see cref="Survival_on_island.Pers"/> class.
        /// </summary>
        /// <param name="name1">Имя персонажа.</param>
        /// <param name="NavSob1">Навык собирательства.</param>
        /// <param name="NavHunt1">Навык охоты.</param>
        /// <param name="NavFish1">Навык рыбалки.</param>
        /// <param name="NavBuild1">Навык строительства.</param>
        /// <param name="NavNauka1">Навык науки.</param>
        /// <param name="NavMed1">Навык медицины.</param>
        public Pers (string name1, int NavSob1, int NavHunt1, int NavFish1, int NavBuild1, int NavNauka1, int NavMed1)
        {
            name = name1;
            NavSob = NavSob1;
            NavHunt = NavHunt1;
            NavFish = NavFish1;
            NavBuild = NavBuild1;
            NavNauka = NavNauka1;
            NavMed = NavMed1;
        }

        /// <summary>
        /// Escapes the name to write JSON to it.
        /// </summary>
        /// <returns>The name.</returns>
        public string EscapeName()
        {
            // TODO: Надо проверять на валидность или экранировать this.name, т. к. там могут быть невалидные символы
            // непригодные для имени файла.
            return name;
        }

        /// <summary>
        /// Save this instance to predefined filename.
        /// </summary>
        public void Save()
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filename = Path.Combine(projectPath, "saves", EscapeName() + ".json");
            Save(filename);
        }

        /// <summary>
        /// Save this instance to specified filename.
        /// </summary>
        /// <param name="filename">Filename.</param>
        public void Save(string filename)
        {
            PersFile.Save(this, filename);
        }
    }
}
