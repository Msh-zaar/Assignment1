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
        public PrimaryAttributes(int[] attr)
        {
            this.strength = attr[0];
            this.dexterity = attr[1];
            this.intelligence = attr[2];
        }
        public PrimaryAttributes(int strength, int dexterity, int intelligence)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }
        /// <summary>
        /// Adds attribute values to character based on which class levelup array is passed in
        /// </summary>
        /// <param name="leveling"></param>
        public void Leveling(int[] leveling)
        {
            strength += leveling[0];
            dexterity += leveling[1];
            intelligence += leveling[2];
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
        public override string ToString()
        {
            return $"Strength: {strength}\n" +
            $"Dexterity: {dexterity}\n" +
            $"Intelligence: {intelligence}\n";
        }
    }
}
