using Assignment1.Item;
using System;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common Axe",
                ReqLevel = 2,
                ItemSlot = "Weapon",
                WepTyp = Weapon.WeaponType.Axe,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };

            Mage mage = new Mage()
            {
                Name = "Mage Magerson"
            };
            mage.LevelUp();
            Console.WriteLine(mage);
            mage.EquipItem(testAxe);
            Console.WriteLine(mage);
        }
    }
}
