using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            Console.WriteLine("В числе {0} цифр.",numberIn(int.Parse(Console.ReadLine())));
            Console.ReadKey();
            return;
            #region ex1
            Console.Write("Введите три целых числа разделенных пробелами: ");
            string[] num = Console.ReadLine().Split(' ');
            Console.WriteLine("Минимальное из трех: {0}", Min(int.Parse(num[0]), int.Parse(num[1]),int.Parse(num[2])));
            Console.ReadKey();
            #endregion
        }
        /// <summary>
        /// Метод возвращает минимальное из трех чисел
        /// </summary>
        /// <param name="a">Первое число типа</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        /// <returns>Минимальное число из трех переданных в параметрах</returns>
        static int Min(int a, int b, int c)
        {
            int min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }
        /// <summary>
        /// Метод совершает подсчет цифр в целом числе
        /// </summary>
        /// <param name="a">Передается число</param>
        /// <returns>Количество цифр в числе</returns>
        static uint numberIn(int a)
        {
            uint i = 1;
            while (a / 10 != 0)
            {
                a = a / 10;
                i++;
            }
            return i;
        }
    }
}
