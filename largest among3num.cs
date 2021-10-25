using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class largest_among3num
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            num1 = 10;
            num2 = 20;
            num3 = 50;
            if (num1 > num2)
            {
                if (num1 > num3 && num1>num2)
                {
                    Console.Write("Number num1 is the largest!\n");
                }
                else if(num2>num3&& num2>num1)
                {
                    Console.Write("Number num2 is the largest!\n");
                }
                else
                {
                    Console.Write("Number num3 is the largest!\n");
                }
            }
        }
    }
}
