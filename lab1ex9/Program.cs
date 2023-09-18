using System;

namespace lab1ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul:");

            int number = int.Parse(Console.ReadLine());

            switch (number)
            {

                case 1:
                    Console.WriteLine("Numarul introdus este unu");
                    break;
                case 2:
                    Console.WriteLine("Numarul introdus este doi");
                    break;
                case 3:
                    Console.WriteLine("Numarul introdus este trei");
                    break;
                case 5:
                    Console.WriteLine("Numarul introdus este cinci");
                    break;
                case 8:
                    Console.WriteLine("Numarul introdus este opt");
                    break;
                default:
                    Console.WriteLine("Numarul introdus este neidentificat");
                    break;
            }
        }
        }
        }
        
     
    

