namespace Beecrowd.Beecrowd.Challenges._1080_HighestAndPositionC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int max = 0;
            int position = 0;

            for (int i = 1; i <= 100; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                    position = i;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(position);
        }
    }
}
