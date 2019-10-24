using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex8();
            //Ex9();




            Console.ReadLine();
        }

        private static void Ex9()
        {
            int i = 3;
            Console.Write(countSetBits(i));
        }
        private static int countSetBits(int n)
        {
            int count = 0;
            while (n > 0)
                {
                    count += n & 1;
                    n >>= 1;
                }
            return count;
            
        }
        private static void Ex8()
        {
            Console.WriteLine("Enter a number to stop Fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = displayFibonacci(n);

            Console.WriteLine(a);
        }
        private static int displayFibonacci(int num)
        {
            int n = num - 1;
            int[] val = new int[n + 1];

            val[0] = 0;
            val[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                val[i] = val[i - 2] + val[i - 1];
            }

            return val[n];

        }
    }
}
