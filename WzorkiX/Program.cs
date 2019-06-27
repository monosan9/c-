using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorkiX
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();
        
        
            static void LiteraX(int n)

            {
            if (n % 2 == 0) n = n + 1;


            for (int i = 0; i < n / 2; i++)
                {
                    for (int j = 0; j < i; j++)
                        Space();
                    Star();
                for (int j = 0; j < n - 2 - 2 * i; j++)
                    Space();
                StarLn();
                }

                for (int i = 0; i < n / 2; i++)
                {
                    Space();
                }
                StarLn();

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < (n / 2) -1 - i; j++)
                    Space();
                Star();

                for (int j = 0; j < 2 * i + 1; j++)
                    Space();
                StarLn();

            }


                Console.ReadKey();

            }

            static void Main(string[] args) //n - wysokosc, linie 
            {
                LiteraX(8);

            }
        }
    }

