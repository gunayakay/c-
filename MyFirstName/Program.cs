using System;


namespace MyFirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            // interface = define a "contact" that all the classes inheriting from should follow

            //             An interface declares "what class should have"
            //             An inheriting class defines "how it should do it"

            //             benefit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();
            fish.Hunt();
            fish.Flee();
            hawk.Hunt();
            rabbit.Flee();

            Console.ReadKey();
        }
    
    }

    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }
    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("Hawk is hunting!");
        }
    }
    class Fish :  IPrey,IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish searching for smaller fish!");
        }
    }

    
}