namespace Beecrowd.Beecrowd.Challenges._1007_DifferenceC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int D = Convert.ToInt32(Console.ReadLine());

            int DIFRENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + DIFRENCA);
        }
    }
}
