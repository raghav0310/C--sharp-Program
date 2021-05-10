using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sum = 0, a1, t;
            Console.WriteLine("Enter the Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            a1 = a;
            while(a!=0)
            {
                t = a % 10;
                sum = (sum * 10) + t;
                a = a / 10;

            }
            if ( a1 == sum )
            {
                Console.WriteLine("I is a Palindrome number");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome Number");
            }
        }
    }
}
