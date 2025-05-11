/* 14. Tee boolean tyyppinen muuttuja, joka on oletuksena false. Anna käyttäjän syöttää kaksi numeroa ja jos niiden kertolasku ylittää 87, muuta boolean muuttujan arvoksi true. Tulosta aina syötteen jälkeen boolean muuttujan arvo. */
/*здайте переменную типа boolean, которая по умолчанию равна false. Позвольте пользователю ввести два числа, и если их произведение превышает 87, измените значение переменной boolean на true. Всегда выводите значение переменной boolean после ввода.*/


using System.Diagnostics;

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация булевой переменной со значением false
            //Boolean-muuttujan alustaminen arvolla false
            bool test = false;

            // Запрос двух чисел у пользователя
            // Kahden numeron kysyminen käyttäjältä
            Console.Write("Syötä ensimmäinen numero: ");
            int number1 = Int32.Parse(Console.ReadLine());

            Console.Write("Syötä toinen numero: ");
            int number2 = Int32.Parse(Console.ReadLine());

            // Проверка произведения чисел
            // Lukujen kertolaskun tarkistaminen
            if (number1 * number2 > 87)
            {
                test = true;
            }

            // Печать значения булевой переменной
            // Boolean-muuttujan arvon tulostaminen
            Console.WriteLine($"Boolean muuttujan arvo: {test}");
            Console.ReadKey();
        }
    }
}
/*Команда Console.ReadKey(); используется для того, чтобы ожидать нажатия любой клавиши пользователем перед завершением программы. Это особенно полезно в консольных приложениях, чтобы программа не закрывалась сразу после выполнения и пользователь имел возможность увидеть результаты выполнения кода.

Когда программа доходит до этой команды, она приостанавливает выполнение и ждет, пока пользователь нажмет любую клавишу. Это позволяет, например, прочитать вывод программы перед ее завершением.*/