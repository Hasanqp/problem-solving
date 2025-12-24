namespace Beecrowd.Challenges._1021_BanknotesAndCoinsC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            // Read the input value as a double
            double valorDouble = double.Parse(Console.ReadLine());

            // Convert the value to cents (integer) to avoid floating-point precision issues
            // Adding 0.001 helps with rounding errors for some decimal values
            int valorTotal = (int)(valorDouble * 100 + 0.001);

            // Banknote values in cents (multiply by 100)
            int[] notas = { 10000, 5000, 2000, 1000, 500, 200 };
            // Coin values in cents (multiply by 100)
            int[] moedas = { 100, 50, 25, 10, 5, 1 };

            // Print banknotes section header
            Console.WriteLine("NOTAS:");

            // Process each banknote denomination
            foreach (int nota in notas)
            {
                // Calculate how many banknotes of this denomination
                int quantidade = valorTotal / nota;
                // Update the remaining value
                valorTotal %= nota;
                // Print result (convert back to reais by dividing by 100.0)
                Console.WriteLine($"{quantidade} nota(s) de R$ {(nota / 100.0):F2}");
            }

            // Print coins section header
            Console.WriteLine("MOEDAS:");

            // Process each coin denomination
            foreach (int moeda in moedas)
            {
                // Calculate how many coins of this denomination
                int quantidade = valorTotal / moeda;
                // Update the remaining value
                valorTotal %= moeda;
                // Print result (convert back to reais by dividing by 100.0)
                Console.WriteLine($"{quantidade} moeda(s) de R$ {(moeda / 100.0):F2}");
            }
        }
    }
}
