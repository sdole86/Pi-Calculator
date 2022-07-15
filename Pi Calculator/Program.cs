using System;

namespace Pi_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Leibniz Formula");
            Console.WriteLine();
            Console.WriteLine("Please enter the number of times to run this calculaton");
            double number = 0;
            while (number < 999999)
            {
                Console.Write("Please enter value > 1 million: ");
                string userInput = Console.ReadLine();
                number = Convert.ToDouble(userInput);
                if (number < 999999) // Catch invalid data
                {
                    Console.WriteLine("Invalid data input");

                }
                
            }
            double sum = 0, iteration = 0, pi = 0;

            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            while (iteration < number){
                sum += (Math.Pow(-1, iteration))/((2 * iteration) + 1);
                ++iteration;
                pi = sum * 4;
                if (iteration == 10 || iteration == 1000 || iteration == 100000 || iteration == 500000 || iteration == 1000000 || iteration == number)
                {
                    Console.WriteLine("At " + iteration.ToString("N0") + " iterations, the value of pi is " + Math.Round(pi,10));
                }

            }


        }
    }
}
