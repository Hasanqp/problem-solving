using System.Globalization;

namespace Beecrowd.Beecrowd.Challenges._1042_SimpleSortC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int a = int.Parse(input[0], CultureInfo.InvariantCulture);
            int b = int.Parse(input[1], CultureInfo.InvariantCulture);
            int c = int.Parse(input[2], CultureInfo.InvariantCulture);

            int[] original = { a, b, c };

            int[] sorted = { a, b, c };
            Array.Sort(sorted);

            foreach (var num in sorted)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            foreach (var num in original)
            {
                Console.WriteLine(num);
            }
        }
    }
}
