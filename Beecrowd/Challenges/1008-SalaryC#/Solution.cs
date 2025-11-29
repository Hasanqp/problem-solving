namespace Beecrowd.Beecrowd.Challenges._1008_SalaryC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int workhours = Convert.ToInt32(Console.ReadLine());
            double amount = Convert.ToDouble(Console.ReadLine());

            double SALARY = amount * workhours;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2"));
        }
    }
}
