using System;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(String[] args )
        {

            // string interpolation = allows us to insert variables into a string literal.
            //                        precede a string literal with $       
            //                        {} are placeholders.

            string firstName = "Gunay";
            string lastName = "Akay";
            int age = 25;

            Console.WriteLine("My name is " +  firstName +" "+ lastName + ". I'm " + age + " years old");
            Console.WriteLine($"My name is {firstName} {lastName}. I'm {age} years old");
            Console.ReadKey();
        }


    }

}