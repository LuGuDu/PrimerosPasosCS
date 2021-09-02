using System;

namespace PrimerosPasosCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");

            calculateRadius();
        }

        private static void calculateRadius()
        {
            Console.WriteLine("Welcome to a circunference area calculator. Insert the radius:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Methods methods = new Methods();

            double area = methods.calcularAreaCircunferencia(radius);
            Console.WriteLine("The area of the circunference is: {0}", area);
        }
    }
}
