using System;

namespace AppProvaLogicProg_Exerc_02
{
    class Program
    {
        public static double CalcularValorAreaCirculo(double raio) 
        {
            double area;
            double Pi = 3.14159;
            area = Pi * Math.Pow(raio, 2); 
            return area;
        }

        static void Main(string[] args)
        {
            double raio;
            double valorArea;
            Console.WriteLine("Entre com o valor do raio:");
            raio = double.Parse(Console.ReadLine());
            valorArea = CalcularValorAreaCirculo(raio);

            Console.WriteLine($"O valor da area do circulo é: {valorArea:00.0000}");
            Console.ReadLine();
        }
    }
}
