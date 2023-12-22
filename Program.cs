using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество случайных фамилий: ");
            if (int.TryParse(Console.ReadLine(), out int chislofamiliy))
            {
                NameGenerator nameGenerator = new NameGenerator();
                for (int i = 0; i < chislofamiliy; i++)
                {
                    string name = nameGenerator.GenerateName();
                    string surname = nameGenerator.GenerateSurname();
                    string otchestvo = nameGenerator.GeneratePatronymic();
                    Console.WriteLine($"{surname} {name} {otchestvo}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода числа.");
            }
            Console.ReadLine();
        }
     
    }
}
        
    

