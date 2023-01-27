using System;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //array = a variable that can store multiple values. fixed sizes

            //String[] cars = {"BMW" ,"Mustang","Corvette" };
            String[] cars = new string[3];
            //Console.WriteLine(cars);
            //Console.WriteLine(cars[]);
            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars[1]);
            //Console.WriteLine(cars[2]);

            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corevette";

            for (int i = 0; i < cars.Length ; i++)
            {
                Console.WriteLine(cars[i]);
            }
            



        Console.ReadKey();
        }

    }
}