using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2066 to binary {0}.", Convert.ToString(2066, 2));
            Console.WriteLine("100000010010 to decimal is {0}.", Convert.ToInt64("100000010010", 2));
            Console.WriteLine("100000010010 to hexadecimal is {0}.",
            Convert.ToInt64("100000010010", 2).ToString("X"));
        }
    }
}
