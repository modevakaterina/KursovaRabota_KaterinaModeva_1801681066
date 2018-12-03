using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_397
{
    class Program
    {
        static double Kelvin(double t)
        {
            t += 273.15;
            return t;

        }
        static void Main(string[] args)
        {
            Console.Write("Vyvedete broy dni ot meseca, za koito da se izvyrshat izchisleniya:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Srednata dnevna temperetuta( v celzievi gradusi) za:");
            double[] d_temp = new double[31]; double t;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Den {0} e:", i + 1);


                do
                {
                    t = double.Parse(Console.ReadLine());
                }
                while (t < -50 || t > 50);
                d_temp[i] = t;
            }
            double min_temp = d_temp[0], max_temp = d_temp[0];
            for(int i=0; i<n; i++)
            {
                if(d_temp[i]<min_temp)
                {
                    min_temp = d_temp[i];
                }
                if(d_temp[i]>max_temp)
                {
                    max_temp = d_temp[i];
                }
                Console.WriteLine("Razlikata mejdu maksimalnata i minimalnata sredna dnevna temperatura prez tezi dni e {0} celzievi i {1} kelvinovi gradusa.", max_temp - min_temp, Kelvin(max_temp - min_temp));
                Console.WriteLine("Srednata dnevna temperetura(v kelvinovi gradusi) za:");
                for(int s = 0;s < n; s++)
                {
                    Console.Write("Den {0} e:", s + 1);
                    Console.WriteLine(Kelvin(d_temp[i]));
                }
                Console.ReadKey(true);
            }

            

        }
    }

}
