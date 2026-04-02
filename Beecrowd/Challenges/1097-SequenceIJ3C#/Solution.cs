namespace Beecrowd.Beecrowd.Challenges._1097_SequenceIJ3C_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            for (int I = 1; I <= 9; I += 2)
            {
                int startJ = I + 6;

                for (int J = startJ; J >= startJ - 2; J--)
                {
                    Console.WriteLine($"I={I} J={J}");
                }
            }
        }
    }
}
