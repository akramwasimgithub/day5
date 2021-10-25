using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Leap_year
    {

        static void Main(String[] args)
        {
           

            Console.Write("Enter a yaer : ");

            int Year = Convert.ToInt32(Console.ReadLine());

            if (Year >= 1000 && Year <= 9999)
            {
                /*Console.WriteLine("valied");*/
            
                if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
                {
                Console.WriteLine( Year + " This is a Leap Year. " );
                }
                else
                {
                Console.WriteLine(Year + "  This is a not  Leap Year" );
                }
            }
            else
            {
                Console.WriteLine("Enter a valied year");
            }
            






        }
    }
}
