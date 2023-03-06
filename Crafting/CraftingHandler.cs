using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using KernelRecipes.Crafting;

namespace KernelRecipes
{
    public class CraftingHandler
    {
        public static List<Recipe> Recipes()
        {
            if (!Directory.Exists(Path.Combine("Kernel", "KernelRecipes", "Recipes"))) Directory.CreateDirectory(Path.Combine("Kernel", "KernelRecipes", "Recipes"));
            List<Recipe> list = new List<Recipe>();
            var files = Directory.GetFiles(Path.Combine("Kernel", "KernelRecipes", "Recipes"), "*.json");
            foreach (var file in files)
            {
                Recipe recipe = JsonConvert.DeserializeObject<Recipe>(File.ReadAllText(file));
                list.Add(recipe);
            }
            return list;
        }
        public static List<Workbench> Workbeches()
        {
            if (!Directory.Exists(Path.Combine("Kernel", "KernelRecipes", "Workbenches"))) Directory.CreateDirectory(Path.Combine("Kernel", "KernelRecipes", "Workbenches"));
            List<Workbench> list = new List<Workbench>();
            var files = Directory.GetFiles(Path.Combine("Kernel", "KernelRecipes", "Workbenches"), "*.json");
            foreach (var file in files)
            {
                Workbench workbench = JsonConvert.DeserializeObject<Workbench>(File.ReadAllText(file));
                list.Add(workbench);
            }
            return list;
        }
    }
}
