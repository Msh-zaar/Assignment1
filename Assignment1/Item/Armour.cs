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
        public new enum ItemType
        {
            Cloth,
            Leather,
            Mail,
            Plate
        }
        public new enum Slot
        {
            Head,
            Body,
            Legs
        }
        public PrimaryAttributes Attributes { get; set; }
        public new ItemType Type { get; set; }
        public new Slot EquipmentSlot { get; set; }

        public Armour(string name, int level, Slot slot, ItemType type, PrimaryAttributes attr)
        {
            ItemName = name;
            ReqLevel = level;
            EquipmentSlot = slot;
            Type = type;
            Attributes = attr;
        }
        public override string ToString()
        {
            return 
                $"Item Name: {ItemName}\n" +
                $"Armour Type: {Type}\n" +
                $"This is {EquipmentSlot} armour\n" +
                $"Required Level: {ReqLevel}\n" +
                $"Grants:\n{Attributes}";
        }
    }
}
