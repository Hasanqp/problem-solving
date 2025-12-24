namespace Beecrowd.Challenges._1014_ConsumptionC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            double Y = Convert.ToDouble(Console.ReadLine());

            double average = X / Y;
            Console.WriteLine(average.ToString("F3") + " km/l");
        }
    }
}
