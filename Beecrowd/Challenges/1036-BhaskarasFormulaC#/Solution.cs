namespace Beecrowd.Challenges._1036_BhaskarasFormulaC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            // Read input values
            string[] values = Console.ReadLine().Split(' ');
            double A = double.Parse(values[0]);
            double B = double.Parse(values[1]);
            double C = double.Parse(values[2]);

            // Calculate discriminant
            double delta = Math.Pow(B, 2) - 4 * A * C;

            // Check if impossible to calculate
            if (A == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                // Calculate roots using Bhaskara's formula
                double R1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double R2 = (-B - Math.Sqrt(delta)) / (2 * A);

                // Print results with 5 decimal places
                Console.WriteLine($"R1 = {R1:F5}");
                Console.WriteLine($"R2 = {R2:F5}");
            }
        }
    }
}
