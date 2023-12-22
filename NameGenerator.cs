using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NameGenerator
    {
        private string[] names = { "Иван", "Петр", "Сергей", "Александр", "Дмитрий" };
        private string[] surnames = { "Иванов", "Петров", "Сидоров", "Александров", "Дмитриев" };
        private string[] otchestva = { "Иванович", "Петрович", "Сергеевич", "Александрович", "Дмитриевич" };
        private Random rnd = new Random();

        public string GenerateName()
        {
            return GetRandomElement(names);
        }

        public string GenerateSurname()
        {
            return GetRandomElement(surnames);
        }

        public string GeneratePatronymic()
        {
            return GetRandomElement(otchestva);
        }

        private string GetRandomElement(string[] array)
        {
            return array[rnd.Next(array.Length)];
        }
    }
}

