using System;

namespace lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul:");
            int number = int.Parse(Console.ReadLine());
            
            if (number%2 == 0)
            {
                Console.WriteLine("Numarul este par");
            }
            else
            {
                Console.WriteLine("Numarul este impar");
            }
        }
    }
}
