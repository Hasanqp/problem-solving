
namespace Beecrowd.Beecrowd.Challenges._1044_MultiplesC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');

            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);
            
            if(A % B == 0 ||B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
