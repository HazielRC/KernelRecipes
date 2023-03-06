using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using KernelRecipes.Translations;

namespace KernelRecipes
{
    public class TranslationsHandler
    {
        public static KnowledgeTranslation knowledge()
        {
            if (!Directory.Exists(Path.Combine("Kernel", "KernelRecipes", "Translations"))) Directory.CreateDirectory(Path.Combine("Kernel", "KernelRecipes", "Translations"));
            if(!File.Exists(Path.Combine("Kernel", "KernelRecipes", "Translations", "Knowledge.json")))
            {
                KnowledgeTranslation translation = new KnowledgeTranslation()
                {
                    AddedKnowledge = "&2[&fRECIPES&2] &fUna gran persona te dio &a{0} &fde conocimiento.",
                    RemovedKnowledge = "&2[&fRECIPES&2] &fPerdiste &4{0} &fde conocimiento.",
                    KnowledgeMenu = "&aTu conocimiento: &f{0}{1}{1}{1}"
                };
                File.WriteAllText(Path.Combine("Kernel", "KernelRecipes", "Translations", "Knowledge.json"), JsonConvert.SerializeObject(translation, Formatting.Indented));
            }
            return JsonConvert.DeserializeObject<KnowledgeTranslation>(Path.Combine("Kernel", "KernelRecipes", "Translations", "Knowledge.json"));
        }
    }
}
