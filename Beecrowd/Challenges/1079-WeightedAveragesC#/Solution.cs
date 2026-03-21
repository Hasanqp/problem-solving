using System.Globalization;

namespace Beecrowd.Beecrowd.Challenges._1079_WeightedAveragesC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                double A = double.Parse(values[0], CultureInfo.InvariantCulture);
                double B = double.Parse(values[1], CultureInfo.InvariantCulture);
                double C = double.Parse(values[2], CultureInfo.InvariantCulture);

                double average = (A * 2 + B * 3 + C * 5) / 10.0;

                Console.WriteLine(average.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
