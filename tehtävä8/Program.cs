// 8.Käy läpi loopilla numerot 1-10 ja tulosta ne konsoliin

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Näytetään luvut 1_10");
            // Käydään läpi numerot 1-10
            for (int i = 1; i <= 10; i++)
            {
                // Tulostetaan nykyinen numero
                Console.WriteLine(i);
            }
        }
    }
}
