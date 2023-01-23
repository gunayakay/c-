using System;


namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int x ; // decleration
            x = 123; // initialization

            int y = 321; // decleration + initialization

            int z = x + y;

            int age = 21; // whole integer
            double height = 300.5; // with decimal points 
            bool alive = true; // it returns true or false 
            char symbol = '@'; // it returns characters like symbols
            string name = "Gunay"; // it returns string value 


            string userName = symbol + name;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("Your age is: " + age +"."); // You can use it with plus
            Console.WriteLine($"Your age is: {age}."); // or with dollar symbol
            Console.WriteLine($"The building height is: {height} cm.");
            Console.WriteLine($"Are You alive? {alive}");
            Console.WriteLine($"Your symbol is: {symbol}");
            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"Your username is: {userName}");
            
        }

    }
}