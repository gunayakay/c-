using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(String[] args )
        {
            // object = An instance of a class.
            //          A class can be used as a bluepoint to create objects. (OOP)
            //          objects can have fields & methods (characteristics & actions)

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2010, "blue");
            car1.Drive();
            car2.Drive();
        }

    }
    class Car
    {
        String make;
        String model;
        String color;
        int year;

        public Car(String make, String model, int year, String color)
        {
            this.color = color;
            this.make = make;
            this.model = model;
            this.year = year;
        }
        public void Drive()
        {
            Console.WriteLine($"You drive the {make} {model}");
        }
    }

}