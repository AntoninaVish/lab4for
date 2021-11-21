using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            for (int i=1; ; i++)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}", i, N+=2*i-1);
            }
            Console.ReadKey();
        }
    }
}
