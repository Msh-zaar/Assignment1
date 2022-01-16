﻿using System;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage()
            {
                Name = "Mage Magerson"
            };
            mage.LevelUp();
            Console.WriteLine(mage);

            Ranger ranger = new Ranger()
            {
                Name = "Ranger Rangerson"
            };
            ranger.LevelUp();
            Console.WriteLine(ranger);

            Rogue rogue = new Rogue()
            {
                Name = "Rogue Roguerson"
            };
            rogue.LevelUp();
            Console.WriteLine(rogue);

            Warrior warrior = new Warrior()
            {
                Name = "Warrior Warriorson"
            };
            warrior.LevelUp();
            Console.WriteLine(warrior);
        }
    }
}
