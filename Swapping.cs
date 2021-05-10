using System;

namespace Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter 2 numbers to swap x and y : ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After swapping x and y : "+ x +" " + y);
        }
    }
}
