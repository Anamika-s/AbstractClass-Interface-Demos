using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassInterfaceDemos
{
    abstract class Shape
    {
        protected int area;
        public abstract void Get();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
}
