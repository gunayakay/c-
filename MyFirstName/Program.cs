using System;


namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = -3;
            double z = 3.14159;
            double t = 3.99;



            double a = Math.Pow(x, 3); // power of x 
            double b = Math.Sqrt(x); // square of x 
            double c = Math.Abs(y); // absolue value of y
            double d = Math.Round(z); // round to down 
            double e = Math.Ceiling(z); // round to up
            double f = Math.Floor(t); // round to 
            double g = Math.Max(x,y); // max value betwenn x-y
            double h = Math.Min(z,t); // min value betwenn z-t
            

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);

            Console.ReadKey();

        }

    }
}