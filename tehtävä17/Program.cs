/* 17 Tarkasta alkaako syötteen ensimmäinen kirjain isolla kirjaimella. Jos ei, korjaa se alkavaksi isolla kirjaimella ja tulosta se konsoliin. */
/*Проверьте, начинается ли первая буква введенной строки с заглавной. Если нет, исправьте её на заглавную и выведите на консоль.*/

using System.Diagnostics;

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa ohjelmaan");

            // Запрос ввода строки у пользователя
            // Kysytään käyttäjältä merkkijonon syöttö
            Console.WriteLine("Kirjoita jotain: ");
            string input = Console.ReadLine();

            // Проверка, начинается ли строка с заглавной буквы
            // Tarkistetaan, alkaako merkkijono isolla kirjaimella
            if (!string.IsNullOrEmpty(input) && Char.IsLower(input[0]))
            {
                Console.WriteLine("Ensimmäinen kirjain ei ollut isolla. Muutetaan se isoksi");
                // Коррекция первого символа на заглавную букву
                // Korjataan ensimmäinen kirjain isoksi kirjaimeksi
                input = Char.ToUpper(input[0]) + input.Substring(1);
            }

            // Вывод исправленной строки
            // Tulostetaan korjattu merkkijono
            Console.WriteLine(input);

        }
    }
}