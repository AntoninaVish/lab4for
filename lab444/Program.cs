using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab444
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int N = 1; ; N++)
            for (int i = 1; ; i++)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}", N, N=N+2*i-1);
            }
                      
            Console.ReadKey();            
        }
    }
}
