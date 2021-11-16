using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfaceDemos
{
    class Triangle : Shape
    {
        int Base, height;
        public override  void Get()
        {
            Console.WriteLine("Enter Base");
            Base = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter height");
            height = Convert.ToByte(Console.ReadLine());

        }
        public override void CalculateArea()
        {
            area = height * height;
        }
            
    }
}
