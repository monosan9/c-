using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stożek
{
    class Program
    {
        static void Main(string[] args)
        {
            double promien = 0;
            double tworzaca =0;

            do
            {
                try
                {
                    Console.WriteLine("Wprowadz promień");
                    promien = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Wprowadz tworzaca");
                    tworzaca = Convert.ToDouble(Console.ReadLine());
                    if (promien <= 0)
                    {
                        Console.WriteLine("Promien musi byc wiekszy niz 0");
                    }
                    if (tworzaca <= 0)
                    {
                        Console.WriteLine("Tworzaca musi byc wieksza niz 0");
                    }

                }


                catch (FormatException)
                {
                    Console.WriteLine("Prosze podać liczbę");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Podana liczba jest za duża");
                }
            } while (promien <= 0 || tworzaca <= 0);
            
    


                double ObjetoscFigury = ObjetoscStozka(promien, tworzaca);
            Console.ReadKey();
        }
        
        public static double ObjetoscStozka(double promien, double tworzaca)
        {
            double h = Math.Sqrt((Math.Pow(tworzaca,2) - Math.Pow(promien,2)));
            double pi = 3.14;

            Console.WriteLine("Wysokosc wynosi " + h);

            double objetosc = ((pi * (promien * promien) * h) / 3);

            Console.WriteLine("Objetosc stozka wynosi " + objetosc);

            return objetosc;
            
        }
        
    }
}
