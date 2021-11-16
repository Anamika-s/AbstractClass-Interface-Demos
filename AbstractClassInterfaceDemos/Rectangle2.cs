using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfaceDemos
{
    class Rectangle2 : IShape
    {
        int length, width, area;
        public void Calculate()
        {
            area = length * width;
        }

        public void Display()
        {
            Console.WriteLine("Area is " + area);
        }

        public void Get()
        {
            Console.WriteLine("Enter Length");
            length = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Width");
            width = Convert.ToByte(Console.ReadLine());

        }
    }
}
