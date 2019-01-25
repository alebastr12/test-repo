/*
 1.	Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
 В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.
Бастраков Александр
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profile
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, age, growth, weight;
            Console.Write("Введите свое имя:");
            name = Console.ReadLine();
            Console.Clear();
            Console.Write("Введите свою фамилию:");
            surname = Console.ReadLine();
            Console.Clear();
            do
            {
                Console.Write("Введите свой возраст (число):");
                age = Console.ReadLine();
                Console.Clear();
            } while (!uint.TryParse(age,out _));
            do
            {
                Console.Write("Введите свой рост (число):");
                growth = Console.ReadLine();
                Console.Clear();
            } while (!uint.TryParse(growth, out _));
            do
            {
                Console.Write("Введите свой вес (число):");
                weight = Console.ReadLine();
                Console.Clear();
            } while (!uint.TryParse(weight, out _));
            Console.WriteLine(name + " " + surname + "\nВозраст:" + age + "\nРост" + growth + "\nВес:" + weight);
            Console.WriteLine("{0} {1}\nВозраст:{2}\nРост:{3}\nВес:{4}",name,surname,age,growth,weight);
            Console.WriteLine($"{name} {surname}\nВозраст:{age}\nРост:{growth}\nВес:{weight}");
            Console.ReadKey();
        }
    }
}
