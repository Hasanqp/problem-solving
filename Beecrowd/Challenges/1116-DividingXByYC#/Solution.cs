namespace Beecrowd.Beecrowd.Challenges._1116_DividingXByYC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                int X = int.Parse(values[0]);
                int Y = int.Parse(values[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double result = (double)X / Y;
                    Console.WriteLine(result.ToString("F1"));
                }
            }
        }
    }
}
