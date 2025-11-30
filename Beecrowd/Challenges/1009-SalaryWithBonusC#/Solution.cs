namespace Beecrowd.Challenges._1009_SalaryWithBonusC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine());
            double sales = double.Parse(Console.ReadLine());

            double total = salary + (sales * 0.15);
            Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
        }
    }
}
