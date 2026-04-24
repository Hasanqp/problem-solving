namespace Beecrowd.Beecrowd.Challenges._1114_FixedPasswordC_
{
    public class Solution
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int password = int.Parse(Console.ReadLine());

                if (password == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}
