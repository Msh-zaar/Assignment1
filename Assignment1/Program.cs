using Assignment1.Attributes;
using Assignment1.Item;
using System;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage()
            {
                Name = "Mage Magerson"
            };
            Weapon testWand = new Weapon()
            {
                ItemName = "Common Wand",
                ReqLevel = 2,
                WepTyp = Weapon.WeaponType.Wand,
                BaseDamage = 5,
                AttackSpeed = 5
            };
            Armour testCloth = new Armour()
            {
                ItemName = "Rare Cloth Body Armour",
                ReqLevel = 2,
                ItemSlot = "Body",
                ArmTyp = Armour.ArmourType.Cloth,
                Attributes = new PrimaryAttributes(1, 1, 1)
            };

            mage.LevelUp();
            mage.EquipWeapon(testWand);
            Console.WriteLine(mage);
            Console.WriteLine(mage.DealDamage());


            mage.EquipArmour(testCloth);
            Console.WriteLine(mage);
            Console.WriteLine(mage.DealDamage());
        }
    }
}
