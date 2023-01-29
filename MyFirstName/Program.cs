using System;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(String[] args )
        {

            // conditional operator = used in conditional assignment if a condition is true/false.

            // (condition) ? x : y

            double temperature = 20;

            String message;

            //if (temperature >= 15)
            //{
            //    message = "It's warm outside!";
            //}
            //else
            //{
            //    message = "It's cold outside";
            //}
            //Console.WriteLine(message);


            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside";
            Console.WriteLine((temperature >= 15) ? "It's warm outside!" : "It's cold outside");
            Console.ReadKey();
        }


    }

}