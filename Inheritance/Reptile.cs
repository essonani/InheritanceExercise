using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile:Animal
    {
        public bool IsWarmedBlooded { get; set; }
        public bool HasScales { get; set; }
        public string Environment { get; set; }
        public string Defense { get; set; }
        public Reptile() 
        { 
        }
        public Reptile(bool isWarmedBlooded, bool hasScales, string environment, string defense)
        {
            IsWarmedBlooded = isWarmedBlooded;
            HasScales = hasScales;
            Environment = environment;
            Defense = defense;
        }
    }
}
