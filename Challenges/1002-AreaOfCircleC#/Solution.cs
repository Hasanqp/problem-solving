namespace Beecrowd.Challenges._1002_AreaOfCircleC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            double R = Convert.ToDouble(Console.ReadLine());

            double A = 3.14159 * R * R;
            Console.WriteLine("A="+A.ToString("F4"));
        }
    }
}
