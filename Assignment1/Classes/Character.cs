using Assignment1.Attributes;
using Assignment1.Item;
using Assignment1.Item.ItemExceptions;
using System.Collections.Generic;

namespace Assignment1
{
    public abstract class Character
    {
        public string Name { get; set; } = "Name Namerson";
        public int Level { get; set; } = 1;
        /// <summary>
        /// Main attribute of a specific class, 0 = strength, 1 = dexterity, 2 = intelligence
        /// </summary>
        protected int MainAtrribute { get; set; }
        /// <summary>
        /// The starting attributes of a specific class 
        /// </summary>
        protected int[] StartingAttributes { get; set; } = { 0, 0, 0 };
        /// <summary>
        /// The attributes gained when a specific class levels up
        /// </summary>
        protected int[] LevelingAttributes { get; set; }
        /// <summary>
        /// Dictionary of equipped items
        /// </summary>
        protected Dictionary<Slot, Armour> Equipment { get; set; } = new Dictionary<Slot, Armour>();
        /// <summary>
        /// Dictionary of equipped weapons
        /// </summary>
        protected Dictionary<Hands, Weapon> Armament { get; set; } = new Dictionary<Hands, Weapon>();
        /// <summary>
        /// The attributes of a specific class at level 1
        /// </summary>
        protected PrimaryAttributes BaseAttributes { get; set; } = new PrimaryAttributes();
        /// <summary>
        /// Attributes gained through equipping armour
        /// </summary>
        protected PrimaryAttributes TemporaryAttributes { get; set; } = new PrimaryAttributes();
        /// <summary>
        /// The weapon types a specific class can wield
        /// </summary>
        protected List<string> AllowedWeapons { get; set; }
        /// <summary>
        /// The armour types a specific class can wield
        /// </summary>
        protected List<string> AllowedArmours { get; set; }
        protected enum Slot
        {
            Head,
            Body,
            Legs
        }
        protected enum Hands
        {
            Weapon
        }
        // Methods

        /// <summary>
        /// Levels up the character - adds 1 to Level
        /// </summary>
        public virtual void LevelUp()
        {
            Level += 1;
            BaseAttributes.Leveling(LevelingAttributes);
        }
        /// <summary>
        /// Returns a formatted string of a character's attributes
        /// </summary>
        /// <returns>array of attributes</returns>
        public virtual int[] GetAttributes()
        {
            return BaseAttributes.GetAttributes();
        }
        /// <summary>
        /// Calculates and deals damage based on weapon DPS and attribute score
        /// </summary>
        public virtual double DealDamage()
        {
            double attrScore = BaseAttributes.GetSingular(MainAtrribute) + TemporaryAttributes.GetSingular(MainAtrribute);
            double currentWeaponDPS = 1;
            if (Armament.ContainsKey(Hands.Weapon))
            {
                currentWeaponDPS = Armament[Hands.Weapon].GetDps();
            }

            double attrModifier = 1 + attrScore / 100;
            return currentWeaponDPS * attrModifier;
        }
        /// <summary>
        /// Equips a weapon to character, if weapon is too high level or of the wrong type, will throw an InvalidWeaponException
        /// </summary>
        public virtual string EquipWeapon(Weapon weapon)
        {
            if (weapon.ReqLevel <= Level && AllowedWeapons.Contains(weapon.Type.ToString()))
            {
                if (Armament.ContainsKey(Hands.Weapon)) { Armament.Remove(Hands.Weapon); }
                Armament.Add(Hands.Weapon, weapon);
                return "New weapon equipped!";
            }
            else
            {
                throw new InvalidWeaponException("You can not wield this weapon");
            }
        }
        /// <summary>
        /// Equips armour on character, will throw an InvalidArmourException if armour is too high level or of the wrong type
        /// </summary>
        public virtual string EquipArmour(Armour armour)
        {
            if (armour.ReqLevel <= Level && AllowedArmours.Contains(armour.Type.ToString()))
            {
                switch (armour.EquipmentSlot)
                {
                    case Armour.Slot.Head:
                        if (Equipment.ContainsKey(Slot.Head)) { TemporaryAttributes -= Equipment[Slot.Head].Attributes; }
                        Equipment.Remove(Slot.Head);
                        Equipment.Add(Slot.Head, armour);
                        TemporaryAttributes += armour.Attributes;
                        return "New armour equipped!";
                    case Armour.Slot.Body:
                        if (Equipment.ContainsKey(Slot.Body)) { TemporaryAttributes -= Equipment[Slot.Body].Attributes; }
                        Equipment.Remove(Slot.Body);
                        Equipment.Add(Slot.Body, armour);
                        TemporaryAttributes += armour.Attributes;
                        return "New armour equipped!";
                    case Armour.Slot.Legs:
                        if (Equipment.ContainsKey(Slot.Legs)) { TemporaryAttributes -= Equipment[Slot.Legs].Attributes; }
                        Equipment.Remove(Slot.Legs);
                        Equipment.Add(Slot.Legs, armour);
                        TemporaryAttributes += armour.Attributes;
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
        public override string ToString()
        {
            return 
                $"Name: {Name}\n" +
                $"Level {Level}\n" +
                $"This Character is a: {GetType().Name}\n" +
                $"{BaseAttributes + TemporaryAttributes}\n" +
                $"\nThis character deals: {DealDamage()} damage\n" +
                $"\nWeapon:\n{(Armament.ContainsKey(Hands.Weapon) ? Armament[Hands.Weapon] : "Fists\n")}\n" + // tertiary operator: if not empty, print the slot, else print the string
                $"Head:\n{(Equipment.ContainsKey(Slot.Head) ? Equipment[Slot.Head] : "Bare\n")}\n" +
                $"Body:\n{(Equipment.ContainsKey(Slot.Body) ? Equipment[Slot.Body] : "Bare\n")}\n" +
                $"Legs:\n{(Equipment.ContainsKey(Slot.Legs) ? Equipment[Slot.Legs] : "Bare\n")}\n";
        }
    }

}
