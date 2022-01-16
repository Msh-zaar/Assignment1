using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Item
{
    public class Weapon : Item
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
        public WeaponType WepTyp { get; set; } = WeaponType.Axe;

        public Weapon()
        {
        }

        public override string ToString()
        {
            return $"Item Name: {ItemName}\n" +
                $"Weapon Type: {WepTyp}\n" +
                $"Fits in the {ItemSlot} slot\n" +
                $"Required Level: {ReqLevel}\n" +
                $"Base Damage: {BaseDamage}\n" +
                $"Attack Speed: {AttackSpeed}\n" +
                $"DPS: {GetDps()}\n";
        }

        public double GetDps()
        {
            return BaseDamage * AttackSpeed;
        }

        public void EquipmentTest()
        {
            ;
        }


        //Weapon testAxe = new Weapon()
        //{
        //    ItemName = "Common Axe",
        //    ItemLevel = 1,
        //    ItemSlot = Slot.Weapon,
        //    WeaponType = WeaponType.Axe,
        //    BaseDamage = 7,
        //    AttackSpeed = 1.1
        //};
    }
}
