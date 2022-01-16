using Assignment1.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Mage : Character
    {
        static int[] mageBaseAttr = new int[] { 1, 1, 8 }; // Starting Attributes of a Mage
        static int[] mageLevelAttr = new int[] { 1, 1, 5 }; // Attributes gained on level up for Mage

        PrimaryAttributes attr = new PrimaryAttributes(mageBaseAttr);

        public Mage()
        {
        }

        public override void LevelUp()
        {
            this.Level += 1;
            attr.Leveling(mageLevelAttr);
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Level {Level}\n" +
                $"{attr}";
        }
        public override int[] GetAttributes()
        {
            return attr.GetAttributes();
        }
    }
}
