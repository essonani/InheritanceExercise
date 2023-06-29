using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal() 
        {
        } 
        public int Age { get; set; }
        public int Legs { get; set; }
        public bool HasBones { get; set; }
        public string Name { get; set; }
    }
}
