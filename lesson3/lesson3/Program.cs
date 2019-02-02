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
                    a = new fraction(num, denom);
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
                    b = new fraction(num, denom);
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
                Console.WriteLine($"{a.ToString()}" + op.ToString() + $"{b.ToString()}={rez.ToString()} ({rez.ToDouble().ToString()})");
                Console.WriteLine("Для выходанажмите q, для повтора любую другую клавишу.");
            } while (Console.ReadKey(false).KeyChar != 'q');
        }

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
