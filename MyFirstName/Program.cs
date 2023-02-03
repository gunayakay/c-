using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            // Lists = data structure that represents a list of objects that can be accessed by index
            //         Similar to arrray, but can dynamically increase/decrease in size 
            //         using System.Collections.Generic;

            /*
            String[] food = new String[3];

            food[0] = "pizza";
            food[1] = "hamburger";
            food[2] = "hotdog";
            */

            List<String> food = new List<String>();
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("fries");
            food.Add("hotdog");
            food.Add("hamburger");

            String[] foodArray = food.ToArray();
            //food.Remove("pizza");
            //food.Insert(0,"sushi");
            //food.Sort(); 
            //food.Reverse();
            //food.Clear();
            //Console.WriteLine(food.Contains("pizza"));
            //Console.WriteLine(food.IndexOf("hamburger"));
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.LastIndexOf("hamburger"));


            foreach (String item in foodArray)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    
    }


    
}