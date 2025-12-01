namespace Beecrowd.Challenges._1011_SphereC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());

            double formula = (4.0 / 3.0) * 3.14159 * r * r * r;
            Console.WriteLine("VOLUME = " + formula.ToString("F3"));
        }
    }
}
