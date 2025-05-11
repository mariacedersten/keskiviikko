/* 11. Antaa käyttäjän kirjoittaa konsoliin sukupuolensa. Jos kirjoittaa ”mies” tulostaa konsoliin ”Hyvä Herra”, jos ”nainen” kirjoittaa ”Hyvä Rouva”. Jos jotain muuta, kirjoittaa konsoliin ”Muuta”. */

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pyydetään käyttäjältä sukupuolta
            Console.WriteLine("Syötä sukupuolesi (mies/nainen):");

            // Luetaan käyttäjän syöte
            string sukupuoli = Console.ReadLine().ToLower(); // Muutetaan syöte pieniksi kirjaimiksi vertausta varten

            // Tarkistetaan, mikä sukupuoli on annettu ja tulostetaan vastaava viesti
            if (sukupuoli == "mies")
            {
                Console.WriteLine("Hyvä Herra");
            }
            else if (sukupuoli == "nainen")
            {
                Console.WriteLine("Hyvä Rouva");
            }
            else
            {
                Console.WriteLine("Muuta");
            }
        }
    }
}
