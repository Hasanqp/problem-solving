namespace Beecrowd.Beecrowd.Challenges._1048_Salary_IncreaseC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            double percentage = 0;

            if (salary >= 0 && salary <= 400.00)
                percentage = 15;
            else if (salary > 400.00 && salary <= 800.00)
                percentage = 12;
            else if (salary > 800.00 && salary <= 1200.00)
                percentage = 10;
            else if (salary > 1200.00 && salary <= 2000.00)
                percentage = 7;
            else if (salary > 2000.00)
                percentage = 4;

            double increase = salary * percentage / 100;
            double newSalary = salary + increase;

            Console.WriteLine($"Novo salario: {newSalary:F2}");
            Console.WriteLine($"Reajuste ganho: {increase:F2}");
            Console.WriteLine($"Em percentual: {percentage} %");
        }
    }
}
