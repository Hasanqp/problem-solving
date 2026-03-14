namespace Beecrowd.Beecrowd.Challenges._1070_SixOddNumbersC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            if (X % 2 == 0)
            {
                X++;
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(X);
                X += 2;
            }
        }
    }
}
