namespace Assignment1.Item
{
    public abstract class Items
    {
        public enum ItemType
        {

        }
        public enum Slot
        {

        }
        public string ItemName { get; set; } = "Default Item";
        public int ReqLevel { get; set; } = 0;
        public Slot EquipmentSlot { get; set; }
        public ItemType Type { get; set; }
    }
}
