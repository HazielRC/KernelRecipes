using System.Collections.Generic;

namespace KernelRecipes.Crafting
{
    public class Recipe
    {
        public string id { get; set; }
        public string name { get; set; }
        public string workbechId { get; set; }
        public float preparationTime { get; set; }
        public Dictionary<string, int> input { get; set; }
        public Dictionary<string, int> output { get; set; }
        public List<string> requiredSkills { get; set; }
    }
}
