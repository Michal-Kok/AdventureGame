using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public Location CurrentLocation { get; set; }
        public List<InventioryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;

            Inventory = new List<InventioryItem>();
            Quests = new List<PlayerQuest>();
        }

        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if(location.ItemRequiredToEnter == null)
            {
                return true;
            }
            foreach (InventioryItem ii in Inventory)
            {
                if (ii.Details.ID == location.ItemRequiredToEnter.ID)
                    return true;
            }
            return false;
        }

        public  bool HasThisQuest(Quest quest)
        {
            foreach ( PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.Details.ID == quest.ID)
                    return true;
            }

            return false;
        }

        public bool CompletedThisQuest(Quest quest)
        {
            foreach  ( PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.Details.ID == quest.ID)
                    return playerQuest.IsCompleted;
            }
            return false;
        }

        public bool HasAllQuestCompletionItems(Quest quest)
        {
            foreach ( QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                bool FoundItem = false;
                foreach (InventioryItem item in Inventory)
                {
                    if(item.Details.ID == qci.Details.ID)
                    {
                        FoundItem = true;
                    }

                    if (item.Quantity < qci.Quantity)
                        return false;

                }
                if (!FoundItem)
                    return false;
            }
            return true;   
        }
    }
}