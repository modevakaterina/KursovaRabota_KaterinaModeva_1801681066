using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_a
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, t;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
            t = 1 * Math.Cos(x) * (a - c) * ((b - a) / 2 * b + c);
            Console.WriteLine("The result is:" + " " + t);

        }
    }
}
