using System;

namespace RecursionFactorial
{
    class Program
    {
        // Recursion occurs when a method called within itself
        // Factorial 5 = 5*4*3*2*1
        static void Main(string[] args)
        {
            int answer = 0; // initialize
            answer = Factorial(5);
            Console.WriteLine("Answer is:" + answer);

            bool running = true;
            while (running) { }
        }

        private static int Factorial(int factorialNum) 
        {
            // Exit condition
            if (factorialNum == 1)
                return 1;
            return factorialNum * Factorial(factorialNum - 1);
        }
        // Factorial(5) = 5 * Factorial(4)
        // Factorial(4) = 4 * Factorial(3)
        // Factorial(3) = 3 * Factorial(2)
        // Factorial(2) = 2 * Factorial(1)
        // Factorial(1) = 1 
    }
}
