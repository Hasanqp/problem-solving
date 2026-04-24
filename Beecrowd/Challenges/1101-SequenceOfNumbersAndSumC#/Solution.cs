namespace Beecrowd.Beecrowd.Challenges._1101_SequenceOfNumbersAndSumC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] values = Console.ReadLine().Split(' ');
                int M = int.Parse(values[0]);
                int N = int.Parse(values[1]);

                if (M <= 0 || N <= 0)
                    break;

                int min = Math.Min(M, N);
                int max = Math.Max(M, N);

                int sum = 0;

                for (int i = min; i <= max; i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }

                Console.WriteLine($"Sum={sum}");
            }
        }
    }
}
