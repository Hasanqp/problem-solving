namespace Beecrowd.Beecrowd.Challenges._1066_EvenOddPositiveAndNegativeC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int even = 0;
            int odd = 0;
            int positive = 0;
            int negative = 0;

            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

                if (number > 0)
                {
                    positive++;
                }

                if (number < 0)
                {
                    negative++;
                }
            }

            Console.WriteLine($"{even} valor(es) par(es)");
            Console.WriteLine($"{odd} valor(es) impar(es)");
            Console.WriteLine($"{positive} valor(es) positivo(s)");
            Console.WriteLine($"{negative} valor(es) negativo(s)");
        }
    }
}
