/*
 а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)). Вывести результат, используя спецификатор формата 
.2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
Бастраков Александр
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] coor = new double[4];
            while (true)
            {
                Console.Write("Ведите координаты точек через пробел (x1 y1 x2 y2):");
                string coorString = Console.ReadLine();
                string[] coorMas = coorString.Split(' ');
                if (coorMas.Length != 4)
                {
                    Console.WriteLine("Недостаточно аргументов.");
                    continue;
                }
                for(int i = 0; i < 4; i++)
                {
                    if (!double.TryParse(coorMas[i],out coor[i]))
                    {
                        Console.WriteLine("Неверный формат у аргумента {0}.",i);
                        break;
                    } else if (i==3)
                    {
                        Console.WriteLine("Расстояние между точками равно {0:F2}", LineLength(coor[0], coor[1], coor[2], coor[3]));
                        Console.WriteLine("Для выхода нажмите q, для повтора любую клавишу.");
                        ConsoleKeyInfo key= Console.ReadKey();
                        if (key.KeyChar == 'q') return;
                    }
                }
            }

        }
        static double LineLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
