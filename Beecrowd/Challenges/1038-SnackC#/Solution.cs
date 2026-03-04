namespace Beecrowd.Beecrowd.Challenges._1038_SnackC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int X = int.Parse(values[0]);// Code
            int Y = int.Parse(values[1]);// Quantity

            double price = 0;

            switch (X)
            {
                case 1:
                    price = 4.00;
                    break;
                case 2:
                    price = 4.50;
                    break;
                case 3:
                    price = 5.00;
                    break;
                case 4:
                    price = 2.00;
                    break;
                case 5:
                    price = 1.50;
                    break;
            }
            double total = price * Y;

            Console.WriteLine($"Total: R$ {total:F2}");
        }
    }
}
