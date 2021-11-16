using System;

namespace AbstractClassInterfaceDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            Console.WriteLine("Rectangle");
            shape = new Rectangle();
            shape.Get();
            shape.CalculateArea();
            shape.DisplayArea();
            shape = new Square();
            Console.WriteLine("Square");
            shape.Get();
            shape.CalculateArea();
            shape.DisplayArea();



        }
    }
}
