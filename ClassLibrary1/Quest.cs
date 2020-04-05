using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoint { get; set; }
        public int RewardGold { get; set; }

        public List<QuestCompletionItem> QuestCompletionItems;

        public Quest(int id, string name, string description, int rewardExpPoints, int rewardGold, Item rewardItem)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoint = rewardExpPoints;
            RewardGold = rewardGold;
            RewardItem = rewardItem;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }

        public Item RewardItem { get; set; }
    }
}
