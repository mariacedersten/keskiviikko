/*8 Pyydä kolme syötettä, numeroita, tarkasta mikä numero on suurin ja kirjoita se konsoliin.*/

using System.Diagnostics;

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa ohjelmaan");

            int num1, num2, num3;

            // Запрос трёх чисел у пользователя
            // Kysytään kolmea numeroa käyttäjältä
            Console.Write("Syötä ensimmäinen numero: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Syötä toinen numero: ");
            num2 = Int32.Parse(Console.ReadLine());

            Console.Write("Syötä kolmas numero: ");
            num3 = Int32.Parse(Console.ReadLine());

            int[] num = { num1, num2, num3 };
            Array.Sort(num);

            /*
            //Viimeinen numero taulukossa on suurin. (vaihtoehto1)
            Console.WriteLine(num[num.Length -1]);

            // Находим наибольшее число  (vaihtoehto2)
            // Etsitään suurin luku
            int suurin = Math.Max(num1, Math.Max(num2, num3));

            // Выводим наибольшее число
            // Tulostetaan suurin luku
            Console.WriteLine($"Suurin numero on: {suurin}");

            // Tulostetaan suurin luku  (vaihtoehto3)
            Console.WriteLine(num.Last());
                                           */

            // Tulostetaan suurin luku  (vaihtoehto4)
            Console.WriteLine(num.Max());
        }
    }
}
