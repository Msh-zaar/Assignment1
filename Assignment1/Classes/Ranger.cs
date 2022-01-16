using Assignment1.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Ranger: Character
    {
        static int[] rangerBaseAttr = new int[] { 1, 7, 1 }; // Starting Attributes of a Ranger
        static int[] rangerLevelAttr = new int[] { 1, 5, 1 }; // Attributes gained on level up for Ranger

        PrimaryAttributes attr = new PrimaryAttributes(rangerBaseAttr);

        public Ranger()
        {
        }

        public override void LevelUp()
        {
            this.Level += 1;
            attr.Leveling(rangerLevelAttr);
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Level {Level}\n" +
                $"{attr}";
        }
    }
}
