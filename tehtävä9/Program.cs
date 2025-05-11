//9.Käy läpi numerot 1-100 ja tulosta parittomat numerot konsoliin

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Näytetään parittomat numerot konsoliin 1-100");
            // Käydään läpi numerot 1-100
            for (int i = 0; i <= 100; i++)
            {

                if (i % 2 != 0)
                {
                    // Tulostetaan nykyinen numero
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}