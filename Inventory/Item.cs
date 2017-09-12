using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{

    public enum ItemType { consumable, key, equipment }

    public class Item
    {
        string name;
        int modifier;
        ItemType type;

        public Item(string name, int modifier, ItemType type)
        {
            this.name = name;
            this.modifier = modifier;
            this.type = type;
        }
    }
}
