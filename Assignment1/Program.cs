using Assignment1.Attributes;
using Assignment1.Item;
using System;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage();
            Ranger ranger = new Ranger();
            Rogue rogue = new Rogue();
            Warrior warrior = new Warrior();

            Weapon testAxe = new Weapon()
            {
                ItemName = "Common Axe",
                ReqLevel = 1,
                WepTyp = Weapon.WeaponType.Axe,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            Weapon testBow = new Weapon()
            {
                ItemName = "Common Bow",
                ReqLevel = 1,
                WepTyp = Weapon.WeaponType.Bow,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            Weapon testDagger = new Weapon()
            {
                ItemName = "Common Dagger",
                ReqLevel = 1,
                WepTyp = Weapon.WeaponType.Dagger,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            Weapon testStaff = new Weapon()
            {
                ItemName = "Common Staff",
                ReqLevel = 1,
                WepTyp = Weapon.WeaponType.Staff,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            Weapon testWand = new Weapon()
            {
                ItemName = "Common Wand",
                ReqLevel = 1,
                WepTyp = Weapon.WeaponType.Wand,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            Armour testPlateBody = new Armour()
            {
                ItemName = "Common Plate Body Armour",
                ReqLevel = 1,
                ItemSlot = "Body",
                ArmTyp = Armour.ArmourType.Plate,
                Attributes = new PrimaryAttributes(1, 0, 0)
            };

            Console.WriteLine(warrior.DealDamage());
            warrior.EquipWeapon(testAxe);
            Console.WriteLine(warrior.DealDamage());
            warrior.EquipArmour(testPlateBody);
            Console.WriteLine(warrior);
        }
    }
}
