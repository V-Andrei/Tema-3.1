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
            //Ex10();

            //Ex12();
            //Ex13();


            //Ex18();



            Console.ReadLine();
        }

        private static void Ex18()
        {
            int[] number = { 4, 3, 1, 2, 7, 6, 5 };
            bool flag = true;
            int temp;
            int numLength = number.Length;

            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            foreach (int num in number)
            {
                Console.WriteLine(num);
            }
        }

        private static void Ex13()
        {
            Console.WriteLine("Scrieti un numar:");
            int j = Convert.ToInt32(Console.ReadLine());

            if (ThePrime(j))
            {
                Console.WriteLine("Este prim.");
            }
            else
            {
                Console.WriteLine("Nu este prim.");
            }
        }

        private static bool ThePrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
               

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }                  
            }               
            return true;
        }
        private static void Ex12()
        {
            int isAmstrong = 371;
            int i = 0;
            int sum = 0;
            int theNumber;
            theNumber = 371;


            while (isAmstrong > 0)
            {
                i = isAmstrong % 10;
                sum = sum + (i * i * i);

                isAmstrong = isAmstrong / 10;
            }
            if (theNumber == sum)
            {
                Console.WriteLine("Este numar Amstrong");
            }
            else
            {
                Console.WriteLine("Nu este numbar Amstrong");
            }
        }

        private static void Ex10()
        {
            char[] str = "mamaliga".ToCharArray();
            int n = str.Length;
            Console.WriteLine(removeDuplicate(str, n));
        }

        static String removeDuplicate(char[] str, int n)
        {
            int index = 0;

            for (int i = 0; i < n; i++)
            {

                int j;
                for (j = 0; j < i; j++)
                {
                    if (str[i] == str[j])
                    {
                        break;
                    }
                }

                if (j == i)
                {
                    str[index++] = str[i];
                }
            }
            char[] ans = new char[index];
            Array.Copy(str, ans, index);
            return String.Join("", ans);
        }

        private static void Ex9()
        {
            Console.WriteLine("Enter a number ");
            int i = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("Enter a number ");
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
