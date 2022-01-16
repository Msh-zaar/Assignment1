using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class Character
    {
        public string Name { get; set; } = "Default Name";
        public int Level { get; set; } = 1;
        enum Slot
        {
            Head,
            Body,
            Legs,
            Weapon
        }

        // Methods
        public abstract void LevelUp();
        public abstract int[] GetAttributes();
        public abstract void DealDamage();
        public abstract void EquipItem();
    }

}
