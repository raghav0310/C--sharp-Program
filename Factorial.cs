using System;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int a;
            int fact = 1;
            Console.WriteLine("Enter a number : ");
            a = Convert.ToInt32(Console.ReadLine());
            for ( int x = 1; x <= a; x++)
            {
                fact = fact * x;
            }
            Console.Write("Factorial : " + fact);
        }
    }
}
