namespace Beecrowd.Beecrowd.Challenges._1073_EvenSquareC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    int square = i * i;
                    Console.WriteLine($"{i}^2 = {square}");
                }
            }
        }
    }
}
