using System;

namespace Lab1
{
    class Program
    {
//       Ex 1. Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui paralelipiped dreptunghic, va afisa volumul lui.

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti latura 1:");
            int latura1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latura 2:");
            int latura2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latura 3:");
            int latura3 = int.Parse(Console.ReadLine());

            int volParalelipiped = latura1 * latura2 * latura3;

            Console.WriteLine("Volumul paralelipipedului dreptunghic este:" + volParalelipiped);
        }
    }
}
