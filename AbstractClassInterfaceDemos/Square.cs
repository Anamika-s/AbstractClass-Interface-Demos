using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfaceDemos
{
    class Square : Shape
    {
        int side;
        public override void Get()
        {
            Console.WriteLine("Enter Side");
            side = Convert.ToByte(Console.ReadLine());
            
        }
        public override void CalculateArea()
        {
            area = side * side;
        }
        
    }
}
