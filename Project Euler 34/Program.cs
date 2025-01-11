using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Project_Euler_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DigitFactorials(145));
            BigInteger Sum = 0;
            for (int i = 3; i < 100000; i++)
            {
                if (DigitFactorials(i) == i)
                {
                    Console.WriteLine(i);
                    Sum += i;
                }
            }
            Console.WriteLine(Sum);
        }
        static int DigitFactorials (int Number)
        {
            int[] Digits = new int[Number.ToString().Length];
            for (int i = 0; i < Number.ToString().Length; i++)
            {
                Digits[i] = int.Parse( Number.ToString()[i].ToString());
                int LastFactorial = Digits[i];
                int number = 1;
                for (int j = 1; j <= LastFactorial; j++)
                {
                    number *= j;
                }
                Digits[i] = number;
            }
            return Digits.Sum();
        }
    }
}
