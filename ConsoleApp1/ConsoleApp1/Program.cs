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
            }
            Console.ReadLine();
        }
    }
}
