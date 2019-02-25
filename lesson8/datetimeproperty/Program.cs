/*
 1.	С помощью рефлексии выведите все свойства структуры DateTime
 Бастраков Александр
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace datetimeproperty
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            PropertyInfo[] props = dt.GetType().GetProperties();
            Console.WriteLine($"Это все свойства типа {dt.GetType().ToString()}");
            foreach (var item in props)
            {
                Console.WriteLine($"{item.ToString()}");
            }
            Console.ReadKey();
        }
    }
}
