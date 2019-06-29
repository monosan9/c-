using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revert7
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = Console.ReadLine();
            int n = int.Parse(line);

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < i ; j++)
                {
                    Console.Write(" ");
                    
                }
                Console.WriteLine("*");
            }

            Console.ReadKey();
        }
        
    }
}
