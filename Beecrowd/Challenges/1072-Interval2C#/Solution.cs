namespace Beecrowd.Beecrowd.Challenges._1072_Interval2C_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int inCount = 0;
            int outCount = 0;

            for (int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    inCount++;
                }
                else
                {
                    outCount++;
                }
            }

            Console.WriteLine($"{inCount} in");
            Console.WriteLine($"{outCount} out");
        }
    }
}
