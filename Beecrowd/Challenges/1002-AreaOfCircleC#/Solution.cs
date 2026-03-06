namespace Beecrowd.Beecrowd.Challenges._1002_AreaOfCircleC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());
            double A = 3.14159 * (R * R);
            Console.WriteLine("A={0:0.0000}", A);
        }
    }
}
