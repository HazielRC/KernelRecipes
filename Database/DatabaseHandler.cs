using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using KernelRecipes.Database;

namespace KernelRecipes
{
    public class DatabaseHandler
    {
        public static List<PlPlayer> players()
        {
            if (!Directory.Exists(Path.Combine("Kernel", "Database", "Players"))) Directory.CreateDirectory(Path.Combine("Kernel", "Database", "Players"));

            var files = Directory.GetFiles(Path.Combine("Kernel", "Database", "Players"), "*.json");
            var p = new List<PlPlayer>();
            foreach (var file in files)
            {
                PlPlayer pj = JsonConvert.DeserializeObject<PlPlayer>(File.ReadAllText(file));
                p.Add(pj);
            }
            return p;
        }
        public static void SavePlayer(PlPlayer player)
        {
            File.WriteAllText(Path.Combine("Kernel", "Database", "Players", $"{player.username}.json"), JsonConvert.SerializeObject(player, Formatting.Indented));
        }
    }
}
