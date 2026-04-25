namespace Beecrowd.Beecrowd.Challenges._1115_QuadrantC_
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

                if (X == 0 || Y == 0)
                    break;

                if (X > 0 && Y > 0)
                    Console.WriteLine("primeiro");
                else if (X < 0 && Y > 0)
                    Console.WriteLine("segundo");
                else if (X < 0 && Y < 0)
                    Console.WriteLine("terceiro");
                else
                    Console.WriteLine("quarto");
            }
        }
    }
}
