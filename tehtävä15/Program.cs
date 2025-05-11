/* 15.Lue konsolista syöte, kysy syötettä niin kauan kunnes käyttäjä antaa numeron. Tulosta numero. Jos on jotain muuta syötetty. Tulosta ”Anna numero” */


using System.Diagnostics;

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            bool isNumberGiven = false;

            // Цикл продолжается, пока пользователь не введет число
            // Silmukka jatkuu, kunnes käyttäjä syöttää numeron
            while (!isNumberGiven)
            {
                Console.WriteLine("Syötä numero: ");
                string userinput = Console.ReadLine();

                // Проверка, является ли ввод числом
                //Tarkistus, onko syöte numero
                isNumberGiven = int.TryParse(userinput, out number1);

                if (isNumberGiven == false)  //!isNumberGiven
                {
                    Console.WriteLine("Hei hupsu, te antanut numeroa. Anna numero");
                }
            }

            // Печать введенного числа
            //Syötetyn numeron tulostaminen
            Console.WriteLine("Syötit numeron: " + number1);

        }
    }
}
