using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, flag = 0;
            Console.WriteLine("Enter a Number : ");
            x = Convert.ToInt32(Console.ReadLine());
            for( int i=2; i<=x/2 ; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("Not a Prime Number : " + x);
                    flag = 1;
                    break;
                }   
            }
            if ( flag == 0)
            {
                Console.WriteLine("A Prime Number : " + x);
            }
        }
    }
}
