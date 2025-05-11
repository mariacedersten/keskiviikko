/* 13. Lue konsolista numero, montako nimeä käyttäjä syöttää. Tämän jälkeen anna käyttäjän syöttää niin monta nimeä kuin numero osoittaa. Laita nimet taulukkoon. Tämän jälkeen tulosta taulukon nimet aakkosjärjestyksessä.   */

using System.Diagnostics;

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa ohjelmaan");
            Console.WriteLine("Tänään on:" + DateTime.Now);

            Console.WriteLine("Anna nimien määrä numerona");

            string amtOfNames = Console.ReadLine();
            int namesAmount = Int32.Parse(amtOfNames);

            // Tehdään taulukko, jossa tilaa annetun nimimäärän verran
            string[] names = new string[namesAmount];

            // for looppi, jossa pyydetään jokaiseen taulukon paikkaan nimi
            // kuvitellaan, että namesAmout on 7.

            for (int i = 0; i < namesAmount; i++)
            {
                Console.WriteLine("Anna nimi " + (i + 1) + "/" + namesAmount + ":");
                names[i] = Console.ReadLine();

            }

            // Taulukon nimien järjestäminen aakkosjärjestykseen.
            Array.Sort(names);

            Console.WriteLine("Kiitos nimistä, tulostetaan ne seuravaaksi");

            // Tee tähän for each looppi, joka tulostaa nimet taulukosta
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }

}
