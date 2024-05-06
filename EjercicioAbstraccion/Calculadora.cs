using EjercicioAbstraccion;

namespace EjercicioAbstraccion
{
    public class Calculadora : Operaciones
    {
        private double numero1;
        private double numero2;

        public Calculadora(double num1, double num2)
        {
            numero1 = num1;
            numero2 = num2;
        }

        public override double Suma(double a, double b) => a + b;
        public override double Resta(double a, double b) => a - b;
        public override double Multiplicacion(double a, double b) => a * b;
        public override double Division(double a, double b) => b != 0 ? a / b : double.NaN;

        public override void Imprimir()
        {
            Console.WriteLine($"Suma: {Suma(numero1, numero2)}");
            Console.WriteLine($"Resta: {Resta(numero1, numero2)}");
            Console.WriteLine($"Multiplicación: {Multiplicacion(numero1, numero2)}");
            Console.WriteLine($"División: {Division(numero1, numero2)}");
        }
}
}
