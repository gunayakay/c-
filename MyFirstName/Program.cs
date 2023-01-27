using System;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {



                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.Write("Enter num 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter num 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Substract");
                Console.WriteLine("\t* : Multiply ");
                Console.WriteLine("\t/ : Divide ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"The result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"The result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 + num2;
                        Console.WriteLine($"The result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 + num2;
                        Console.WriteLine($"The result: {num1} / {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;

                }

                Console.WriteLine("Would you like to continue? ( Y = Yes N = No ): ");
            } while (Console.ReadLine().ToUpper() == "Y");
            {
                Console.WriteLine("Thank you for visiting...");
            }

        Console.ReadKey();


        }

    }
}