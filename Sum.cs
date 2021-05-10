using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sum = 0, t;
            Console.WriteLine("Enter a number : ");
            x = Convert.ToInt32((Console.ReadLine()));
            while (x > 0)
            {
                t = x % 10;
                sum = sum + t;
                x = x / 10;
            }
            Console.Write("Sum is= " + sum);
        }
    }
}
