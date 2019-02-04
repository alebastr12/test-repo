using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            fraction a, b, rez;
            int num, denom;
            do
            {
                Console.Write("Введите первую дробь в формате x/y:");
                if (parseFract(Console.ReadLine(), out num, out denom))
                {
                    try
                    {
                        a = new fraction(num, denom);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
                else {
                    Console.WriteLine("Неверный формат!");
                    continue;
                }
                Console.Write("Введите операцию (+,-,*,/):");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("Введите вторую дробь в формате x/y:");
                if (parseFract(Console.ReadLine(), out num, out denom))
                {
                    try
                    {
                        b = new fraction(num, denom);
                    } catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный формат!");
                    continue;
                }
                switch (op)
                {
                    case '+': rez = a.sum(b);
                        break;
                    case '-': rez = fraction.sub(a, b);
                        break;
                    case '*': rez = a.mult(b);
                        break;
                    case '/': rez = fraction.div(a, b);
                        break;
                    default:
                        Console.Write("Неизвестная операция!");
                        continue;
                        
                }
                rez.simpleFr();
                Console.WriteLine($"{a.ToString()}" + op.ToString() + $"{b.ToString()}={rez.ToString()} ({rez.ToDouble().ToString()})");
                Console.WriteLine("Для выходанажмите q, для повтора любую другую клавишу.");
            } while (Console.ReadKey(false).KeyChar != 'q');
        }
        /// <summary>
        /// Парсер дроби из строки в формате x/y
        /// </summary>
        /// <param name="str">Исходная строка</param>
        /// <param name="num">Параметр для записи числителя</param>
        /// <param name="denom">Параметр для записи знаменателя</param>
        /// <returns>Возвращает true в случае успеха, иначе false</returns>
        static bool parseFract(string str,out int num,out int denom)
        {
            num = 0;
            denom = 1;
            string[] numStr = str.Split('/');
            if (numStr.Length != 2) return false;
            if (int.TryParse(numStr[0], out num) && int.TryParse(numStr[1], out denom))
            {
                return true;
            }
            else return false;
        }
    }
}
