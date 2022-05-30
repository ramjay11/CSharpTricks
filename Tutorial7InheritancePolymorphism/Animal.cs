using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Tutorial7InheritancePolymorphism
{
    // 'sealed' will keep the class to be inherited
    class Animal
    {
        private string name;
        protected string sound;

        // Define a method
        public void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        // Consructor
        public Animal()
            :this("No Name", "No Sound") { }

        public Animal(string name)  
            :this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        // Name properties
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    name = "No Sound";
                }
                sound = value;
            }
        }

    }
}
