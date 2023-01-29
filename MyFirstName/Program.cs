using System;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(String[] args )
        {

            // exception = errors that occur during execution.

            //       try = try some code that is considered "dangerous"
            //     catch = catches and handles exceptions when they occur 
            //   finally = always executes regardless if exception is caught or not


            double x;
            double y;
            double result;

            try
            {

            Console.WriteLine("Enter number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            y= Convert.ToDouble(Console.ReadLine());

            result = x / y;
            Console.WriteLine("The result : " + result);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cant divide with 0!");
            }           
            finally
            {
                Console.WriteLine("Thank you!");
            }
        Console.ReadKey();
        }


    }

}