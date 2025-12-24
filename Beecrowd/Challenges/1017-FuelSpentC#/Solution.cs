namespace Beecrowd.Challenges._1016_FuelSpentC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int time = Convert.ToInt32(Console.ReadLine());
            int average = Convert.ToInt32(Console.ReadLine());

            double spentfuel = (time * average) / 12.0;
            Console.WriteLine(spentfuel.ToString("F3"));
        }
    }
}
