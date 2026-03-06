using System.Globalization;

namespace Beecrowd.Beecrowd.Challenges._1045_TriangleTypesC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');

            double A = double.Parse(values[0], CultureInfo.InvariantCulture);
            double B = double.Parse(values[1], CultureInfo.InvariantCulture);
            double C = double.Parse(values[2], CultureInfo.InvariantCulture);

            double[] sides = { A, B, C };

            Array.Sort(sides);
            Array.Reverse(sides);

            A = sides[0];
            B = sides[1];
            C = sides[2];

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (A * A == B * B + C * C)
                    Console.WriteLine("TRIANGULO RETANGULO");

                if (A * A > B * B + C * C)
                    Console.WriteLine("TRIANGULO OBTUSANGULO");

                if (A * A < B * B + C * C)
                    Console.WriteLine("TRIANGULO ACUTANGULO");

                if (A == B && B == C)
                    Console.WriteLine("TRIANGULO EQUILATERO");

                else if (A == B || A == C || B == C)
                    Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
