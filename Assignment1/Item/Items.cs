using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Item
{
    public abstract class Items
    {
        public string ItemName { get; set; } = "Default Item";
        public int ReqLevel { get; set; } = 0;
        public string ItemSlot { get; set; }
    }
}
