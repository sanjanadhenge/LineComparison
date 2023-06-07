using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LineComparison");
            LineComputation lineComputation = new LineComputation();
            lineComputation.CalculateLength();
        }
    }
}
