using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorek_typu_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n = Convert.ToInt32(line);

            for (int i = 0; i < n; i++) //cala linia gwiazdek
            {
                Console.Write("*");

            }
            Console.WriteLine();

            for (int i = 0; i < n - 2; i++) // -2 bo odejmujemy pierwszy i ostatni wiersz,ktore omija petla wewnetrzna
            {
                for (int j = 0; j < i + 1; j++) // robi piramide z kropek i na końcu dodaje gwiazdke
                     
                    Console.Write(".");

                    Console.Write("*"); 

                for(int j = 0; j< n -i -2 ;j++) //za gwiazdka tworzy odwrotna piramide z kropek
                    
                    Console.Write(".");

                Console.WriteLine();           // dopiero po przejsciu petli przechodzi do kolejnej linii
            }
            
            for (int i = 0; i < n  ; i++) // cała linia gwiazdek
            {
                Console.Write("*");

            }
            Console.WriteLine();

            Console.ReadKey();
        }
       
    }
}
