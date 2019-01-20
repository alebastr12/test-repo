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
            Console.WriteLine("Как тебя зовут?");
            String name = Console.ReadLine();
            if (name.Length == 0)
            {
                Console.WriteLine("Эй, я спросил как тебя зовут!");
            }
            else {
                Console.WriteLine("Привет, {0}", name);
                Console.WriteLine("Вот кое что о твоей машине:");
                ShowEnvironmentDetail();
            }
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
