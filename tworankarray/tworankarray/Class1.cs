using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    array[i, j] = r.Next();
                }
            }
        }
    }
}
