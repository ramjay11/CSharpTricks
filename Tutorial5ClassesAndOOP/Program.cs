using System;

namespace Tutorial5ClassesAndOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a rectangle struct
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}", rect1.Area());
            // Using the constructor
            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("rect2.length : {0}", rect2.length);
        }
        // Struct is a user-defined type that allows you to contain multiple fields as well as methods
        struct Rectangle
        {
            // Define fields
            public double length;
            public double width;
            public Rectangle(double l = 1, double w = 1)
            {
                length = 1;
                width = 1;
            }

            public double Area()
            {
                return length * width;
            }
        }

    }
    
}
