using System.Globalization;

namespace Beecrowd.Beecrowd.Challenges._1041_CoordinatesOfAPointC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');

            double x = double.Parse(values[0], CultureInfo.InvariantCulture);
            double y = double.Parse(values[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
                Console.WriteLine("Origem");
            else if (x == 0)
                Console.WriteLine("Eixo Y");
            else if (y == 0)
                Console.WriteLine("Eixo X");
            else if (x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if (x < 0 && y > 0)
                Console.WriteLine("Q2");
            else if (x < 0 && y < 0)
                Console.WriteLine("Q3");
            else
                Console.WriteLine("Q4");
        }
    }
}
