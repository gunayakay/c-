using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(String[] args )
        {

            Car car1 = new Car("Mustang","Red");

            Car car2 = Copy(car1);


            Console.WriteLine(car2.color +" " +car2.model);

            Console.ReadKey();
        }
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
   class Car
    {
     public  String model;
     public  String color;

     public Car (String model,String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}