// 22. Pyydä käyttäjältä tekstisyöte. Tulosta syötteestä ensimmäiset 10 kirjainta
// Попросите пользователя ввести текстовый ввод. Выведите первые 10 символов из введённого текста.

using System;

namespace keskiviikko
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Tervetuloa ohjelmaan.");
            Console.WriteLine("Anna jokin teksti, niin kirjoitetaan siitä 10 ensimmäistä kirjaintä: ");
            string syote = Console.ReadLine();

            if (syote.Length >= 10)
            {
                // Tulostetaan ensimmäiset 10 merkkiä
                Console.WriteLine("Ensimmäiset 10 kirjainta olivat: " + syote.Substring(0, 10));
            }
            else
            {
                // Jos syöte on lyhyempi kuin 10 merkkiä, tulostetaan koko syöte
                Console.WriteLine("Kirjoitit alle 10 merkkiä. Tässä koko syöte: " + syote);
            }
        }
    }
}