using System;

namespace GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter two Number i & j");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            if(i>j)
            {
                Console.WriteLine("Biggest Number is " + i);
            }
            else
            {
                Console.WriteLine("Biggest Number is " + j);
            }
        }
    }
}
