using System;


namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant = immutable values which are known at compile time  
            //            and do not change for the life of the program

            const double pi = 3.14159;

           //  pi = 420; we cannot do this when our pi is constant

            Console.WriteLine(pi);
            Console.ReadKey();
        }

    }
}