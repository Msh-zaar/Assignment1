using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Item.ItemExceptions
{
    public class InvalidArmourException : Exception
    {
        public InvalidArmourException() : base() { }
        public InvalidArmourException(string message) : base(message) { }
    }
}
