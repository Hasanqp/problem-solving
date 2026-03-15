namespace Beecrowd.Beecrowd.Challenges._1071_SumOfConsecutiveOddNumbersIC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

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
