﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Monster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }
        public int MaximumDemage { get; set; }
        public int RewardExperiencePoints { get; set }
        public int RewardGold { get; set; }
    }
}