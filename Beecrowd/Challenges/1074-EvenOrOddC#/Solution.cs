namespace Beecrowd.Beecrowd.Challenges._1074_EvenOrOddC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X == 0)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    string result = "";

                    if (X % 2 == 0)
                    {
                        result += "EVEN ";
                    }
                    else
                    {
                        result += "ODD ";
                    }

                    if (X > 0)
                    {
                        result += "POSITIVE";
                    }
                    else
                    {
                        result += "NEGATIVE";
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}
