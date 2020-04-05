using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player: LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        
        public List<InventioryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int gold, int expPoints, int level, int currentHitPoints, int maxHitPoints)
            : base(currentHitPoints, maxHitPoints)
        {
            Gold = gold;
            ExperiencePoints = expPoints;
            Level = level;

            Inventory = new List<InventioryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}
