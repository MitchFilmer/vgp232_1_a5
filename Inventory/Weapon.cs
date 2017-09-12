using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Weapon : Item
    {
        int damage;

        public Weapon(string name, int weight, int damage) : base (name, weight, ItemType.equipment)
        {
            this.damage = damage;
        }
    }
}
