using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(String[] args )
        {
            // static = modifier to declare a static member, which belongs to the class itself 
            //          rather than to any spesific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lamborghini");


            Console.WriteLine(Car.numbersOfCars);

            Car.StartRace();
        }

    }

    class Car
    {
        String model;
        public static int numbersOfCars;

        public Car(String model)
        {
            this.model = model;
            numbersOfCars++;
        }
        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }

    }
   

}