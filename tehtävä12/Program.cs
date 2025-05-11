// 12. Tulosta konsoliin tämän päivän päivämäärä hakemalla informaatio koneelta.

namespace keskiviikko
{
    class Program
    {
        static void Main()
        {
            // Haetaan tämän päivän päivämäärä tietokoneelta
            DateTime today = DateTime.Now;

            // Tulostetaan päivämäärä konsoliin
            Console.WriteLine("Tänään on: " + today.ToString("yyyy-MM-dd"));
        }
    }
}