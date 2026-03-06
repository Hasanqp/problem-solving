namespace Beecrowd.Beecrowd.Challenges._1046_GameTimeC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');

            int startTime = int.Parse(values[0]);
            int finishTime = int.Parse(values[1]);

            int duration;

            if (startTime < finishTime)
            {
                duration = finishTime - startTime;
            }
            else if (startTime > finishTime)
            {
                duration = (24 - startTime) + finishTime;
            }
            else
            {
                duration = 24;
            }

            Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
        }
    }
}
