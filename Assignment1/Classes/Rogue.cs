using Assignment1.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Rogue : Character
    {
        static int[] rogueBaseAttr = new int[] { 2, 6, 1 }; // Starting Attributes of a Ranger
        static int[] rogueLevelAttr = new int[] { 1, 4, 1 }; // Attributes gained on level up for Ranger

        PrimaryAttributes attr = new PrimaryAttributes(rogueBaseAttr);

        public Rogue()
        {
        }

        public override void LevelUp()
        {
            this.Level += 1;
            attr.Leveling(rogueLevelAttr);
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Level {Level}\n" +
                $"{attr}";
        }
    }
}
