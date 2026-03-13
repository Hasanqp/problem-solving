using System.Globalization;

namespace Beecrowd.Beecrowd.Challenges._1064_PositivesAndAverageC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int count = 0;
            double sum = 0;

            for (int i = 0; i < 6; i++)
            {
                double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (number > 0)
                {
                    count++;
                    sum += number;
                }
            }

            double average = sum / count;

            Console.WriteLine($"{count} valores positivos");
            Console.WriteLine(average.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
