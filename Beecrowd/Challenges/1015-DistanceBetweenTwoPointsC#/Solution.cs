namespace Beecrowd.Challenges._1015_DistanceBetweenTwoPointsC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split();
            double x1 = double.Parse(line1[0]);
            double y1 = double.Parse(line1[1]);

            string[] line2 = Console.ReadLine().Split();
            double x2 = double.Parse(line2[0]);
            double y2 = double.Parse(line2[1]);

            double Distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(Distance.ToString("F4"));
        }
    }
}