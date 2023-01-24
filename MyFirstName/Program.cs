﻿using System;


namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // logic operators = Can be used to check if more than 1 condition is true/false
            // && - (AND)
            // || - (OR)

            Console.WriteLine("What is the temperature outside: (C) ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25 )
            {
                Console.WriteLine("It's warm outside");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("DO NOT GO OUTSIDE!!");
            }
            Console.ReadKey();
        }

    }
}