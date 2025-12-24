namespace Beecrowd.Challenges._1020_AgeInDaysC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int totalDays = Convert.ToInt32(Console.ReadLine());

            int years = totalDays / 365;
            int remainingDays = totalDays % 365;

            int months = remainingDays / 30;
            int days = remainingDays % 30;

            Console.WriteLine($"{years} ano(s)");
            Console.WriteLine($"{months} mes(es)");
            Console.WriteLine($"{days} dia(s)");

        }
    }
}
