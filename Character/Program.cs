﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character;

namespace vgp232_Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Systems...");
            // TODO: create inventory system

            Console.WriteLine("Initializing Character Manager");
            Character.Character player = new Character.Character(100, Races.Elf, Alignments.Neutral);
            CharacterManager characterManager = CharacterManager.Instance;
            characterManager.Player = player;
            Character.Character enemyOne = new Character.Character(50, Races.Orc, Alignments.ChaoticEvil);
            Character.Character enemyTwo = new Character.Character(50, Races.Orc, Alignments.NeutralEvil);
            characterManager.AddEnemy(enemyOne);
            characterManager.AddEnemy(enemyTwo);

            // TODO: create persistent data system

            Console.ReadKey();

        }
    }
}
