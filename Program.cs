using System;
using System.Globalization;
using Triangulos;
namespace Course
{
    class Triangulos
    {
        static void Main(string[] args)
        {
            Medida x, y;
            x = new Medida();
            y = new Medida();
            Console.WriteLine("Entre com as medidas do triângulo X");
            Console.Write("Valor 1: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor 2: ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor 3: ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triângulo Y");
            Console.Write("Valor 1: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor 1: ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor 1: ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area();
            double areaY = y.Area();


            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("A maior área é: X");
            }
            else
            {
                Console.WriteLine("A maior área é: Y");
            }

            Console.ReadLine();
        }

    }
}