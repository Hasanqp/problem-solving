namespace Beecrowd.Beecrowd.Challenges._1113_AscendingAndDescendingC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] values = Console.ReadLine().Split(' ');
                int X = int.Parse(values[0]);
                int Y = int.Parse(values[1]);

                if (X == Y)
                    break;

                if (X < Y)
                    Console.WriteLine("Crescente");
                else
                    Console.WriteLine("Decrescente");
            }
        }
    }
}
