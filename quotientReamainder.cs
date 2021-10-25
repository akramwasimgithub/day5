using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class quotientReamainder
    {
        static void Main(string[] args)
        {
            Console.Write("enter dividend :" );
            double dividend=Convert.ToDouble(Console.ReadLine());
            Console.Write("enter divisor :");
            double divisor = Convert.ToDouble(Console.ReadLine());

           /* int dividend = 50, divisor = 8;*/

            double quotient = dividend / divisor;
            double remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}