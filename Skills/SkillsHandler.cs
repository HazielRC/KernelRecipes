using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using KernelRecipes.Skills;

namespace KernelRecipes
{
    internal class SkillsHandler
    {
        public static List<Skill> skills()
        {
            if (!Directory.Exists(Path.Combine("Kernel", "KernelRecipes", "Skills"))) Directory.CreateDirectory(Path.Combine("Kernel", "KernelRecipes", "Skills"));
            List<Skill> list = new List<Skill>();
            var files = Directory.GetFiles(Path.Combine("Kernel", "KernelRecipes", "Skills"), "*.json");
            foreach (var file in files)
            {
                Skill recipe = JsonConvert.DeserializeObject<Skill>(File.ReadAllText(file));
                list.Add(recipe);
            }
            return list;
        }
    }
}
