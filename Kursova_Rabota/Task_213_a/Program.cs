using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_213_a
{
    class Program
    {
        static void Main()
        {
            int n = 49;
            int sum = 0;
            for(int i= 1; i <= n; i+=2 )
            {
                sum += i;
            }
            Console.WriteLine("1+3+5+7+...+47+49=" + " " + sum);
        }
    }
}
