using System.Collections.Generic;
using KernelRecipes.Skills;

namespace KernelRecipes.Database
{
    public class PlPlayer
    {
        public string username { get; set; }
        public int knowledge { get; set; }
        public List<Skill> skills { get; set; }
    }
}
