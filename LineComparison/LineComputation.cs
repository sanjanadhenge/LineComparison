using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineComputation
    {
        public void CalculateLength()
        {
            Console.WriteLine("Enter x1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2");
            int d = Convert.ToInt32(Console.ReadLine());
            double result = Math.Sqrt(Math.Pow((b - a), 2) + Math.Pow((d - c), 2));
            Console.WriteLine(" length = " + result);
        }
    }
}
