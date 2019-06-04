using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

    class TriangleSolver
    {
        public static string Analyze(
            int Edge1, 
            int Edge2, 
            int Edge3)
        {
            string result = string.Empty;

            if ((Edge1 + Edge2) > Edge3 && (Edge2 + Edge3) > Edge1 && (Edge3 + Edge1) > Edge2)
            {
                if ((Edge1 == Edge2) && (Edge2 == Edge3))
                {
                    result = "This is a Equilateral Triangle";
                }
                else if ((Edge1 == Edge2) || (Edge2 == Edge3) || (Edge3 == Edge1))
                {
                    result = "This is a Isosceles Triangle.";
                }
                else if ((Edge1 != Edge2) && (Edge2 != Edge3))
                {
                    result = "This is a Scalene Triangle.";
                }
            }
            else
            {
                result = "This Triangle is not a Valid one.";
            }

            return result;
        }
    }
}
