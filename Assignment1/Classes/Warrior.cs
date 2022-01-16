using Assignment1.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Warrior : Character
    {
        static int[] warriorBaseAttr = new int[] { 5, 2, 1 }; // Starting Attributes of a Ranger
        static int[] warriorLevelAttr = new int[] { 3, 2, 1 }; // Attributes gained on level up for Ranger

        PrimaryAttributes attr = new PrimaryAttributes(warriorBaseAttr);

        public Warrior()
        {
        }

        public override void LevelUp()
        {
            this.Level += 1;
            attr.Leveling(warriorLevelAttr);
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
