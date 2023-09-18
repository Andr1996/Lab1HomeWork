using System;

namespace lab1ex4
{
    class Program
    {
        //Scrieti un program care va afisa semnul unui numar citit de la tastatura.
        //   • Daca numarul este pozitiv, va afisa “+”
        //   • Daca numarul este negativ, va afisa “-”
        //   • Daca numarul este 0, va afisa “0”
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Numarul introdus este pozitiv(+)");
            }
            else if (number < 0)
            {
                Console.WriteLine("Numarul introdus este negativ(-)");
            }
            else 
            {
                Console.WriteLine("Numarul introdus este 0");
            }

        }
    }
}
