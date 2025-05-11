// 21.Lue numero syötteestä. Palauta true jos luvussa esiintyy numero 5 ja se on pienempi kuin 100.

using System;

namespace keskiviikko
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna numero:");
            string syote = Console.ReadLine();
            // Numeron kelpoisuuden tarkistaminen: 
            // int.TryParse varmistaa, että syöte on kelvollinen kokonaisluku.
            if (int.TryParse(syote, out int numero))
            {
                bool tulos = numero < 100 && numero.ToString().Contains('5');
                Console.WriteLine(tulos ? "Ehdot täyttyvät: true" : "Ehdot täyttyvät: false");
            }
            else
            {
                Console.WriteLine("Syöte ei ollut kelvollinen numero.");
            }

            /*
            if (int.TryParse(syote, out int numero))
            {
                bool tulos = SisaltaaVitosenJaOnPienempiKuinSata(numero);
                Console.WriteLine($"Ehdot täyttyvät: {tulos}");
            }
            else
            {
                Console.WriteLine("Syöte ei ollut kelvollinen numero.");
            }

        }

        static bool SisaltaaVitosenJaOnPienempiKuinSata(int luku)
        {
            // Tarkistetaan, onko luku pienempi kuin 100
            if (luku >= 100)
                return false;

            // Tarkistetaan, sisältääkö luku numeron 5
            return luku.ToString().Contains('5');
            */
        }
    }
}