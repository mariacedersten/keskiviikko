// 4.Lukee konsolista ensin yhden nimen, tämän jälkeen toisen, ja sitten tulostaa kummatkin.

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna nimesi1: ");
            string input1 = Console.ReadLine();

            Console.Write("Anna nimesi2: ");
            string input2 = Console.ReadLine();

            Console.WriteLine("Sinun nimesi on: " + input1 + " " + input2);
        }
    }
}