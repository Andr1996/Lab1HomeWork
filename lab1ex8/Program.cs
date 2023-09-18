using System;

namespace lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul:");

            decimal numar = decimal.Parse(Console.ReadLine());

            int intreg = (int)numar;

            Console.WriteLine("Numarul intreg este:" + intreg);
        }
    }
}
