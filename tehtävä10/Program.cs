/*10. Tee taulukko, jossa on numerot: 1,2,3,5,6,7,9,6,5,4,3. Käy läpi taulukon numerot ja laske ne yhteen.*/

/*Tee taulukko, jossa on numerot: 1,2,3,5,6,7,9,6,5,4,3. 
Käy läpi taulukon numerot ja laske ne yhteen.*/

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Luo taulukko, joka sisältää numerot
            int[] numerot = { 1, 2, 3, 5, 6, 7, 9, 6, 5, 4, 3 };

            //Jos tiedostossa on käytössä Using System.Linq ylhäällä
            //On mahdollista käytää array.Sum() - funktiota, joka laskee
            //taulukon numeros yhteen ilman foreach loopin käyttöä.

            // Muuttuja summan laskemista varten
            int summa = 0;

            // Käy läpi kaikki taulukon numerot ja laske ne yhteen
            foreach (int numero in numerot)
            {
                //Tulostaa yhden numeron kerrallaan taukosta
                Console.WriteLine(numero);
                //Lisää numero summan. Miten sen teet?
                summa = summa + numero;
                Console.WriteLine("Summatäällä hetkellä: " + summa);
            }

            // Tulosta lopullinen summa
            Console.WriteLine("Taulukon numeroiden summa: " + summa);
        }
    }
}