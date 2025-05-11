// 23. Luo taulukko, jossa on 5kpl numeroita. Kerro taulukon kaikki numerot 3:lla. Tulosta uudet numerot
// Создайте массив, содержащий 5 чисел. Умножьте все числа в массиве на 3. Выведите новые числа.

using System;

namespace keskiviikko
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Tervetuloa ohjelmaan.");

            // Luo taulukko, jossa on 5 numeroa
            int[] numerot = { 6, 9, 23, 54, 12 };

            // Käy läpi taulukon ja kerro jokainen luku 3:lla
            /*for (int i = 0; i < numerot.Length; i++)
            {
                numerot[i] *= 3;
            }

            // Tulosta uudet numerot
            Console.WriteLine("Uudet numerot:");
            foreach (int numero in numerot)
            {
                Console.WriteLine(numero);
            }*/
            int i = 0;
            foreach (int numero in numerot)
            {
                Console.WriteLine(numero);
                int uusiNumero = numero * 3;
                Console.WriteLine("Kerrotaan se kolmella: " + uusiNumero);
                numerot[i] = uusiNumero;
                i++;
            }

            foreach (int numero in numerot)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
