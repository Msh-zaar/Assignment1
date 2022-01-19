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
    public class Rogue : Character
    {
        static int[] rogueBaseAttr = new int[] { 2, 6, 1 }; // Starting Attributes of a Ranger
        static int[] rogueLevelAttr = new int[] { 1, 4, 1 }; // Attributes gained on level up for Ranger
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

        Dictionary<Slot, Armour> equipment = new Dictionary<Slot, Armour>();
        Dictionary<Hands, Weapon> armament = new Dictionary<Hands, Weapon>();

        PrimaryAttributes attributes = new PrimaryAttributes(rogueBaseAttr);
        PrimaryAttributes temporaryAttributes = new PrimaryAttributes(0, 0, 0);

        public Rogue()
        {
        }

        public override void LevelUp()
        {
            this.Level += 1;
            attributes.Leveling(rogueLevelAttr);
            //Console.WriteLine("Ding!");
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Level {Level}\n" +
                $"{attributes + temporaryAttributes}\n" +
                $"{DealDamage()}" +
                $"Weapon:\n{(armament.ContainsKey(Hands.Weapon) ? armament[Hands.Weapon] : "Hands\n")}\n" + // tertiary operator: if not empty, print the slot, else print the string
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
            double attrScore = attributes.dexterity + temporaryAttributes.dexterity; // sums up primary attributes and those gained from armour

            double currentWeaponDPS = 1;
            if (armament.ContainsKey(Hands.Weapon))
            {
                currentWeaponDPS = armament[Hands.Weapon].GetDps();
            }

            double attrModifier = 1 + attrScore / 100;
            return currentWeaponDPS * attrModifier;
        }

        public override string EquipWeapon(Weapon weapon)
        {
            if (weapon.ReqLevel <= this.Level && 
                (weapon.WepTyp == Weapon.WeaponType.Dagger | weapon.WepTyp == Weapon.WeaponType.Sword))
            {
                if (armament.ContainsKey(Hands.Weapon)) { armament.Remove(Hands.Weapon); }
                armament.Add(Hands.Weapon, weapon);
                return "New weapon equipped!";
            }
            else
            {
                throw new InvalidWeaponException("You can not wield this weapon");
            }
        }

        public override string EquipArmour(Armour armour)
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
                        return "New armour equipped!";
                    case "Body":
                        if (equipment.ContainsKey(Slot.Body)) { temporaryAttributes -= equipment[Slot.Body].Attributes; }
                        equipment.Remove(Slot.Body);
                        equipment.Add(Slot.Body, armour);
                        temporaryAttributes += armour.Attributes;
                        return "New armour equipped!";
                    case "Legs":
                        if (equipment.ContainsKey(Slot.Legs)) { temporaryAttributes -= equipment[Slot.Legs].Attributes; }
                        equipment.Remove(Slot.Legs);
                        equipment.Add(Slot.Legs, armour);
                        temporaryAttributes += armour.Attributes;
                        return "New armour equipped!";
                    default:
                        return "No new armour equipped!";
                }
            }
            else
            {
                throw new InvalidArmourException("You can not don this armour");
            }
        }
    }
}
