namespace Beecrowd.Challenges._1010_SimpleCalculateC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            int code1 = int.Parse(line1[0]);
            int Units1 = int.Parse(line1[1]);
            double price1 = double.Parse(line1[2]);

            string[] line2 = Console.ReadLine().Split(' ');
            int code2 = int.Parse(line2[0]);
            int Units2 = int.Parse(line2[1]);
            double price2 = double.Parse(line2[2]);

            double total = Units1 * price1 + Units2 * price2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
    }
}
