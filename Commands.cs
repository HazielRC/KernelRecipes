using System;
using System.Linq;
using BrokeProtocol.API;using BrokeProtocol.Entities;
using KernelRecipes.Util;

namespace KernelRecipes
{
    public class Commands : IScript
    {
        public Commands()
        {
            CommandHandler.RegisterCommand("AddKnowledge", new Action<ShPlayer, int, ShPlayer>(Command_AddKnowledge), null, "AddKnowledge");
            CommandHandler.RegisterCommand("AddXP", new Action<ShPlayer, int, ShPlayer>(Command_AddKnowledge), null, "AddKnowledge");
            CommandHandler.RegisterCommand("GetSkills", new Action<ShPlayer, ShPlayer>(Command_GetSkills), null, "GetSkills");
        }

        public void Command_AddKnowledge(ShPlayer player, int ammount = 10, ShPlayer target = null)
        {
            target = target ?? player;
            KnowledgeManager.AddKnowledge(target.username, ammount);
            target.svPlayer.SendGameMessage(string.Format(TranslationsHandler.knowledge().AddedKnowledge, ammount));
        }
        public void Command_GetSkills(ShPlayer player, ShPlayer target = null)
        {
            target = target ?? player;
            var entity = DatabaseHandler.players().FirstOrDefault(x => x.username == target.username);
            var skills = string.Format(TranslationsHandler.knowledge().KnowledgeMenu, entity.knowledge, Environment.NewLine);
            foreach(var skill in entity.skills)
            {
                skills += string.Format("{0}{2}{1}{2}{2}", skill.name, skill.description, Environment.NewLine);
            }
            player.svPlayer.SendTextMenu("Player Skills", skills, "menu.player.skills");
        }

    }
}
