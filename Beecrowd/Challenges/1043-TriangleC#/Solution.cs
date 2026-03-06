using System.Globalization;

namespace Beecrowd.Beecrowd.Challenges._1043_TriangleC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');

            float A = float.Parse(values[0], CultureInfo.InvariantCulture);
            float B = float.Parse(values[1], CultureInfo.InvariantCulture);
            float C = float.Parse(values[2], CultureInfo.InvariantCulture);
            
            if(A + B > C && A + C > B && B + C > A)
            {
                Console.WriteLine("Perimetro = " + (A + B + C).ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Area = " + (((A + B) * C) / 2.0).ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
