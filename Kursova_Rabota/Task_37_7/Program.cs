using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_37_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            bool v = true;
            bool q = true;
            
            bool izraz1 = (d == t || d != t);
            bool izraz2 = (s + d > 5 * r);
            bool result1 = izraz1 && izraz2;
            bool izraz3 = !(q || !v);
            bool izraz4 = (q && v);
            bool result2 = (izraz3 || izraz4);
            Console.WriteLine("result1 && result2");
         



        }
    }
}
