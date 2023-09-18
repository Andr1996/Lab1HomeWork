using System;

namespace lab1ex3
{
    class Program
    {
        //Ex 3. Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura.

        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul: ");
            ulong number = ulong.Parse(Console.ReadLine());

            ulong lastDigit = number % 10;

            Console.WriteLine("Ultima cifra a sirului este: " + lastDigit);

        }
    }
}
