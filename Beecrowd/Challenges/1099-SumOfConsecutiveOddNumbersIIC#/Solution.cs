namespace Beecrowd.Beecrowd.Challenges._1099_SumOfConsecutiveOddNumbersIIC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int t = 0; t < N; t++)
            {
                string[] values = Console.ReadLine().Split(' ');
                int X = int.Parse(values[0]);
                int Y = int.Parse(values[1]);

                int min = Math.Min(X, Y);
                int max = Math.Max(X, Y);

                int sum = 0;

                for (int i = min + 1; i < max; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}
