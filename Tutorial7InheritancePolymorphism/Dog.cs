using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial7InheritancePolymorphism
{
    // : colon to inherit a class
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grrrrr";
        // Override methods
        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
    }
}
