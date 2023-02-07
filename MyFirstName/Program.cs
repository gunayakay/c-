using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            // enums = special "class" that contains a set of named integer constants. 
            //         Use enums when you have values that you know will not change,                                  
            //         To get the integer value from an item, you must explicitly convert to an int

            // name = integer

            // Console.WriteLine(Planets.Saturn + "is planet #" + (int)Planets.Saturn.);

            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("planet: " + name);
            Console.WriteLine("radius: " + radius);
            Console.WriteLine("volume: " + volume);

            Console.ReadKey();
        }
        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }

    
    }
    enum Planets
    {
        Mercury=1,
        Venus=2,
        Earth=3,
        Mars=4,
        Jupiter=5,
        Saturn=6,
        Uranus=7,
        Neptune=8,
        Pluto=9
    }
    enum PlanetRadius
    {
        Mercury=2449,
        Venus=6241,
        Earth=6302,
        Mars=4214,
        Jupiter=52515,
        Saturn=612511,
        Uranus=712412,
        Neptune=41242,
        Pluto=9123
    }
    
}