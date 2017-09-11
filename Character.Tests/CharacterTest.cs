using System;
using Character;
using NUnit.Framework;

namespace Character.Tests
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void CreatCharacter()
        {
            Character.Character player = new Character.Character(100, Race.Elf, Alignment.Neutral);
            Assert.NotNull(player);
        }
    }
}
