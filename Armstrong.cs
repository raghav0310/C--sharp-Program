using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sum = 0, a1, b;
            Console.WriteLine("Enter the  Desired Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            a1 = a;
            while (a != 0)
            {
                b = a % 10; 
                sum = sum + (b*b*b);
                a = a / 10;

            }
            if (a1 == sum)
            {
                Console.WriteLine("It is an Armstrong number");
            }
            else
            {
                Console.WriteLine("It is not an Armstrong Number");
            }
        }
    }
}

