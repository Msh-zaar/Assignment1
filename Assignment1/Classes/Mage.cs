using Assignment1.Attributes;
using Assignment1.Item;
using Assignment1.Item.ItemExceptions;
using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Mage : Character
    {
        static int[] mageBaseAttr = new int[] { 1, 1, 8 }; // Starting Attributes of a Mage
        static int[] mageLevelAttr = new int[] { 1, 1, 5 }; // Attributes gained on level up for Mage
        enum Slot
        {
            Head,
            Body,
            Legs,
            Weapon
        }

        Dictionary<Slot, Items> equipment = new Dictionary<Slot, Items>();

        PrimaryAttributes attr = new PrimaryAttributes(mageBaseAttr);

        public Mage()
        {
        }

        public override void LevelUp()
        {
            this.Level += 1;
            attr.Leveling(mageLevelAttr);
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Level {Level}\n" +
                $"{attr}\n" +
                $"Weapon:\n{equipment[Slot.Weapon]}\n" +
                $"Head:\n{equipment[Slot.Head]}\n" +
                $"Body:\n{equipment[Slot.Body]}\n" +
                $"Legs:\n{equipment[Slot.Legs]}";
        }
        public override int[] GetAttributes()
        {
            return attr.GetAttributes();
        }

        public override double DealDamage()
        {
            int primaryAttribute = attr.GetAttributes()[2];
            double tempWeapon = 1.5;
            return (tempWeapon * (1 + primaryAttribute/100));

        }

        public override void EquipItem(Items item)
        {
            if (item.ItemSlot == "Weapon")
            {
                if (item.ReqLevel > this.Level)
                {
                    throw new InvalidWeaponException();
                }
            }
            switch (item.ItemSlot)
            {
                case "Head":
                    equipment.Remove(Slot.Head);
                    equipment.Add(Slot.Head, item);
                    break;
                case "Body":
                    equipment.Remove(Slot.Body);
                    equipment.Add(Slot.Body, item);
                    break;
                case "Legs":
                    equipment.Remove(Slot.Legs);
                    equipment.Add(Slot.Legs, item);
                    break;
                case "Weapon":
                    equipment.Remove(Slot.Weapon);
                    equipment.Add(Slot.Weapon, item);
                    break;
                default:
                    break;
            }
        }
    }
}
