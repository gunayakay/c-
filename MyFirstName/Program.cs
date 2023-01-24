using System;


namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double friends = 10;

            // friends = friends + 1;
            // friends += 1;
            // friends++;

            // friends = friends - 1;
            // friends -= 1;
            // friends--;

            // friends = friends * 2;
            //friends *= 2;
            // friends = friends / 2;
            // friends /= 2;

            

            int reminder = (int)(friends % 3);


            Console.WriteLine(friends);
            Console.WriteLine(reminder);

            
            Console.ReadKey();
        }

    }
}