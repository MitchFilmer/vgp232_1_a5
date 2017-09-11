using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory;
using PersistentData;
using Character;

namespace vgp232_Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Systems...");
			// TODO: create inventory system

			Console.WriteLine("Initializing Inventory...");
			Inventory.Inventory inventory = new Inventory.Inventory(10);
			Item sword = new Item("Sword", 3, ItemType.equipment);
			Item potion = new Item("Potion", 2, ItemType.consumable);
			Item map = new Item("Map", 0, ItemType.key);

			Console.WriteLine("Filling Inventory...");
			inventory.Add(sword);
			inventory.Add(potion);
			inventory.Add(map);

            // TODO: create character system
            // TODO: create persistent data system

        }
    }
}
