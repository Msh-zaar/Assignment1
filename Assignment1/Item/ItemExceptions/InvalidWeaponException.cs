using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Item.ItemExceptions
{
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException() : base() { }
        public InvalidWeaponException(string message) : base(message) { }

    }
}
