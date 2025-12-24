namespace Beecrowd.Challenges._1013_TheGreatestC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split();
            int a = int.Parse(values[0]);
            int b = int.Parse(values[1]);
            int c = int.Parse(values[2]);

            int maiorAB = (a + b + Math.Abs(a - b)) / 2;
            int maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
