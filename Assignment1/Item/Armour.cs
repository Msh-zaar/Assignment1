using Assignment1.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Item
{
    public class Armour : Items
    {
        public enum ArmourType
        {
            Cloth,
            Leather,
            Mail,
            Plate
        }
        public ArmourType ArmTyp { get; set; }
        public PrimaryAttributes Attributes { get; set; }
        public Armour()
        {
        }

        public override string ToString()
        {
            return $"Item Name: {ItemName}\n" +
                $"Armour Type: {ArmTyp}\n" +
                $"This is {ItemSlot} armour\n" +
                $"Required Level: {ReqLevel}\n" +
                $"Grants:\n{Attributes}";
        }
    }
}
