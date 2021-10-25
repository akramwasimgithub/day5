using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class swapNumber
    {
        public static void Main(string[] args)
        {
            Console.Write("enter first number: ");
            Console.ReadLine();
            int firstNum=Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number: ");
            Console.ReadLine();
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap first= " + firstNum + " second= " + secondNum);
            firstNum = firstNum * secondNum;       
           secondNum= firstNum / secondNum;     
            firstNum = firstNum / secondNum;    
            Console.Write("After swap first= " + firstNum + " second= " + secondNum);
        }
    }
}
