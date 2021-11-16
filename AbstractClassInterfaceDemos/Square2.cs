using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfaceDemos
{
    class Square2 : IShape
    {
        int side, area;
        public void Calculate()
        {
            area = side * side;
        }

        public void Display()
        {
            Console.WriteLine("Area is " + area);
        }

        public void Get()
        {
            Console.WriteLine("Enter Side");
            side = Convert.ToByte(Console.ReadLine());

        }
    }
     
}
