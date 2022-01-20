using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Item
{
    public class Weapon : Items
    {
        public new enum ItemType
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
        public new ItemType Type { get; set; }

        public Weapon(string name, int level, ItemType type, int baseDamage, double attackSpeed)
        {
            ItemName = name;
            ReqLevel = level;
            Type = type;
            BaseDamage = baseDamage;
            AttackSpeed = attackSpeed;
        }
        public override string ToString()
        {
            return 
                $"Item Name: {ItemName}\n" +
                $"Weapon Type: {Type}\n" +
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
