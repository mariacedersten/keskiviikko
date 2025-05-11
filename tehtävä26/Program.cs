//Создание полноценной игры в покер

using System;

namespace keskiviikko
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa pelaamaan pokeria");
            // Luodaan Desk luokasta uusi objekti eli korttipakka peliin.
            Deck deck = new Deck();

            Console.WriteLine("Anna nimesi kiitos");
            string name = Console.ReadLine();
            // Luodaan Pelaaja ja annetaan pelaajalle konstruktorin vaatimat informaatiot
            Player player = new Player(name, 5, deck);

            Console.WriteLine("Pelaamassa tänään on: " + player.name + " joka saa kortteja käteen " + player.hand.Length + " kappaletta, pakasta " + deck);

            // Jaetaan pelaajalle 5 korttia
            deck.Deal(player.hand.Length, player);

            Console.WriteLine("Kiitos kun pelasit pokeria. Ohjelma sammuu");
            Console.ReadKey();
        }
    }

    class Deck
    {
        public int[] deckCards = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51 };

        // Listaan aina lisätään se kortti, joka vedetääv korttipakasta.
        public List<int> takenCards = new List<int>();

        // Konstruktori on funktio, jolla täytyy olla sama nimi kuin luokalla
        // Kun luokasta (class) luodaan uusi objekti, eli ilmentymä ajetaan konstruktori 
        // automaattisesti, eli sitä ei tarvitse erikseen kutsua. 
        public Deck()
        {
            Console.WriteLine("Korttipakka on luotu peliin" + "Tämä on korttipakan konstruktori. Tämä ajetaan automaattisesti.");
        }
        // Funktio, joka jakaa halutun määrän kortteja tietylle pelaajalle.
        public void Deal(int amount, Player player)
        {
            Console.WriteLine("Jaetaan " + amount + "satunnaista korttia pelaajalle: " + player.name);
            // Satunnainen jako
            Random random = new Random();
            // Yritä niin kauan ottaa kortteja korttipakasta, kunnes käsi on täynnä kortteja 5 kpl.
            // Vedettäessä kortti korttipakasta, tarkista onko korttia jo vedetty aikaisemmin.
            // Jos on, vedä uusi satummainen kortti, jos ej, laita kortti pelaajan käteen.
            // Tee tätä niin kauan kunnes pelaajan käsi on täynnä kortteja.

            int i = 0;
            while (i < amount)
            {
                // Satunnainen korttinumero 0-51 väliltä.
                int cardValue = random.Next(0, deckCards.Length);
                // int cardValue = deckCards[random.Next(deckCard.Length)];

                // Tarkastetaan onko kortti takenCards listassa
                if (!takenCards.Contains(cardValue))
                {
                    // Tämä ajetaan jos takenCards lista ei sisällä arvottua arvoa deckistä
                    Console.WriteLine("Kortti, jonka sait on: " + cardValue);
                    player.hand[i] = cardValue;
                    // Lisätään vedetty kortti takenCards listalle
                    takenCards.Add(cardValue);
                    i++;
                }
                else
                {
                    Console.WriteLine("Kortti " + cardValue + " oli jo vedetty. Arvostaan  uudestaan");
                }
            }

        }
    }
    class Player
    {
        public string name;
        public int[] hand; // Taulukko, jonka koko 5 ja sisältää kortit
        public int money;
        public int bet;
        public string result; // Tekstinä mikä on käden tulos. Esim. "Täyskäsi"
        public Deck deck; // Tämä on korttipakkaobjekti, josta pelaaja on tietoinen

        // Luo Player luokan konstruktorifunktio
        // Kun pelaaja luodaan ohjelmassa, sille TÄYTYY kertoa konstruktorin vaatimat asiat
        // Jokaiselle pelaajalle kerrotaan nimi, korttien tila kädessä ja korttipakkaobjekti

        public Player(string nameInput, int num0fCards, Deck gameDeck)
        {
            name = nameInput;
            hand = new int[num0fCards];
            deck = gameDeck;
            // Kun uusi pelaaja luodaan, halutaam pelaajalle antaa nimi ja keroa, että käteen
            // mahtuu 5 korttia ja pelaajan tulee myös tietää millä korttipakalla hän pelaa
            // Luodaan siis yhteys pelaajan ja korttipakan välille, 

        }
    }
}

