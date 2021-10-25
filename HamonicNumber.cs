using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class HamonicNumber
    {
        static void Main()
        { 
        

       
          
             
               /* float harmonic = 1;

               
                for (int i = 2; i <= N; i++)
                {
                    harmonic += (float)1 / i;
                }*/
            Console.Write("Enter the value of 'N': ");
                int harmonicNum = Convert.ToInt32(Console.ReadLine());

                if (harmonicNum != 0)
                {
                    for (int i = 1; i <= harmonicNum; i++)
                    {
                        harmonicNum = 1 / i;
                    Console.WriteLine("1/"+ harmonicNum);
                    


                   
                    }

                }
            
        }
    }
}

