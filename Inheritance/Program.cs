using System;
using System.Net.Cache;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Birds Turkey = new Birds()
            {
                Name="Turkey",
                Age=2,
                Legs=2,
                IsColdblooded=false,
                HasBones=true,
                HasFeather=true,
                Wings=2,
                Type="domestic",
                
            };
           
            Console.WriteLine(Turkey.Name + " is " + Turkey.Age + " years old and has " + Turkey.Legs + " legs and is  of type " + Turkey.Type);
            Reptile Lezard = new Reptile()
            {
                Name = "lezard",
                Age = 21,
                Legs = 4,
                HasBones = true,
                HasScales = true,
                Environment = "wetland",
                Defense = "bite",
            };
            Console.WriteLine(Lezard.Name + " is a reptile that live in " + Lezard.Environment + " has legs of " + Lezard.Legs + " and has an age of " + Lezard.Age);
        }


    }
}
