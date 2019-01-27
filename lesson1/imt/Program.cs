/*
 * 2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
 * по формуле m/h*h’; где m — масса тела в килограммах, h — рост в метрах
 * Бастраков Александр
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imt
{
    class Program
    {
        static void Main(string[] args)
        {
            uint growth, weight;
            do{
                Console.Clear();
                Console.Write("Введите свой вес (целое число килограммах):");
            } while (!uint.TryParse(Console.ReadLine(), out weight));
            do{
                Console.Clear();
                Console.Write("Введите свой рост (целое число в сантиметрах):");
            } while (!uint.TryParse(Console.ReadLine(), out growth));
            float growInM = (float)growth / 100;
            Console.WriteLine("Ваш ИМТ:{0:F2}",(float)weight/(growInM * growInM));
            Console.ReadKey();
        }
    }
}
