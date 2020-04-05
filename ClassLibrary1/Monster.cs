using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster: LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDemage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootItems;

        public Monster(int id, string name, int maxDemage, int rewardExp, int rewardGold, int currentHitpoints, int maxHitPoints)
            : base(currentHitpoints, maxHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDemage = maxDemage;
            RewardExperiencePoints = rewardExp;
            RewardGold = rewardGold;

            LootItems = new List<LootItem>();
        }
    }
}
