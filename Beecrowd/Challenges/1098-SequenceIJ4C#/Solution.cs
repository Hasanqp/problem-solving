namespace Beecrowd.Beecrowd.Challenges._1098_SequenceIJ4C_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            for (double i = 0; i <= 2.0001; i += 0.2)
            {
                double I = Math.Round(i, 1);

                for (int j = 1; j <= 3; j++)
                {
                    double J = Math.Round(j + I, 1);

                    if (I % 1 == 0)
                    {
                        Console.WriteLine($"I={(int)I} J={(int)J}");
                    }
                    else
                    {
                        Console.WriteLine($"I={I:F1} J={J:F1}");
                    }
                }
            }
        }
    }
}
