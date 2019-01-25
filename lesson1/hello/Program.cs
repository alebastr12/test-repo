/*
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).*Создать асс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
Бастраков Александр
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPos("Бастраков Александр, Йошкар-Ола", (Console.WindowWidth/2) - 15, Console.WindowHeight/2);
            Console.ReadKey();
        }
        static void PrintPos(string ms, int x, int y) {
            Console.SetCursorPosition(x, y);
            Console.Write(ms);
        }
    }
}
