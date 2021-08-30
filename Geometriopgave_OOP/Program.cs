using System;

namespace Geometriopgave_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Side_A kan herfra manipuleres.

            Square square1 = new Square();
            square1.Side_A = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(square1.Perimeter());
            Console.WriteLine();
            Console.WriteLine(square1.Area());

        }
    }
}
