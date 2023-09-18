using System;

namespace lab1ex2
{
    class Program
    {
        //Ex 2. Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura.

        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti numerele:");
            Console.Write("a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c:");
            int c = int.Parse(Console.ReadLine());

            int suma = a + b + c;
            decimal mediaAritmetica = (decimal)suma/3;
          
            Console.WriteLine("Media aritmetica este: " + mediaAritmetica);
        }
    }
     
}
