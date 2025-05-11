
/* 
6.Lue numero konsolista, jos se on 25-100 välillä, kirjoita konsoliin ok, jos se on pienempi kuin 25, kirjoita liian pieni, jos suurempi kuin 100, kirjoita liian suuri.
lue merkkijono konsolista muttujaan
Muuta merkkijono numeroksi
Tee if lause, jossa tarkastan onko numero 25-100 välillä
Tee if else lause, jossa katsot onko numero pienempi kuin 25
Tee else, jolloin numero on > 100 
*/
/*namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pyydetään käyttäjältä syötettä
            Console.WriteLine("Syötä numero:");

            // Luetaan numero konsolista
            int numero;

            // Yritetään muuntaa syöte kokonaisluvuksi
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                // Tarkistetaan syötetyn numeron arvo ja tulostetaan vastaava viesti
                if (numero >= 25 && numero <= 100)
                {
                    Console.WriteLine("ok");
                }
                else if (numero < 25)
                {
                    Console.WriteLine("liian pieni");
                }
                else //if (numero > 100)
                //Tiedetään, että luku ei ole 25-100 välillä
                //Tiedetään myös, että se ei ole pienempi kuin 25
                //Joten luvut on oltava suurempi kuin 100, eli liian suuri.
                {
                    Console.WriteLine("liian suuri");
                }
            }
            Console.ReadKey();
        }
    }
}
*/

using System;

namespace keskiviikko
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Tervetuloa kertotauluohjelmaan");
            bool lopetaOhjelma = false;
            int numero;
            Console.WriteLine("Anna jokin numero, niin kerron onko se sopiva");
            Console.WriteLine("Kirjoita loppu jos haluat lopettaa ohjelman");
            while (lopetaOhjelma == false)
            {
                string syote = Console.ReadLine();
                if (syote.ToLower() == "loppu")
                {
                    lopetaOhjelma = true;
                    break;
                }
                else
                {
                    bool success = int.TryParse(syote, out numero);
                    if (success == true)
                    {
                        Console.WriteLine("Annoit numeron. Hyvä juttu");
                        if (numero >= 25 && numero <= 100)
                        {

                            Console.WriteLine("OK!");

                        }
                        else if (numero < 25)
                        {
                            Console.WriteLine("Liian pieni");
                        }
                        else
                        {
                            // Tiedetään, että luku ei ole 25-100 välillä
                            // Tiedetään myös, että se ei ole pienempi kuin 25
                            // Joten luvun on oltava suurempi kuin 100, eli liian suuri.
                            Console.WriteLine("Liian suuri");
                        }
                    }
                    else
                    {

                        Console.WriteLine("Et antanut numeroa. Yritä uudestaan");
                    }

                    //numero = Int32.Parse(syote);
                }

                //Console.WriteLine("Annoit numeron:" + numero);

                // || tarkoittaa sanaa tai
                // && tarkoittaa sanaa ja



            }

            Console.WriteLine("Kirjoitit loppu, ohjelma sulkeutuu kun painat painiketta");
            Console.ReadKey();

        }
    }
}