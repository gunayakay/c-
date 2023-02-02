using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(String[] args )
        {

            /*
            Car[] garage = new Car[3];

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lamborghini");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;
            */

            Car[] garage = { new Car("Lamborghini"), new Car("Corvette"), new Car("Mustang") };

            Console.WriteLine(garage[0].model +" 1");
            Console.WriteLine(garage[1].model + " 2");
            Console.WriteLine(garage[2].model + " 3");


            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }
            Console.ReadKey();
        }

    }
   class Car
    {
     public  String model;

     public Car (String model)
        {
            this.model = model;
        }
    }
}