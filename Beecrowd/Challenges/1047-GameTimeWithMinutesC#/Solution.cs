namespace Beecrowd.Beecrowd.Challenges._1047_GameTimeWithMinutesC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int startHour = int.Parse(input[0]);
            int startMinute = int.Parse(input[1]);
            int endHour = int.Parse(input[2]);
            int endMinute = int.Parse(input[3]);
            int startTotalMinutes = startHour * 60 + startMinute;
            int endTotalMinutes = endHour * 60 + endMinute;

            if (endTotalMinutes <= startTotalMinutes)
            {
                endTotalMinutes += 24 * 60; 
            }
            int durationMinutes = endTotalMinutes - startTotalMinutes;
            int durationHours = durationMinutes / 60;
            durationMinutes %= 60;

            Console.WriteLine($"O JOGO DUROU {durationHours} HORA(S) E {durationMinutes} MINUTO(S)");
        }
    }
}
