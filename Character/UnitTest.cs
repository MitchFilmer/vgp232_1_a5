using System;
using Character;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    class UnitTest
    {
        [Test]
        public void TakeDamageTest()
        {
            Character.Character player = new Character.Character(100, Races.Elf, Alignments.Neutral);
            player.TakeDamage(10);
            Assert.IsTrue(player.GetHealth() == 90);
        }

        [Test]
        public void RestoreHealthTest()
        {
            Character.Character player = new Character.Character(100, Races.Elf, Alignments.Neutral);
            player.RestoreHealth(10);
            Assert.IsTrue(player.GetHealth() == 110);
        }

        [Test]
        public void AddEnemyTest()
        {
            CharacterManager characterManager = CharacterManager.Instance;

            Character.Character enemyOne = new Character.Character(50, Races.Orc, Alignments.ChaoticEvil);
            Character.Character enemyTwo = new Character.Character(50, Races.Orc, Alignments.NeutralEvil);
            characterManager.AddNPC(enemyOne);
            characterManager.AddNPC(enemyTwo);

            characterManager.RemoveNPC(enemyTwo);
            Assert.IsTrue(characterManager.GetNPCListSizeTest() == 1);
        }
    }
}
