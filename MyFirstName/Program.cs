using System;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(String[] args )
        {
            // overloaded constructor = technique to create multiple constructor, 
            //                          with a different set of paramater
            //                          name + parameter = signature

            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozarella", "pepperoni");
            Pizza pizza2 = new Pizza("stuffed crust", "red sauce", "mozarella");
            Pizza pizza3 = new Pizza("stuffed crust", "red sauce");
            Pizza pizza4 = new Pizza("stuffed crust");

            Console.ReadKey();
        }

    }
    class Pizza
    {

        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
            
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
         
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese,String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping= topping;
        }
    }
}