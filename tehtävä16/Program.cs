/* 16 Lue konsolista kaksi numeroa. Jos jompikumpi numeroista on 30, tai numeroiden summa on 30, palauta konsoliin true, muuten false */


using System.Diagnostics;

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa ohjelmaan");

            // Запрос двух чисел у пользователя
            //Kysytään kahta numeroa käyttäjältä
            Console.WriteLine("Syötä ensimmäinen numero: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Syötä toinen numero: ");
            int num2 = Int32.Parse(Console.ReadLine());
            //Jos jompikumpi numeroista on 30,
            //tai numeroiden summa on 30,
            // palauta konsoliin true, muuten false.

            // Проверка условий
            // Ehtojen tarkistus
            if (num1 == 30 || num2 == 30 || (num1 + num2 == 30))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}