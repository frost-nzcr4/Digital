using Newtonsoft.Json;
using System;
using System.IO;

namespace Survival_on_island
{
    public static class PersFile
    {
        public static Pers Load(string filename)
        {
            var pers_file = File.ReadAllText(filename);
            Pers pers = JsonConvert.DeserializeObject<Pers>(pers_file);
            return pers;
        }

        public static void Save(Pers pers, string filename)
        {
            string json = JsonConvert.SerializeObject(pers, Formatting.Indented);
            File.WriteAllText(filename, json);
        }
    }
}
