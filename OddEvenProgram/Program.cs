using System;

namespace OddEvenProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variable
            int n;
            Console.WriteLine("Enter any number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("The number is even");
            else
                Console.WriteLine("The number is odd");
        }
    }
}
