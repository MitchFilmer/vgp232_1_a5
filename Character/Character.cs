using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public enum Races { Dwarf, Elf, Goblin, Giant, Halfling, Orc, Vampires, Werewolf, Sphinx }
    public enum Alignments { LawfulGood, LawfulNeutral, LawfulEvil, NeutralGood, Neutral, NeutralEvil, ChaoticGood, ChaoticNeutral, ChaoticEvil }

    public class Character
    {
        public int HealthPoints
        {
            get; set;
        }

        public Races Race
        {
            get; set;
        }

        public Alignments Alignment
        {
            get; set;
        }

        public Character()
        {

        }

        public Character(int hp, Races r, Alignments a)
        {
            HealthPoints = hp;
            Race = r;
            Alignment = a;
        }

        public void TakeDamage(int damage)
        {
            HealthPoints -= 1;
        }

        public void RestoreHealth(int amount)
        {
            HealthPoints += 1;
        }
    }
}
