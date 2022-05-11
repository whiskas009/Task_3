using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите Ваш род деятельности");
            string profession = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст");
            string age = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, Вам {age}, и Вы {profession}");
        }
    }
}
