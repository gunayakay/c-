using System;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach loop = a simpler way to itarate over an array, but it's less flexible

            String[] cars = { "BMW", "Tesla", "Corvette" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        Console.ReadKey();
        }

    }
}