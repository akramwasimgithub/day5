using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class primeFact
    {
        static void Main(string[] args)
        {
            int a, b, num, isPrime;
            Console.Write("Please enter your number: ");
            num = int.Parse(Console.ReadLine());
            for (a = 2; a <= num; a++)
            {
                if (num % a == 0)
                {
                    isPrime = 1;
                    for (b = 2; b <= a / 2; b++)
                    {
                        if (a % b == 0)
                        {
                            isPrime = 0;
                            break;
                        }
                    }
                    if (isPrime == 1)
                    {
                        Console.WriteLine(a);
                    }

                }
            }



        }
    }
}
