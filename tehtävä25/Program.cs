// 25. Luo metodi nimeltä ”Welcome”. Ohjelman käynnistyessä Welcome metodi ajetaan ja konsoliin tulostuu ”Welcome to play a game”.
// Создайте метод с именем «Welcome». При запуске программы метод Welcome должен быть выполнен, и в консоли должно появиться сообщение «Welcome to play a game»

using System;

namespace keskiviikko
{
    class Program
    {

        static void Main(string[] args)
        {
            //эта строка выводит на консоль сообщение: "Tervetuloa ohjelmaan."
            Console.WriteLine("Tervetuloa ohjelmaan.");
            //это вызов метода Welcome, который выводит дополнительное сообщение.
            Welcome();

        }
        static void Welcome()
        {
            // Когда метод Welcome вызывается в методе Main, он выполняет команду внутри себя, а именно: выводит сообщение "Welcome to play a game.". Tätä koodia ei ajeta, ellei funktiota kutsuta jossain.
            Console.WriteLine("Welcome to play a game.");
        }
    }
}

