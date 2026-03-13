namespace Beecrowd.Beecrowd.Challenges._1065_EvenBetweenFiveNumbersC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"{count} valores pares");
        }
    }
}
