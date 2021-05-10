using System;

namespace Fibonacci
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if(n==0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return Fibonacci(n -1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number limit");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < a; j++)
            {
                Console.WriteLine(Fibonacci(j));
            }
        }
    }
}
