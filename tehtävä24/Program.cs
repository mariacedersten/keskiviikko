// 24. Tulosta konsoliin seuraavanlainen numeropyramidia.1 b.12 c.123 d.1234
// Выведите в консоль следующую числовую пирамиду: 1 12 123 1234

using System;

namespace keskiviikko
{
    class Program
    {


        static void Main()
        {
            Console.WriteLine("Tervetuloa ohjelmaan.");

            // Число строк в пирамиде
            // Pyramidin rivien määrä
            int numero = 4;

            // Внешний цикл для каждой строки
            // Ulompi silmukka joka riville
            for (int i = 1; i <= numero; i++)
            {
                // Инициализация пустой строки
                // Alustetaan tyhjä merkkijono
                string tuloste = " ";
                // Внутренний цикл для вывода чисел в каждой строке
                // Sisempi silmukka tulostaa numerot joka riville
                for (int j = 1; j <= i; j++)
                {

                    // Добавление пробела и значения j (в данном случае 1)
                    // Lisätään välilyönti ja muuttujan j arvo (tässä tapauksessa 1)
                    //это способ конкатенации строки с добавлением числа (или другого значения), разделённого пробелом.
                    //on tapa lisätä merkkijonoa, johon liitetään numero (tai muu arvo) välilyönnillä erotettuna.
                    tuloste += " " + j;
                }

                // Переход на новую строку после каждой строки пирамиды
                // Siirrytään uuteen riviin joka rivin jälkeen
                Console.WriteLine(tuloste);
            }
        }
    }
}
