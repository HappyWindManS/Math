using System;

namespace EuclideanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(arithmetic(465, 45));
            Console.ReadKey();
        }
        /// <summary>
        /// 欧几里得算法
        /// 辗转相除法：求出两数之间最大公因数的算法
        /// god(a,b) = god(b,a mod b)
        /// god(a,b) = god(b,a%b)
        /// </summary>
        static int arithmetic(int num1, int num2)
        {
            if(num2==0)
            {
                return num1;
            }
            if (num1 % num2 == 0)
            {
                return num2;
            }
            return arithmetic(num2, num1 % num2);
        }
    }
}

