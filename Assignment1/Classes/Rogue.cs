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
    public class Rogue : Character
    {
        public Rogue()
        {
            StartingAttributes = new int[] { 2, 6, 1 }; // Starting Attributes of a Rogue
            LevelingAttributes = new int[] { 1, 4, 1 }; // Attributes gained on level up for Rogue
            BaseAttributes += new PrimaryAttributes(StartingAttributes);
            AllowedArmours = new List<string> { "Leather", "Mail" };
            AllowedWeapons = new List<string> { "Dagger", "Sword" };
            MainAtrribute = 1;
        }
    }
}
