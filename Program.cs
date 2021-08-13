using System;
using System.Globalization;


namespace ExercicioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os valores de um triangulo, sendo a, b e c
             * e em seguida mostrar o perimetro e a area deste triangulo 
             obs.: os valores devem ser informados pelo usuario.*/ 

            Console.WriteLine("Calculo da area e perimetro de um triangulo");

            double a, b, c;
            Console.Write("Entre com o valor de a: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o valor de b: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o valor de c: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double perimetro = a + b + c;
            double area = (a + b) * c / 2.0;

            
                Console.WriteLine($"Perimetro do tiangulo = {perimetro.ToString("F1", CultureInfo.InvariantCulture)}");
            
                Console.WriteLine($"Area do triangulo = {area.ToString("F1", CultureInfo.InvariantCulture)}");
            
            Console.ReadLine();
        }
    }
}
