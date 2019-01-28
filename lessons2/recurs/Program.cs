/*
 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
 б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 Бастраков Александр
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите диапазон чисел через пробел:");
            string[] tempNum = Console.ReadLine().Split(' ');
            recPrintNum(int.Parse(tempNum[0]), int.Parse(tempNum[1]));
            Console.WriteLine();
            Console.WriteLine($"сумма чисел: {recSum(int.Parse(tempNum[0]), int.Parse(tempNum[1]))}");
            Console.ReadKey();
        }
        /// <summary>
        /// Рекурсивный метод вывода чисел от a до b
        /// </summary>
        /// <param name="a">начало диапазона</param>
        /// <param name="b">конец диапазона</param>
        static void recPrintNum(int a, int b)
        {
            if (a > b) return;
            else {
                Console.Write($"{a} ");
                recPrintNum(a + 1, b);
            }
        }
        /// <summary>
        /// Рекурсивный метод подсчета суммы чисел в диапазоне от a до b
        /// </summary>
        /// <param name="a">начало диапазона</param>
        /// <param name="b">конец диапазона</param>
        /// <returns>сумма</returns>
        static int recSum(int a, int b)
        {
            int sum = a;
            if (a >= b) return sum;
            else return sum + recSum(a + 1, b);
        }
    }
}
