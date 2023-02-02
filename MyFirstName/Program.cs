using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(String[] args )
        {
            // abstract classes = modifier that indicates missing components or incomplete implementation

            // Veicle veicle = new Veicle(); its abstract class and we cannot create object

            Console.ReadKey();
        }

    }
    abstract class Veicle
    {

        public int speed = 0;
        public void go()
        {
            Console.WriteLine("This veicle is moving!");
        }
    }
    class Car : Veicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle : Veicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat : Veicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}