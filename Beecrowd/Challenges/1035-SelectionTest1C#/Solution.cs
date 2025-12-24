namespace Beecrowd.Challenges._1022_SelectionTest1C_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');

            // Parse the values to integers
            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);
            int C = int.Parse(values[2]);
            int D = int.Parse(values[3]);

            // Check all conditions using logical AND (&&)
            if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && (A % 2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
