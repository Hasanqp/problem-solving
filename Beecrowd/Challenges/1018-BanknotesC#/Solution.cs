namespace Beecrowd.Challenges._1018_Banknotes_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine(value);

            int[] banknotes = { 100, 50, 20, 10, 5, 2, 1 };
            int currentValue = value;

            for (int i = 0; i < banknotes.Length; i++)
            {
                int quantity = currentValue / banknotes[i];
                currentValue %= banknotes[i];
                Console.WriteLine($"{quantity} nota(s) de R$ {banknotes[i]},00");
            }
        }
    }
}
