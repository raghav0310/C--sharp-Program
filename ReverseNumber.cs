using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, reverse = 0, t;
            Console.WriteLine("Enter a number : ");
            x = Convert.ToInt32((Console.ReadLine()));
            while (x != 0)
            {
                t = x % 10;
                reverse = reverse * 10 + t;
                x /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
