using System.Globalization;

namespace Beecrowd.Beecrowd.Challenges._1051_TaxesC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double tax = 0.0;

            if (salary <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salary <= 3000.00)
            {
                tax = (salary - 2000.00) * 0.08;
                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salary <= 4500.00)
            {
                tax = 1000 * 0.08;
                tax += (salary - 3000.00) * 0.18;

                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                tax = 1000 * 0.08;
                tax += 1500 * 0.18;
                tax += (salary - 4500.00) * 0.28;

                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
