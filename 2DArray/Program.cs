using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            int maxwiersz = 0;
           // Console.WriteLine("numer wiersza z maksymalna suma= " + KtóryWiersz(tab));

            int[,] tab = new int[5, 3] {
                { 1, 1, 1 }, //wiersz 0 
                { -2, -3, 2 }, // wiersz 1
                { 2, -5, 0 }, // wiersz 2
                { -3, 4, 6 }, //wiersz 3
                { -6, 6, 3 } }; // wiersz 4

            int maxsuma = tab[0, 0];

           
            int suma = 0;

            for (int i = 0; i < 5; i++)
            {
                suma = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}", tab[i, j]);
                    suma = suma + tab[i, j];

                    if (suma > maxsuma)
                    {
                        maxwiersz = i; 
                        maxsuma = suma;
                    }


                }

                Console.Write(" suma =" + "{0}", suma);
                
                Console.WriteLine();

            }
            Console.WriteLine(maxsuma);
            Console.WriteLine(maxwiersz);
            Console.WriteLine();
            

            //int numerwiersza = Array.IndexOf(tab, maxsuma);

            
            Console.ReadKey();

        }

      

       


    }
}
