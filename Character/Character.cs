using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public enum Race { Dwarf, Elf, Goblin, Giant, Halfling, Orc, Vampires, Werewolf, Sphinx }
    public enum Alignment { LawfulGood, LawfulNeutral, LawfulEvil, NeutralGood, Neutral, NeutralEvil, ChaoticGood, ChaoticNeutral, ChaoticEvil }

    public class Character
    {
        int healthPoints;
        Race race;
        Alignment alignment;

        public Character(int hp, Race r, Alignment a)
        {
            healthPoints = hp;
            race = r;
            alignment = a;
        }

        public void TakeDamage(int damage)
        {
            healthPoints -= damage;
        }

        public void RestoreHealth(int amount)
        {
            healthPoints += amount;
        }
    }
}
