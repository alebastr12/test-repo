using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tworankarray;

namespace testLib
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayTwoRank manArray = new ArrayTwoRank(5, 20);
            Console.WriteLine(manArray.ToString());
            Console.WriteLine($"Максимальное: {manArray.Max}");
            manArray.IndexOfMax(out uint xMax, out uint yMax);
            Console.WriteLine($"Индекс максимального элемента: {xMax} {yMax}");
            Console.WriteLine($"Минимальное: {manArray.Min}");
            Console.WriteLine($"Сумма элементов: {manArray.SumOf()}");
            Console.WriteLine($"Сумма элементов больше 15: {manArray.SumOfMore(15)}");
            try
            {
                manArray.ToFile(@"temp.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Чтение из файла in.txt");
            ArrayTwoRank fileArray;
            try
            {
                fileArray = new ArrayTwoRank("in.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(fileArray.ToString());
            Console.WriteLine($"Максимальное: {fileArray.Max}");
            fileArray.IndexOfMax(out xMax, out yMax);
            Console.WriteLine($"Индекс максимального элемента: {xMax} {yMax}");
            Console.WriteLine($"Минимальное: {fileArray.Min}");
            Console.WriteLine($"Сумма элементов: {fileArray.SumOf()}");
            Console.WriteLine($"Сумма элементов больше 15: {fileArray.SumOfMore(15)}");
            Console.ReadKey();
        }
    }
}
