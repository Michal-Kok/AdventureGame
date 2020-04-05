using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon: Item
    {
        public int MaximumDemage { get; set; }
        public int MinimumDemage { get; set; }

        public Weapon(int id, string name, string nameplural, int maxDemage, int minDemage) : base(id, name, nameplural)
        {
            MaximumDemage = maxDemage;
            MinimumDemage = minDemage;
        }
    }
}
