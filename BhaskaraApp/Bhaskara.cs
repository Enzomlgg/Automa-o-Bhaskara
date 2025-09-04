using System;

namespace BhaskaraApp
{
    public class Bhaskara
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Bhaskara(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        private double CalcularDelta()
        {
            return B * B - 4 * A * C; // Correção aqui
        }

        public bool TemRaizesReais()
        {
            double delta = CalcularDelta();
            return delta >= 0; // Correção aqui
        }

        public (double?, double?) CalcularRaizes()
        {
            if (!TemRaizesReais())
            {
                return (null, null);
            }

            double delta = CalcularDelta();
            double raizDelta = Math.Sqrt(delta);

            double x1 = (-B + raizDelta) / (2 * A); // Correção aqui
            double x2 = (-B - raizDelta) / (2 * A); // Correção aqui

            return (x1, x2);
        }
    }
}