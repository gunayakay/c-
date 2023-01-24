using System;


namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop = repeats some code a FINITE amounts of times

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // countdown 
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
                Console.WriteLine("Happy new year!!");

            
            Console.ReadKey();
        }

    }
}