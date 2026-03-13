namespace Beecrowd.Beecrowd.Challenges._1061_EventTimeC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            //Read start day
            string[] startDayInput = Console.ReadLine().Split(' ');
            int startDay = int.Parse(startDayInput[1]);

            // Read start time
            string[] startTime = Console.ReadLine().Split(':');
            int startHour = int.Parse(startTime[0]);
            int startMinute = int.Parse(startTime[1]);
            int startSecond = int.Parse(startTime[2]);

            // Read end day
            string[] endDayInput = Console.ReadLine().Split(' ');
            int endDay = int.Parse(endDayInput[1]);

            // Read end time
            string[] endTime = Console.ReadLine().Split(':');
            int endHour = int.Parse(endTime[0]);
            int endMinute = int.Parse(endTime[1]);
            int endSecond = int.Parse(endTime[2]);

            // Convert to seconds
            int startTotal =
                    startDay * 86400 +
                    startHour * 3600 +
                    startMinute * 60 +
                    startSecond;
            int endTotal = endDay * 86400 +
                endHour * 3600 +
                endMinute * 60 +
                endSecond;

            // Calculate duration
            int duration = endTotal - startTotal;

            // Convert back
            int days = duration / 86400;
            duration %= 86400;
            int hours = duration / 3600;
            duration %= 3600;
            int minutes = duration / 60;
            int seconds = duration % 60;

            // Print results
            Console.WriteLine(days + " dia(s)");
            Console.WriteLine(hours + " hora(s)");
            Console.WriteLine(minutes + " minuto(s)");
            Console.WriteLine(seconds + " segundo(s)");
        }
    }
}
