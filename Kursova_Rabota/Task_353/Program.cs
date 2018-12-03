using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_353
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proverka = true;
            Console.WriteLine("Vyvedete dyljinata na masiva:");
            int dyljina = int.Parse(Console.ReadLine());
            int[] masiv = new int[dyljina];
            Console.WriteLine("Vyvedete elementite na masiva:");
            for(int i=0;i<masiv.Length;i++)
            {
                Console.Write("element{0}", i);
                masiv[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vyvedete element:");

                int Read(int x,int y)

            {
                int element = int.Parse(Console.ReadLine());
                if (element < x || element > y)
                {
                    proverka = false;
                    Console.WriteLine("Elementyt ne e chast ot masiva");

                }
                if (proverka)
                {
                    Console.WriteLine("Elementyt e v intervala.");
                }
            }
           Console.WriteLine( Read(masiv[0], masiv.Length));
    }    }
}
