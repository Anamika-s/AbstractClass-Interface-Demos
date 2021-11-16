using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfaceDemos
{
    class CIrcle : Shape
    {
        int radius;
        public override void CalculateArea()
        {
            area = (int) 3.14 * radius * radius;
        }

        public override void Get()
        {
            Console.WriteLine("Enter Radius");
            radius = Convert.ToByte(Console.ReadLine());
        }
    }
}
