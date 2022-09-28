using System;
namespace Homework6_3_Factorial
{
    internal class Program
    {
        static int Factorial(int number)
        {
            if (number == 1)
                return 1;
            return number * Factorial(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {a} is {Factorial(a)}");
            Console.ReadKey();
        }
    }
}