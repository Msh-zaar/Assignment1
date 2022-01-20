using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Attributes
{
    public class PrimaryAttributes
    {
        public int strength;
        public int dexterity;
        public int intelligence;
        public PrimaryAttributes()
        {
        }
        // Constructor for generating a PrimaryAttributes object based on int[] of a character's base stats
        public PrimaryAttributes(int[] attr)
        {
            this.strength = attr[0];
            this.dexterity = attr[1];
            this.intelligence = attr[2];
        }
        // Constructor for generating a PrimaryAttributes object based on arbitrary values
        public PrimaryAttributes(int strength, int dexterity, int intelligence)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }
        /// <summary>
        /// Adds attribute values to character based on which class' levelup array is passed in as a parameter
        /// </summary>
        /// <param name="leveling"></param>
        public void Leveling(int[] leveling)
        {
            strength += leveling[0];
            dexterity += leveling[1];
            intelligence += leveling[2];
        }
        // Overloads the + operator to add together the values of str, dex and int when two PrimaryAttributes objects are added together
        public static PrimaryAttributes operator +(PrimaryAttributes lhs, PrimaryAttributes rhs)
        {
            return new PrimaryAttributes(lhs.strength + rhs.strength, lhs.dexterity + rhs.dexterity, lhs.intelligence + rhs.intelligence);
        }
        // Overloads the - operator to subtract the values of str, dex and int from one PrimaryAttributes object to another
        public static PrimaryAttributes operator -(PrimaryAttributes lhs, PrimaryAttributes rhs)
        {
            return new PrimaryAttributes(lhs.strength - rhs.strength, lhs.dexterity - rhs.dexterity, lhs.intelligence + rhs.intelligence);
        }
        /// <summary>
        /// Retrieves current values of str, dex, int
        /// </summary>
        /// <returns>formatted string of attributes</returns>
        public int[] GetAttributes()
        {
            int[] attributeArray = new int[] { strength, dexterity, intelligence };
            return attributeArray;
        }
        public int GetSingular(int choice)
        {
            int[] attributeArray = new int[] { strength, dexterity, intelligence };
            return attributeArray[choice];
        }
        public override string ToString()
        {
            return $"Strength: {strength}\n" +
            $"Dexterity: {dexterity}\n" +
            $"Intelligence: {intelligence}";
        }
    }
}
