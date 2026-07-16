namespace Beecrowd.Beecrowd.Challenges._1117_ScoreValidationC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            double nota1 = -1;
            double nota2 = -1;

            while (true)
            {
                double input = double.Parse(Console.ReadLine());

                if (input >= 0 && input <= 10)
                {
                    nota1 = input;
                    break;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            while (true)
            {
                double input = double.Parse(Console.ReadLine());
                
                if (input >= 0 && input <= 10)
                {
                    nota2 = input;
                    break;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            double media = (nota1 + nota2) / 2;
            Console.WriteLine($"media = {media:F2}");
        }
    }
}
