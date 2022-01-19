using Assignment1.Attributes;
using Assignment1.Item;
using Assignment1.Item.ItemExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Ranger: Character
    {
        static int[] rangerBaseAttr = new int[] { 1, 7, 1 }; // Starting Attributes of a Ranger
        static int[] rangerLevelAttr = new int[] { 1, 5, 1 }; // Attributes gained on level up for Ranger
        public enum Slot
        {
            Head,
            Body,
            Legs
        }
        enum Hands
        {
            Weapon
        }
        public enum AllowedWeapons
        {
            Bow
        }
        public enum AllowedArmour
        {
            Leather,
            Mail
        }

        Dictionary<Slot, Armour> equipment = new Dictionary<Slot, Armour>();
        Dictionary<Hands, Weapon> armament = new Dictionary<Hands, Weapon>();

        PrimaryAttributes attributes = new PrimaryAttributes(rangerBaseAttr);
        PrimaryAttributes temporaryAttributes = new PrimaryAttributes(0, 0, 0);

        public Ranger()
        {
        }

        public override void LevelUp()
        {
            this.Level += 1;
            attributes.Leveling(rangerLevelAttr);
            //Console.WriteLine("Ding!");
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Level {Level}\n" +
                $"{attributes + temporaryAttributes}\n" +
                $"Weapon:\n{(armament.ContainsKey(Hands.Weapon) ? armament[Hands.Weapon] : "Hands")}\n" + // tertiary operator: if not empty, print the slot, else print the string
                $"Head:\n{(equipment.ContainsKey(Slot.Head) ? equipment[Slot.Head] : "Bare\n")}\n" +
                $"Body:\n{(equipment.ContainsKey(Slot.Body) ? equipment[Slot.Body] : "Naked\n")}\n" +
                $"Legs:\n{(equipment.ContainsKey(Slot.Legs) ? equipment[Slot.Legs] : "Naked\n")}\n";
        }
        public override int[] GetAttributes()
        {
            return attributes.GetAttributes();
        }

        public override double DealDamage()
        {
            double attrScore = attributes.intelligence + temporaryAttributes.intelligence; // sums up primary attributes and those gained from armour

            double currentWeaponDPS = 1;
            if (armament.ContainsKey(Hands.Weapon))
            {
                currentWeaponDPS = armament[Hands.Weapon].GetDps();
            }

            double attrModifier = 1 + attrScore / 100;
            return currentWeaponDPS * attrModifier;
        }

        public override void EquipWeapon(Weapon weapon)
        {
            try
            {
                if (weapon.GetType().Equals(typeof(Weapon)))
                {
                    if (weapon.ReqLevel <= this.Level && weapon.WepTyp == (Weapon.WeaponType.Bow))
                    {
                        armament.Remove(Hands.Weapon);
                        armament.Add(Hands.Weapon, weapon);
                    }
                }
            }
            catch (InvalidWeaponException)
            {
                throw new InvalidWeaponException("You can not wield this weapon");
            }
        }

        public override void EquipArmour(Armour armour)
        {
            try
            {
                if (armour.ReqLevel <= this.Level && armour.ArmTyp == (Armour.ArmourType.Leather | Armour.ArmourType.Mail))
                {
                    switch (armour.ItemSlot)
                    {
                        case "Head":
                            if (equipment.ContainsKey(Slot.Head)) { temporaryAttributes -= equipment[Slot.Head].Attributes; }
                            equipment.Remove(Slot.Head);
                            equipment.Add(Slot.Head, armour);
                            temporaryAttributes += armour.Attributes;
                            break;
                        case "Body":
                            if (equipment.ContainsKey(Slot.Body)) { temporaryAttributes -= equipment[Slot.Body].Attributes; }
                            equipment.Remove(Slot.Body);
                            equipment.Add(Slot.Body, armour);
                            temporaryAttributes += armour.Attributes;
                            break;
                        case "Legs":
                            if (equipment.ContainsKey(Slot.Legs)) { temporaryAttributes -= equipment[Slot.Legs].Attributes; }
                            equipment.Remove(Slot.Legs);
                            equipment.Add(Slot.Legs, armour);
                            temporaryAttributes += armour.Attributes;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (InvalidArmourException)
            {
                throw new InvalidArmourException("You can not don this armour");
            }
        }
    }
}
