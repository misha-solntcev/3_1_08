using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 8. Дано целое число N (> 0). Найти наибольшее целое число K, 
    квадрат которого не превосходит N: K2 < N.
    Функцию извлечения квадратного корня не использовать.*/

namespace _3_1_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 102;
            int K = 0;
            while (K * K <= N)
            {
                Console.WriteLine(K);
                K++;
            }
            Console.ReadKey();
        }
    }
}
