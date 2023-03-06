using BrokeProtocol.API;
using BrokeProtocol.Managers;

namespace KernelRecipes
{
    public class Core : Plugin
    {
        public static Core Instance { get; private set; }
        public EntityHandler EntityHandler { get; private set; } = new EntityHandler();
        public Core()
        {
            Instance = this;
            Info = new PluginInfo("Kernel Recipes", "craft");

            // Initialize Entities
            EntityHandler.LoadEntities();

        }
    }
}
