/*19 Pyydä kaksi lukua ja tarkasta kumpi on lähempänä lukua 1000. Tulosta lähempi. Mitä jos luvut ovat sama lukema?*/

using System.Diagnostics;

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa ohjelmaan");

            // Запрос двух чисел у пользователя
            // Kysytään kahta numeroa käyttäjältä
            Console.WriteLine("Syötä ensimmäinen numero: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Syötä toinen numero: ");
            int num2 = Int32.Parse(Console.ReadLine());

            // Рассчитываем разницу от 1000 для каждого числа
            // Lasketaan ero 1000
            int result1 = Math.Abs(num1 - 1000);
            int result2 = Math.Abs(num2 - 1000);

            // Сравниваем, какое число ближе к 1000
            // Verrataan, kumpi luku on lähempänä 1000
            if (result1 < result2)
            {
                Console.WriteLine("Lähin luku 1000: " + num1);
            }
            else if (result2 < result1)
            {
                Console.WriteLine("Lähin luku 1000: " + num2);
            }
            else
            {
                Console.WriteLine("Molemmat numerot ovat yhtä lähellä 1000.");
            }
        }
    }
}
