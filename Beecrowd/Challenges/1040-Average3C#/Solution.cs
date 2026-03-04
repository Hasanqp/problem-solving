using System.Globalization;

namespace Beecrowd.Beecrowd.Challenges._1040_Average3C_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            double n1 = double.Parse(s[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(s[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(s[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(s[3], CultureInfo.InvariantCulture);

            double media = (n1 * 2.0 + n2 * 3.0 + n3 * 4.0 + n4) / 10.0;
            media = Math.Round(media, 1, MidpointRounding.ToEven);

            Console.WriteLine("Media: " + media.ToString("0.0", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");

                double exam = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exam.ToString("0.0", CultureInfo.InvariantCulture));

                double finalMedia = (media + exam) / 2.0;
                finalMedia = Math.Round(finalMedia, 1, MidpointRounding.ToEven);

                Console.WriteLine(finalMedia >= 5.0 ? "Aluno aprovado." : "Aluno reprovado.");
                Console.WriteLine("Media final: " + finalMedia.ToString("0.0", CultureInfo.InvariantCulture));
            }
        }
    }
}
