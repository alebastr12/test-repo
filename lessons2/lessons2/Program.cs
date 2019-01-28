/*
1. Написать метод, возвращающий минимальное из трех чисел.
2. Написать метод подсчета количества цифр числа.
3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел 
авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, 
написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
С помощью цикла do while ограничить ввод пароля тремя попытками.
Бастраков Александр
 */
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
            #region ex4 //Проверка логина и пароля
            int i = 0;
            string login, passw;
            do
            {
                Console.Write("Введите логин:");
                login = Console.ReadLine();
                Console.Write("Введите пароль:");
                passw = Console.ReadLine();
                if (isPass(login, passw))
                {
                    Console.WriteLine("Приветствую, root!");
                    break;
                }
                else {
                    Console.Clear();
                    Console.WriteLine("Неверный логин или пароль, попробуйте ещё раз. У вас {0} попыток", 2 - i);
                    i++;
                }
            } while (i < 3);
            if (i == 3)
            {
                Console.WriteLine("Вы не прошли авторизацию, для выхода нажмите любую клавишу.");
                Console.ReadKey();
                return;
            }
            #endregion
            #region ex3 //Сумма нечетных положительных цифр
            Console.WriteLine("Введите целые числа, признаком конца является ввод нуля:");
            int numIn;
            int sum = 0;
            while(true)
            {
                numIn = int.Parse(Console.ReadLine());
                if (numIn == 0) break;
                else
                {
                    if ((numIn > 0) && (numIn % 2 != 0))
                    {
                        sum += numIn;
                    }
                }
            }
            Console.WriteLine("Сумма положительных нечетных чисел: {0}", sum);
            Console.ReadKey();
            #endregion
            #region ex2 //Подсчет количества цифр
            Console.Write("Введите число: ");
            Console.WriteLine("В числе {0} цифр.",numberIn(int.Parse(Console.ReadLine())));
            Console.ReadKey();
            #endregion
            #region ex1 //Нахождение минимального из трех
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
        /// <summary>
        /// Метод проверки логина и пароля
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="passw">Пароль</param>
        /// <returns>Возвращает истину, если логин и пароль верны, иначе ложь</returns>
        static bool isPass(string login, string passw)
        {
            if (login == "root" && passw == "GeekBrains") return true;
            else return false;
        }
    }
}
