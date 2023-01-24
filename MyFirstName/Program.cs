using System;


namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num = random.Next(1,6);
            int num2 = random.Next(1,6);

            //double num = random.NextDouble();

            Console.WriteLine(num);
            Console.WriteLine(num2);

            Console.ReadKey();

        }

    }
}