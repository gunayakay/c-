﻿using System;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(String[] args )
        {

        // params keyword = a method parameter that takes a variable number of arguments.
        //                  the parameter type must be a single - dimensional array

        double total = CheckOut(3.99, 5.75,15);
        Console.WriteLine(total);
        Console.ReadKey();
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += total;

            }
            return total;
        }
    }

}