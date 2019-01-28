using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goodNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            uint nGood = 0;
            for (uint i = 1; i <= 1000000000; i++) {
                if (i % sumOfNum(i) == 0)
                {
                    nGood++;
                }
            }
            Console.WriteLine($"Хороших чисел в диапазоне от 1 до 1000000000: {nGood}");
            Console.WriteLine($"время выполнения: {DateTime.Now-start}");
            Console.ReadKey();
        }
        static uint sumOfNum(uint num)
        {
            uint sum = 0;
            while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            return sum;
        }
    }
}
