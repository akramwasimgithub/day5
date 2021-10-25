using System;

namespace Day5
{
    class Program

    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the Number of times you want to flip the coin :");
            int numberOfTimes=Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for(int i=0; i<=numberOfTimes; i++)
            {
              double r=random.NextDouble();
                Console.WriteLine("results : " + r);

                if (r < 0.5)
                {
                    Console.WriteLine("tail");
                   /* double percentage = (r / r - numberOfTimes) * 100;
                    Console.WriteLine("% : " + percentage);*/
                }
                else
                {
                    Console.WriteLine("head");
                }


            
        }

        }
    }
}
