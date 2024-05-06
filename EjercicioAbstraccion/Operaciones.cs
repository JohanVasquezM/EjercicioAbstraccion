using EjercicioAbstraccion;

namespace EjercicioAbstraccion
{
    public abstract class Operaciones
    {
        public abstract double Suma(double a, double b);
        public abstract double Resta(double a, double b);
        public abstract double Multiplicacion(double a, double b);
        public abstract double Division(double a, double b);

        public abstract void Imprimir();
    }
}
