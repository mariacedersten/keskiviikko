// 3.Lukee konsolista käyttäjän kirjoittaman nimen ja tulostaa sen konsoliin: ”Sinun nimesi on:  ” [nimi]
namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna nimesi: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Sinun nimesi on: " + input1);
        }
    }
}
