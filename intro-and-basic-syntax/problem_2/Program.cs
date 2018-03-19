using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Um... well named variables
            double wight = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double result = wight * hight;

            Console.WriteLine("{0:f2}", result);
        }
    }
}
