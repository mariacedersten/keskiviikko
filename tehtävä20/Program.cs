/*20 Lue numero syötteestä. Palauta true jos luku on 1-10 välillä tai luku on kolmella jaollinen tai luku on suurempi kuin 100 tai luku on negatiivinen.
Прочитайте число из ввода. Верните true, если число находится в пределах от 1 до 10, или оно делится на 3, или оно больше 100, или оно отрицательное.*/

using System.Diagnostics;

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa ohjelmaan");

            // Запрос числа у пользователя
            // Pyydetään numero käyttäjältä
            Console.WriteLine("Syötä numero: ");
            int number = Int32.Parse(Console.ReadLine());

            /* 
            /vaihtoehto1
            // Проверка условий
            // Tarkastetaan ehdot
            bool result = (number >= 1 && number <= 10) || (number % 3 == 0) || (number > 100) || (number < 0);

            // Вывод результата
            //Tulostetaan tulos
            Console.WriteLine(result);
            */

            //Vaihtoehto 2
            if ((number >= 1 && number <= 10) || (number % 3 == 0) || (number > 100) || (number < 0))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
