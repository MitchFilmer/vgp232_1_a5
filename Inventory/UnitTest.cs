using System;
using Inventory;
using NUnit.Framework;

namespace UnitTest
{
	[TestFixture]
    public class UnitTest
    {
		[Test]
		public void CreateInventory()
		{
			Inventory.Inventory inventory = new Inventory.Inventory(10);
			Assert.NotNull(inventory);
		}

		[Test]
		public void CreateItems()
		{
			Item sword = new Item("Sword", 3, ItemType.equipment);
			Assert.NotNull(sword);

			Item potion = new Item("Potion", 2, ItemType.consumable);
			Assert.NotNull(potion);

			Item map = new Item("Map", 0, ItemType.key);
			Assert.NotNull(map);
		}

		[Test]
		public void TestAddItems()
		{
			Inventory.Inventory inventory = new Inventory.Inventory(10);
			Item sword = new Item("Sword", 3, ItemType.equipment);
			Item potion = new Item("Potion", 2, ItemType.consumable);
			Item map = new Item("Map", 0, ItemType.key);

			inventory.Add(sword);
			inventory.Add(potion);
			inventory.Add(map);
			Assert.IsTrue(inventory.GetSize() == 3);

			inventory.Remove(potion);
			Assert.IsTrue(inventory.GetSize() == 2);

		}
    }
}
