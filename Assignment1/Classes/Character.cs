using Assignment1.Item;
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

        // Methods

        /// <summary>
        /// Levels up the character, adds 1 to Level
        /// </summary>
        public abstract void LevelUp();
        /// <summary>
        /// Returns a formatted string with relevant attributes
        /// </summary>
        /// <returns>array of attributes</returns>
        public abstract int[] GetAttributes();
        /// <summary>
        /// Deals damage
        /// </summary>
        public abstract double DealDamage();
        /// <summary>
        /// Equips an item on character
        /// </summary>
        public abstract void EquipWeapon(Weapon weapon);
        public abstract void EquipArmour(Armour armour);
    }

}
