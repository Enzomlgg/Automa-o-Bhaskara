using BhaskaraApp;

internal class Program
{
    private static void Main(string[] args)
    {
        static void TestarBhaskara(double a, double b, double c)
        {
            var bhaskara = new Bhaskara(a, b, c);
            Console.WriteLine($"\nEquação: {a}x² + {b}x + {c} = 0");

            if (bhaskara.TemRaizesReais())
            {
                var (raiz1, raiz2) = bhaskara.CalcularRaizes();
                Console.WriteLine($"Raiz 1: {raiz1}");
                Console.WriteLine($"Raiz 2: {raiz2}");
            }
            else
            {
                Console.WriteLine("A equação não possui raízes reais.");
            }
        }

        TestarBhaskara(1, -3, 2);     // Duas raízes reais
        TestarBhaskara(1, -2, 1);     // Raiz dupla
        TestarBhaskara(2, 3, 5);      // Sem raízes reais
        TestarBhaskara(-1, 2, -1);    // Raiz dupla com A negativo
        TestarBhaskara(1, -7.5, 10);  // Raízes decimais
    }
}