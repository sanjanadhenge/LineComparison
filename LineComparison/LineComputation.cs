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
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2");
            int d1 = Convert.ToInt32(Console.ReadLine());
            double result1 = Math.Sqrt(Math.Pow((b1 - a1), 2) + Math.Pow((d1 - c1), 2));
            Console.WriteLine("Enter x1");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1");
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2");
            int d2 = Convert.ToInt32(Console.ReadLine());
            double result2 = Math.Sqrt(Math.Pow((b2 - a2), 2) + Math.Pow((d2 - c2), 2));
            check(result1, result2);

        }
        public void check(double a, double b)
        {
            //UC4-Use CompareTo Method to compare two lines
            double status = a.CompareTo(b);
            if (status > 0)
            {
                Console.WriteLine("{0} is greater than {1}", a, b);
            }
            else if (status < 0)
            {
                Console.WriteLine("{0} is less than {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} is equals {1}", a, b);
            }
        }
    }
}
