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
    public class Ranger: Character
    {
        public Ranger()
        {
            StartingAttributes = new int[] { 1, 7, 1 }; // Starting Attributes of a Ranger
            LevelingAttributes = new int[] { 1, 5, 1 }; // Attributes gained on level up for Ranger
            BaseAttributes += new PrimaryAttributes(StartingAttributes);
            AllowedArmours = new List<string> { "Leather", "Mail" };
            AllowedWeapons = new List<string> { "Bow" };
            MainAtrribute = 1;
        }
    }
}
