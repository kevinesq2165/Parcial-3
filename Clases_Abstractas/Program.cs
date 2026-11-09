using System;

namespace Clases_Abstractas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura[] figuras = new Figura[3];

            figuras[0] = new Rectangulo(4, 6);
            figuras[1] = new Cuadrado(5);
            figuras[2] = new Triangulo(3, 4, 5, 4);

            foreach (Figura figura in figuras)
            {
                Console.WriteLine( figura.GetType().Name);
                Console.WriteLine("Area: " + figura.CalcularArea());
                Console.WriteLine("Perimetro: " + figura.CalcularPerimetro());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}