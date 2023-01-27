using System;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // method = performs a section of code, whenever it's called "invoked",
            //          benefit = Let's us reuse code w/o writing it multiple times

            string name = "Gunay";
            int age = 26;


            singHappyBirthday(name,age); 
          
        Console.ReadKey();
        }
        static void singHappyBirthday(String birtdayBoy, int yearsOld)
        {
            Console.WriteLine("Happy birtday to you!");
            Console.WriteLine("Happy birtday to you!");
            Console.WriteLine("Happy birtday dear " + birtdayBoy + "!");
            Console.WriteLine("You are " + yearsOld + " years old!");
            Console.WriteLine();
        }
    }
}