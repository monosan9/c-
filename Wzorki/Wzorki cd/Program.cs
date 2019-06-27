using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorki_cd
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();


        //c
        //{

        //    for (int i = 0; i < n; i++)
        //    {
        //        Star();
        //    }
        //    NewLine();

        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        for (int j = 0; j < i +1; j++)
        //            Space();
        //        StarLn();
        //    }

        //    for (int i = 0; i < n +1; i++)
        //    {
        //        Star();
        //    }
        //    NewLine();


        //    Console.ReadKey();

        //}

        //static void Main(string[] args) //n - wysokosc, linie 
        //{
        //    LiteraZOdwrócona(10);

        //}

        //static void LiteraZ(int n)
        //{

        //    for (int i = 0; i < n; i++)
        //    {
        //        Star();
        //    }
        //    NewLine();

        //    for (int i = 0; i < n - 2; i++)
        //    {
        //        for (int j = 0; j <n- i-2; j++)
        //            Space();
        //        StarLn();
        //    }

        //    for (int i = 0; i < n; i++)
        //    {
        //        Star();
        //    }

        //    Console.ReadKey();

        //}

        //static void Main(string[] args) //n - wysokosc, linie 
        //{
        //    LiteraZ(4);

        //}
        static void KlepsydraInna(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            for (int i = 0; i < n / 2 - 1; i++)
            {
                for (int j = 1; j < i + 2; j++)
                    Space();
                Star();
            

                for (int j = 0; j < n - 3 - 2 * i - 1; j++)
                    Space();
                StarLn();
            }


            for (int i = 0; i < n / 2 - 2; i++)
            {
                for (int j = 0; j < n / 2 - i - 2; j++)
                    Space();
                Star();

                for (int j = 0; j < 2 * i + 2; j++)
                    Space();
                StarLn();
            }

            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            Console.ReadKey();

        }

        static void Main(string[] args) //n - wysokosc, linie 
        {
            KlepsydraInna(8);

        }
    }
}
