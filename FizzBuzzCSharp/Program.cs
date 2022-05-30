using System;

namespace FizzBuzzCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Every number divisible by 15 = FizzBuzz, 5 = Buzz, 3 = Fizz
           for (int i = 1 ; i < 300; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
