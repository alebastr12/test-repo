﻿/*
5.*а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, 
заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, 
сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, 
возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, 
используя модификатор ref или out).
**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
**в) Обработать возможные исключительные ситуации при работе с файлами.
Бастраков Александр
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tworankarray
{
    public class ArrayTwoRank
    {
        int[,] array;
        /// <summary>
        /// Конструктор класса, заполняет элементы массива случайными числами
        /// </summary>
        /// <param name="x">размерность по "горизонтали"</param>
        /// <param name="y">размерность по "вертикали"</param>
        public ArrayTwoRank(uint x, uint y)
        {
            Random r = new Random();
            array = new int[x, y];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(100);
                }
            }
        }
        /// <summary>
        /// Конструктор читает данные из файла для инициализации массива. Значения в файле 
        /// должны быть записаны в строки, числа в строкахразделены пробелами. Количество чисел в сроках одинаковое.
        /// </summary>
        /// <param name="filename">Путь к файлу</param>
        public ArrayTwoRank(string filename)
        {
            string[] fileStrings;
            try
            {
                fileStrings = File.ReadAllLines(filename);
            }
            catch (Exception e)
            {
                throw;
            }
            string[][] numStrings = new string[fileStrings.Length][];
            for (int i = 0; i < fileStrings.Length; i++)
            {
                numStrings[i] = fileStrings[i].Split(' ');
            }
            array = new int[fileStrings.Length, numStrings[0].Length-1];

            for (int i = 0; i < fileStrings.Length; i++)
            {
                for (int j = 0; j < numStrings[0].Length-1; j++)
                {
                    if(!int.TryParse(numStrings[i][j],out array[i, j])) {
                        throw new Exception("Ошибка формата файла - не число или неверный формат. Файл должен содержать " +
                            "строки чисел разделенных пробелами. Количество чисел в строках должно быть одинаковым.");
                    }
                }
            }
        }
        /// <summary>
        /// Сохранение массива в файл
        /// </summary>
        /// <param name="filename">имя файла</param>
        public void ToFile(string filename)
        {
            try
            {
                File.WriteAllText(filename, ToString());
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public override string ToString()
        {
            string res = string.Empty;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    res += string.Format("{0} ", array[i, j]);
                }
                res += string.Format("\r\n");
            }
            return res;
        }
        /// <summary>
        /// Подсчитывает сумму всех элементов массива
        /// </summary>
        /// <returns>возвращает сумму</returns>
        public long SumOf()
        {
            long sum = 0;
            foreach (var item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        /// <summary>
        /// Подсчитывает сумму всех элементов массива больше a
        /// </summary>
        /// <param name="a">параметр</param>
        /// <returns>возвращает сумму</returns>
        public long SumOfMore(int a)
        {
            long sum = 0;
            foreach (var item in array)
            {
                if (item>a) sum = sum + item;
            }
            return sum;
        }
        /// <summary>
        /// Максимальное значение в массиве
        /// </summary>
        public int Max
        {
            get
            {
                int max = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 1; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] > max) max = array[i, j];
                    }
                }
                return max;
            }
        }
        /// <summary>
        /// Минимальное значение в массиве
        /// </summary>
        public int Min
        {
            get
            {
                int min = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 1; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < min) min = array[i, j];
                    }
                }
                return min;
            }
        }
        /// <summary>
        /// Возвращает максимальное число из массива и индекс этого числа
        /// </summary>
        /// <param name="x">Параметр для индекса x</param>
        /// <param name="y">Параметр для индекса y</param>
        /// <returns>Максимальное число</returns>
        public int IndexOfMax(out uint x,out uint y)
        {
            x = y = 0;
            int max = array[0, 0];
            for (uint i = 0; i < array.GetLength(0); i++)
            {
                for (uint j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        x = i;
                        y = j;
                    }
                }
            }
            return max;
        }
    }
}
