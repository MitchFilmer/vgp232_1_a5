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
            Character.Character player;

            // load the character
            player = PersistentData.PersistentData.Deserialize<Character.Character>("player.xml");
            if (player == null)
            {
				Console.WriteLine("No player found, creating new default character");
                player = new Character.Character(100, Races.Elf, Alignments.Neutral);
            }

            CharacterManager characterManager = CharacterManager.Instance;
            characterManager.Player = player;
            Character.Character enemyOne = new Character.Character(50, Races.Orc, Alignments.ChaoticEvil);
            Character.Character enemyTwo = new Character.Character(50, Races.Orc, Alignments.NeutralEvil);
            characterManager.AddEnemy(enemyOne);
            characterManager.AddEnemy(enemyTwo);

            // TODO: create persistent data system

            // save the player
            Console.WriteLine("Saving player");
            PersistentData.PersistentData.Serialize<Character.Character>(player, "character.xml");

            Console.WriteLine("Press return to exit...");
            Console.ReadKey();
        }
    }
}
