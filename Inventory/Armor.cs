using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Armor : Item
    {
        int defense;

        public Armor(string name, int modifier, int defense) : base(name, modifier, ItemType.equipment)
        {
            this.defense = defense;
        }
    }
}
