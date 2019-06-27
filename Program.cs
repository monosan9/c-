using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorek_typu_A
{
    class Program
    {
        static void Main(string[] args)
        {

            string line1 = Console.ReadLine();
            int n = Convert.ToInt32(line1); // liczba kolumn
            string line2 = Console.ReadLine();
            int m = Convert.ToInt32(line2);// liczba wierszy

            if (m % 2 == 0)
            {
                m = m + 1;
            }

            if (n % 2 == 0)
            {
                n = n + 1;
            }

           

            for ( int i = 0; i < m ; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 3 == 0)
                    {

                        Console.Write("*");

                    }

                    else if (j % 4 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                   
                }
                Console.WriteLine();

            }
            

            


            



            Console.ReadKey();

        }

       
    }

}
