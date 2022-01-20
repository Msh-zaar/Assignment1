using Assignment1.Attributes;
using Assignment1.Item;
using Assignment1.Item.ItemExceptions;
using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Mage : Character
    {
        public Mage()
        {
            StartingAttributes = new int[] { 1, 1, 8 }; // Starting Attributes of a Mage
            LevelingAttributes = new int[] { 1, 1, 5 }; // Attributes gained on level up for Mage
            BaseAttributes += new PrimaryAttributes(StartingAttributes);
            AllowedArmours = new List<string> { "Cloth" };
            AllowedWeapons = new List<string> { "Staff", "Wand" };
            MainAtrribute = 2;
        }
    }
}
