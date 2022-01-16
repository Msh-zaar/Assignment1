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
            strength = attr[0];
            dexterity = attr[1];
            intelligence = attr[2];
        }

        public void Leveling(int[] leveling)
        {
            strength += leveling[0];
            dexterity += leveling[1];
            intelligence += leveling[2];
        }

        public override string ToString()
        {
            return $"Strength: {strength}\n" +
            $"Dexterity: {dexterity}\n" +
            $"Intelligence: {intelligence}\n";
        }
    }
}
