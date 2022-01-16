using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class Character
    {
        public string Name { get; set; } = "Default Name";
        public int Level { get; set; } = 1;
        public abstract void LevelUp();
    }

}
