/*7.Lue kaksi numeroa konsoleista. 
Jos numerot ovat samat, plussaa ne keskenään, 
jos ne ovat eri, kerro ne keskenään. 
Tulosta konsoliin tulos.*/

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pyydetään käyttäjältä kahta numeroa
            Console.WriteLine("Syötä ensimmäinen numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä toinen numero:");
            int numero2 = int.Parse(Console.ReadLine());

            int tulos;

            // Tarkistetaan, ovatko numerot samat vai eri
            if (numero1 == numero2)
            {
                Console.WriteLine("Annoit samat numerot. Plussataan ne yhteen:");
                // Jos numerot ovat samat, lasketaan niiden summa
                tulos = numero1 + numero2;
            }
            else
            {
                Console.WriteLine("Annoit eri numerot. Kerrotaan ne keskinään:");
                // Jos numerot ovat eri, lasketaan niiden tulo
                tulos = numero1 * numero2;
            }

            // Tulostetaan tulos konsoliin
            Console.WriteLine("Tulos: " + tulos);
        }
    }
}