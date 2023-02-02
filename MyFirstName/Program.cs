using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(String[] args )
        {
            // inheritance = one or more child classes recieving fields, methods, etc. from a common parent


            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            car.go();
            Console.WriteLine(car.speed);
            Console.WriteLine($"This car speed is {car.speed}. and have {car.wheels} wheels.");

            Console.ReadKey();
        }

    }
    class Veicle
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
    }
    class Bicycle : Veicle
    {
        public int wheels = 2;
    }
    class Boat : Veicle
    {
        public int wheels = 0;
    }
}