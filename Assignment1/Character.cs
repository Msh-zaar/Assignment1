using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int[] BasePrimaryAttributes = new int[3];
        public int[] TotalPrimaryAtrributes = new int[3];

        public struct BaseAttr
        {
            public int strength;
            public int dexterity;
            public int intelligence;
        }

        public abstract void LevelUp();
    }

}
