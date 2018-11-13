using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    static class RectangleArea
    {
        public static int RArea(int side1, int side2)
        {
            int area = side1 * side2;
            return area;
        }

        public static int RArea(ref int side1, ref int side2)
        {
            int area = side1 * side2;
            return area;
        }

        public static void RArea(int side1, int side2, out int area)
        {
            area = side1 * side2;
            Console.WriteLine($"Shows area in Out parameter: {area}");
        }

        //static void RArea(params int[] sides, out int area)
        //{
        //    area = 0;
        //    for (int i = 0; i < sides.Length; i++)
        //    {

        //    }

        //}

    }
}
