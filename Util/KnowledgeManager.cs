using System.Linq;

namespace KernelRecipes.Util
{
    public class KnowledgeManager
    {
        public static void AddKnowledge(string username, int ammount)
        {
            var player = DatabaseHandler.players().FirstOrDefault(x => x.username == username);
            player.knowledge += ammount;
            DatabaseHandler.SavePlayer(player);
        }
        public static void RemoveKnowledge(string username, int ammount)
        {
            var player = DatabaseHandler.players().FirstOrDefault(x => x.username == username);
            if (player.knowledge < ammount) return;
            player.knowledge -= ammount;
            DatabaseHandler.SavePlayer(player);
        }
    }
}
