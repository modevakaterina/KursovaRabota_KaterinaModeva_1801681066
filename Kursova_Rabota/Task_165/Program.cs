using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_165
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyvedete stoynostite na trite strani:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p;
            if ((a + c < b) || (a + b < c) || (b + c < a))
            {
                Console.WriteLine("Ne syshtestvuva triygylnik");

            }
            else
            {
                if ((a == b) && (a == c) && (b == c))
                {
                    Console.WriteLine("ravnostranen");
                }
                else if ((a == b) || (b == a) || (a == c))
                {
                    Console.WriteLine("ravnobedren");
                }
                else
                {
                    Console.WriteLine("raznostranen");
                }
                p = (a + b + c) / 2;

                double Litse (double num1, double num2, double num3, double num4)

                {
                   
                    Math.Sqrt(num4 * (num4 - num1) * (num4 - num2) * (num4 - num3));
                    Litse(a, b, c, p);

                }

                Console.WriteLine("Litseto na triygylnika e" + Litse(a, b, c, p));

            }   


            
        }
    }
}
