using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorki
{
    class Program
    {
        const char CHAR = '*';

        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();
        // Prostokąt
        //public static void Prostokat(int n, int m) //n - szerokosc, linia pionowa, m - dlugosc, linia pozioma
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        Star();
        //    }
        //    NewLine();

        //    for (int j = 1; j < m - 1; j++)
        //    {
        //        Star();
        //        for (int i = 1; i < n - 1; i++)
        //            Space();

        //        StarLn();
        //    }

        //    for (int i = 0; i < n; i++)
        //    {
        //        Star();
        //    }
        //    NewLine();
        //}
        //public static void Main(string[] args)
        //{
        //    Prostokat(5, 7);
        //}

        //Litera X



        static void LiteraX(int n) // n- wysokosc, linie pionowe
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n + 1;

            //górna połówka
            for (int i = 0; i < n / 2; i++) // 01234 w sumie 5 narysowanych gwiazdek 0<5 etc
            {
                for (int j = 0; j < i; j++)
                    Space();
                Star();
                for (int j = 0; j < n - 2 - 2 * i; j++) //j < 10 - 2 - 2 x i
                    Space();
                StarLn();
            }

            //pojedyncza gwiazdka w środku
            for (int i = 0; i < n / 2; i++)
            {
                Space();
            }
            StarLn();
            //dolna połówka, symetrycznie do górnej
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j< (n/2)-i -1; j++)
                    Space();
                Star();
                for (int j = 0; j < 2 * i +1; j++)
                    Space();
                StarLn();
            }
        }


        static void Main(string[] args)
        {
            LiteraX(12);
            
        }
    }
}
