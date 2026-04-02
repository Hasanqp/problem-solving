namespace Beecrowd.Beecrowd.Challenges._1094_ExperimentsC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int total = 0;
            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            for (int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                int amount = int.Parse(values[0]);
                char type = char.Parse(values[1]);

                total += amount;

                if (type == 'C')
                {
                    coelhos += amount;
                }
                else if (type == 'R')
                {
                    ratos += amount;
                }
                else if (type == 'S')
                {
                    sapos += amount;
                }
            }

            double percentC = (double)coelhos / total * 100;
            double percentR = (double)ratos / total * 100;
            double percentS = (double)sapos / total * 100;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {percentC:F2} %");
            Console.WriteLine($"Percentual de ratos: {percentR:F2} %");
            Console.WriteLine($"Percentual de sapos: {percentS:F2} %");
        }
    }
}
