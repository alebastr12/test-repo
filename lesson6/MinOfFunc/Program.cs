/*
 2.	Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить 
минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает 
минимум через параметр (с использованием модификатора out).
Бастраков Александр
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MinOfFunc
{
    delegate double MyFuncDelegate(double x);
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        
        public static double SinF(double x)
        {
            return Math.Sin(x);
        }
        public static double CosF(double x)
        {
            return Math.Cos(x);
        }
        public static double F1divX2(double x)
        {
            return 1/(x*x);
        }
        public static double F1divSin(double x)
        {
            return 1/(Math.Sin(x));
        }
        public static double F1divCos(double x)
        {
            return 1 / (Math.Cos(x));
        }

        public static void SaveFunc(MyFuncDelegate func, string fileName, double a, double b, double h=1)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(func(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double minOut)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            double[] dArr = new double[fs.Length / sizeof(double)];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                dArr[i] = bw.ReadDouble();
                if (dArr[i] < min) min = dArr[i];
            }
            bw.Close();
            fs.Close();
            minOut = min;
            return dArr;
        }

    }
}
