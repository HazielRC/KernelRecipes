using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using KernelRecipes.Learning;

namespace KernelRecipes
{
    public class LearningHandler
    {
        public static List<Book> books()
        {
            if (!Directory.Exists(Path.Combine("Kernel", "KernelRecipes", "Books"))) Directory.CreateDirectory(Path.Combine("Kernel", "KernelRecipes", "Books"));
            List<Book> list = new List<Book>();
            var files = Directory.GetFiles(Path.Combine("Kernel", "KernelRecipes", "Books"), "*.json");
            foreach (var file in files)
            {
                Book book = JsonConvert.DeserializeObject<Book>(File.ReadAllText(file));
                list.Add(book);
            }
            return list;
        }
    }
}
