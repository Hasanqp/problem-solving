namespace Beecrowd.Beecrowd.Challenges._1052_MonthC_
{
    class Solution
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());

            string[] months =
            {
            "January","February","March","April","May","June",
            "July","August","September","October","November","December"
            };

            Console.WriteLine(months[month - 1]);
        }
    }
}
