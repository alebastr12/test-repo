using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace examinebase
{
    class Program
    {
        static void Main(string[] args)
        {
            exam list;
            StreamReader sr;
            try
            {
                sr = new StreamReader(@"..//..//learners.txt",Encoding.UTF8);
                list = new exam(sr.ReadToEnd());
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
                Console.ReadKey();
                return;
            }
            sr.Close();
            Console.WriteLine($"Импортировано {list.lenght} записей.");
            list.sort();
            uint i = 1;
            uint j = 0;
            Console.WriteLine("Худшие по среднему баллу ученики:");
            Console.WriteLine(list[0].ToString());
            while (true) //супер цикл для вывода худших учеников
            {
                if (list[i].averScore != list[i - 1].averScore)
                    j++;
                if (j == 3) break;
                else Console.WriteLine(list[i].ToString());
                i++;
            }
            Console.ReadKey();

        }
    }
}
