using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class twoPowerN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of 'N': ");
            int powerNum = Convert.ToInt32(Console.ReadLine());
            if (powerNum <= 31 && powerNum >= 0)
            {

                Console.WriteLine("2^" + powerNum);

                int a = 2;
                for (int i = 1; i <= powerNum; i++)
                {
                    
                    Console.WriteLine($"{a}^{i}={(long)Math.Pow(a,i): 0} ");

                }
            }
            else
            {
                Console.WriteLine("The number should not exceed 31");
            }
            



        }
     
       
    }
       
}

