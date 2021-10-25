using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class primeFact
    {
        static void Main(string[] args)
        {
            int num, b;
            Console.WriteLine("Please enter your number: ");
            num = int.Parse(Console.ReadLine());
            for (b = 1; b <= num; b++)
            {
                if (num % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + num);
                }
            }
            Console.ReadLine();



        }

    }
}
