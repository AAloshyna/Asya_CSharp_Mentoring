using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    struct StructRectangle
    {
        private readonly int _side1;
        private readonly int _side2;
       
        public int Area { get; }

        public int Perimeter { get; }
      
        public StructRectangle(int side1, int side2)
        {
            _side1 = side1;
            _side2 = side2;
            Area = _side1 * _side2;
            Perimeter = (2 * _side1) + (2 * _side2);
        }

        public void Display()
        {
            Console.WriteLine($"Side1: {_side1}, Side2: {_side2}, Area: {Area}, Perimenter: {Perimeter}");

        }

    }
}
