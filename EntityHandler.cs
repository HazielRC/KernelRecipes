using System.Collections.Generic;
using BrokeProtocol.Managers;
using BrokeProtocol.Entities;

namespace KernelRecipes
{
    public class EntityHandler
    {
        public Dictionary<string, ShItem> Items { get; set; } = new Dictionary<string, ShItem>();

        public void LoadEntities()
        {
            foreach(var entity in SceneManager.Instance.entityCollection)
            {
                if(entity.Value == null)
                {
                    continue;
                }
                if(entity.Value is ShItem)
                {
                    Items.Add(entity.Value.name, entity.Value as ShItem);
                }
            }
        }
    }
}
