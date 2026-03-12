namespace Beecrowd.Beecrowd.Challenges._1060_PositiveNumbersC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} valores positivos");
        }
    }
}
