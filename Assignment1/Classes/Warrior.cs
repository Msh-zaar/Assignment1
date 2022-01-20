using Assignment1.Attributes;
using Assignment1.Item;
using Assignment1.Item.ItemExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Warrior : Character
    {
        public Warrior()
        {
            StartingAttributes = new int[] { 5, 2, 1 }; // Starting Attributes of a Warrior
            LevelingAttributes = new int[] { 3, 2, 1 }; // Attributes gained on level up for Warrior
            BaseAttributes += new PrimaryAttributes(StartingAttributes);
            AllowedArmours = new List<string> { "Mail", "Plate" };
            AllowedWeapons = new List<string> { "Axe", "Hammer", "Sword" };
            MainAtrribute = 0;
        }
    }
}
