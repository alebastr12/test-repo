
/*
 *1. Изменить программу вывода таблицы функции так, чтобы можно было передавать
 * функции типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 * Бастраков Александр
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableF
{
    delegate double MyDelegate(double x1, double x2);
    class Program
    {
        public static void Table(MyDelegate F, double x1, double x2, double b)
        {
            Console.WriteLine("----- X1 ------ X2 ------ Y -----");
            while (x1 <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", x1, x2, F(x1,x2));
                x1 += 1;
                x2 += 1;
            }
            Console.WriteLine("---------------------------------");
        }
        // Создаем методы для передачи его в качестве параметра в Table
        public static double MyFunc1(double x1, double x2)
        {
            return x1 * x2 * x2;
        }
        public static double MyFunc2(double x1, double x2)
        {
            return x1 * Math.Sin(x2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции MyFunc1 (x1*x2^2):");
            Table(new MyDelegate(MyFunc1), 0, 5, 7);
            Console.WriteLine();
            Console.WriteLine("Таблица функции MyFunc1 (x1*x2^2):");
            Table(MyFunc2, -2, 2,5);
            Console.ReadKey();

        }
    }
}
