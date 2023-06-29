using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Birds:Animal
    {
        public int Wings { get; set; }
        public string Type { get; set; }
        public bool IsColdblooded { get; set; }
        public bool HasFeather { get; set; }
        public Birds()
        {

        }
        public Birds(string name , int age,bool isColdBlooded,bool hasFeather,int wings,int legs,string type)
        {
            Name = name;
            Age = age;  
            IsColdblooded = isColdBlooded;
            HasFeather = hasFeather;
            Wings= wings;
            Legs=legs;
            Type = type;
        }                                                                                                                                                                                                
    }

}
