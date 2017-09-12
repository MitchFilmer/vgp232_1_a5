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

            // Creates an inventory and items
			Console.WriteLine("Initializing Inventory...");
			Inventory.Inventory inventory = new Inventory.Inventory(10);
			Item sword = new Item("Sword", 3, ItemType.equipment);
			Item potion = new Item("Potion", 2, ItemType.consumable);
			Item map = new Item("Map", 0, ItemType.key);

            // adds items into inventory
			Console.WriteLine("Filling Inventory...");
			inventory.Add(sword);
			inventory.Add(potion);
			inventory.Add(map);

            Console.WriteLine("Initializing Character Manager");
            Character.Character player = new Character.Character(100, Race.Elf, Alignment.Neutral);
            CharacterManager characterManager = CharacterManager.Instance;
            characterManager.Player = player;
            Character.Character enemyOne = new Character.Character(50, Race.Orc, Alignment.ChaoticEvil);
            Character.Character enemyTwo = new Character.Character(50, Race.Orc, Alignment.NeutralEvil);
            characterManager.AddEnemy(enemyOne);
            characterManager.AddEnemy(enemyTwo);

            // TODO: create persistent data system

            Console.ReadKey();

        }
    }
}
