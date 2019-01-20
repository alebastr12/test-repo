using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            while (true) {
                Console.Clear();
                Console.WriteLine("Как тебя зовут?");
                name = Console.ReadLine();
                if (name.Length == 0)
                {
                    System.Windows.MessageBox.Show("Имя!!");
                }
                else break;
            }
            Console.WriteLine("Привет, {0}", name);
            Console.WriteLine("Вот кое что о твоей машине:");
            ShowEnvironmentDetail();
            System.Windows.MessageBox.Show($"Это все, {name}!");
        }
        private static void ShowEnvironmentDetail()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Количество ядер: {0}", Environment.ProcessorCount);
            Console.WriteLine("Версия .NET: {0}", Environment.Version);
        }
    }
}
