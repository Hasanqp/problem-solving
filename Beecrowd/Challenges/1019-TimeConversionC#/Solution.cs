namespace Beecrowd.Challenges._1019_TimeConversionC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int totalSeconds = Convert.ToInt32(Console.ReadLine());
            int hours = totalSeconds / 3600;

            int remainingSeconds = totalSeconds % 3600;

            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
