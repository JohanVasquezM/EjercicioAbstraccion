using System;

namespace EjercicioAbstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Calculadora calculadora = new Calculadora(num1, num2);
            calculadora.Imprimir();
        }
    }
}