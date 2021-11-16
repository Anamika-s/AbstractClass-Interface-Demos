using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfaceDemos
{
    class Rectangle : Shape
    {
        int length, width;
        public override void Get()
        {
            Console.WriteLine("Enter Length");
            length = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Width");
            width = Convert.ToByte(Console.ReadLine());

        }
        public override void CalculateArea()
        {
            area = length * width;
        }
       
    }
}
