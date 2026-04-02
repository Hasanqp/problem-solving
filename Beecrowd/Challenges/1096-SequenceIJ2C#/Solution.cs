namespace Beecrowd.Beecrowd.Challenges._1096_SequenceIJ2C_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            for (int I = 1; I <= 9; I += 2)
            {
                for (int J = 7; J >= 5; J--)
                {
                    Console.WriteLine($"I={I} J={J}");
                }
            }
        }
    }
}
