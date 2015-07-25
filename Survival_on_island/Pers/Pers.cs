using Newtonsoft.Json;
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
        public int NavCraft;
        public int NavMining;
        public int NavWood;

        // Параметры.
        public int hp;
        public int hpMax;
        public int def;
        public int od;
        public int damage;
        public int morality;

        // Характеристики.
        public int Strength;
        public int Perception;
        public int Endurance;
        public int Will;
        public int Intelligence;
        public int Agility;
        public int Luck;

        /// <summary>
        /// Короткая инициализация персонажа <see cref="Survival_on_island.Pers"/> только по имени.
        /// </summary>
        /// <remarks>
        /// Используется при создании новой игры.
        /// </remarks>
        /// <param name="name1">Имя персонажа.</param>
        public Pers(string name1)
        {
            Initialize(name1,
                20, 20, 20, 20, 20, 20,
                0, 0, 0, 0, 0, 0,
                5, 5, 5, 5, 5, 5, 5);
        }

        /// <summary>
        /// Полная инициализация персонажа <see cref="Survival_on_island.Pers"/> по всем переменным.
        /// </summary>
        /// <remarks>
        /// Используется при восстановлении сохранённой игры.
        /// </remarks>
        /// <param name="name1">Имя персонажа.</param>
        /// <param name="NavSob1">Навык собирательства.</param>
        /// <param name="NavHunt1">Навык охоты.</param>
        /// <param name="NavFish1">Навык рыбалки.</param>
        /// <param name="NavCraft1">Навык строительства.</param>
        /// <param name="NavMining1">Навык науки.</param>
        /// <param name="NavWood1">Навык медицины.</param>
        /// <param name="hp1">Здоровье.</param>
        /// <param name="def1">Защита.</param>
        /// <param name="od1">Очки действия.</param>
        /// <param name="damage1">Урон.</param>
        /// <param name="morality1">Morality1.</param>
        /// <param name="Strength1">Сила.</param>
        /// <param name="Perception1">Восприятие.</param>
        /// <param name="Endurance1">Выносливость.</param>
        /// <param name="Will1">Воля.</param>
        /// <param name="Intelligence1">Intelligence1.</param>
        /// <param name="Agility1">Agility1.</param>
        /// <param name="Luck1">Удача.</param>
        [JsonConstructor]
        public Pers (string name1, int NavSob1, int NavHunt1, int NavFish1, int NavCraft1, int NavMining1, int NavWood1,
            int hp1, int hpMax1, int def1, int od1, int damage1, int morality1,
            int Strength1, int Perception1, int Endurance1, int Will1, int Intelligence1, int Agility1, int Luck1)
        {
            Initialize(
                name1,
                NavSob1, NavHunt1, NavFish1, NavCraft1, NavMining1, NavWood1,
                hp1, hpMax1, def1, od1, damage1, morality1,
                Strength1, Perception1, Endurance1, Will1, Intelligence1, Agility1, Luck1);
        }

        /// <summary>
        /// Присваивает значения переменным.
        /// </summary>
        private void Initialize(
            string name1,
            int NavSob1, int NavHunt1, int NavFish1, int NavCraft1, int NavMining1, int NavWood1,
            int hp1, int hpMax1, int def1, int od1, int damage1, int morality1,
            int Strength1, int Perception1, int Endurance1, int Will1, int Intelligence1, int Agility1, int Luck1)
        {
            name = name1;

            NavSob = NavSob1;
            NavHunt = NavHunt1;
            NavFish = NavFish1;
            NavCraft = NavCraft1;
            NavMining = NavMining1;
            NavWood = NavWood1;

            hp = hp1;
            hpMax = hpMax1;
            def = def1;
            od = od1;
            damage = damage1;
            morality = morality1;

            Strength = Strength1;
            Perception = Perception1;
            Endurance = Endurance1;
            Will = Will1;
            Intelligence = Intelligence1;
            Agility = Agility1;
            Luck = Luck1;
        }

        /// <summary>
        /// Безопасно изменяет текущее значение HP.
        /// </summary>
        /// <remarks>
        /// Значение HP гарантированно не будет больше hpMax или меньше 0.
        /// </remarks>
        /// <param name="hpChange">Значение на которое изменяется текущее HP. Положительное или отрицательное число.</param>
        public void ChangeHP(int hpChange)
        {
            if (hp + hpChange > hpMax) {
                hp = hpMax;
            } else if (hp + hpChange < 0) {
                hp = 0;
            } else {
                hp = hp + hpChange;
            }
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
        /// Возвращает путь к папке для сохранения.
        /// </summary>
        /// <returns>Папка для сохранения.</returns>
        public string GetPathToSave()
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string save_folder = Path.Combine(projectPath, "saves");

            return save_folder;
        }

        /// <summary>
        /// Определяет мёртв ли персонаж.
        /// </summary>
        /// <returns><c>true</c> если мёртв; иначе, <c>false</c>.</returns>
        public bool IsDead()
        {
            return hp <= 0 ? true : false;
        }

        /// <summary>
        /// Загружает данные и перезаписывает ими значения переменных у данного экземпляра.
        /// </summary>
        public void Load()
        {
            string filename = Path.Combine(GetPathToSave(), EscapeName() + ".json");
            Load(filename);
        }

        /// <summary>
        /// Загружает данные из указанного файла и перезаписывает ими значения переменных у данного экземпляра.
        /// </summary>
        /// <param name="filename">Путь к файлу.</param>
        public void Load(string filename)
        {
            Pers pers_loaded = PersFile.Load(filename);
            Initialize(
                pers_loaded.name,
                pers_loaded.NavSob, pers_loaded.NavHunt, pers_loaded.NavFish, pers_loaded.NavCraft, pers_loaded.NavMining, pers_loaded.NavWood,
                pers_loaded.hp, pers_loaded.hpMax, pers_loaded.def, pers_loaded.od, pers_loaded.damage, pers_loaded.morality,
                pers_loaded.Strength, pers_loaded.Perception, pers_loaded.Endurance, pers_loaded.Will, pers_loaded.Intelligence, pers_loaded.Agility, pers_loaded.Luck);
        }

        /// <summary>
        /// Save this instance to predefined filename.
        /// </summary>
        public void Save()
        {
            string filename = Path.Combine(GetPathToSave(), EscapeName() + ".json");
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
