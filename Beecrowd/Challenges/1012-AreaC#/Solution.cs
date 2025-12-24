namespace Beecrowd.Challenges._1012_AreaC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            double A = double.Parse(values[0]);
            double B = double.Parse(values[1]);
            double C = double.Parse(values[2]);

            double TRIANGULO = (A * C) / 2;
            double CIRCULO = 3.14159 * C * C;
            double TRAPEZIO = (A + B) * (C / 2);
            double QUADRADO = B * B;
            double RETANGULO = A * B;

            Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3"));
            Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3"));
            Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3"));
            Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3"));
        }
    }
}
