using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Item
{
    public class Weapon : Items
    {
        public enum WeaponType
        {
            Axe,
            Bow,
            Dagger,
            Hammer,
            Staff,
            Sword,
            Wand
        }
        
        public int BaseDamage { get; set; }
        public double AttackSpeed { get; set; }
        public WeaponType WepTyp { get; set; }

        public Weapon()
        {
        }
        public override string ToString()
        {
            return $"Item Name: {ItemName}\n" +
                $"Weapon Type: {WepTyp}\n" +
                $"Required Level: {ReqLevel}\n" +
                $"Base Damage: {BaseDamage}\n" +
                $"Attack Speed: {AttackSpeed}\n" +
                $"DPS: {GetDps()}\n";
        }
        /// <summary>
        /// Returns the dps of a weapon
        /// </summary>
        /// <returns>Base damage * attack speed</returns>
        public double GetDps()
        {
            return BaseDamage * AttackSpeed;
        }
    }
}
