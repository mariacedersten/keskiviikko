﻿class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tervetuloa pelaamaan pokeria");
        // Luodaan Deck luokasta uusi objekti eli korttipakka peliin.
        Deck deck = new Deck();

        Console.WriteLine("Anna nimesi kiitos");
        string name = Console.ReadLine();
        // Luodaan Pelaaja ja annetaan pelaajalle konstruktorin vaatimat informaatiot
        Player player = new Player(name, 5, deck);
        // Annetaan pelaajalle rahaa
        player.money = 100;


        Console.WriteLine("Palaamassa tänään on: " + player.name + " joka saa kortteja käteen"
            + player.hand.Length + " kappaletta, pakasta " + deck);

        while (player.gameRunning)
        {
            // Kysytään panos ja käsitellään rahamäärä.
            bool betOK = false;

            while (betOK == false)
            {
                Console.WriteLine("Paljonko haluat laittaa panokseksi? 1-10?");
                player.bet = Int32.Parse(Console.ReadLine());
                if (player.bet <= player.money && player.bet >= 1 && player.bet <= 10)
                {
                    betOK = true;
                }
            }
            player.money -= player.bet;

            // Jaetaan pelaajalle 5 korttia
            deck.Deal(player.hand.Length, player);
            // Käynnistetään funktio, joka mahdollistaa korttien vaihtamisen kädestä.
            player.ChangeCards();
            // Tarkastetaan lopputulos
            player.CheckResults();
        }
        Console.WriteLine("Kiitos kun pelasit pokeria. Ohjelma sammuu");
        Console.ReadKey();
    }

}

class Deck
{
    public int[] deckCards = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
        11, 12, 13, 14, 15, 16, 17, 18, 19,
        20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
        30, 31, 32, 33, 34, 35, 36, 37, 38, 39,
        40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51 };

    // Listaan aina lisätään se kortti, joka vedetään korttipakasta.
    public List<int> takenCards = new List<int>();

    // Konstruktori on funktio, jolla täytyy olla sama nimi kuin luokalla
    // Kun luokasta(class) luodaan uusi objekti, eli ilmentymä ajetaan konstruktori
    // automaattisesti, eli sitä ei tarvitse erikseen kutsua.
    public Deck()
    {
        Console.WriteLine("Korttipakka on luotu peliin." +
            "Tämä on korttipakan konstruktori. Tämä ajetaan automaattisesti");
    }

    // Funktio, joka jakaa halutun määrän kortteja tietylle pelaajalle.
    public void Deal(int amount, Player player)
    {
        Console.WriteLine("Jaetaan " + amount + " satunnaista korttia pelaajalle: " + player.name);
        // Satunnainen jako
        Random random = new Random();
        // Yritä niin kauan ottaa kortteja korttipakasta, kunnes käsi on täynnä kortteja eli 5kpl.
        // Vedettäessä kortti korttipakasta, tarkasta onko korttia jo vedetty aikaisemmin.
        // Jos on, vedä uusi satunnainen kortti, jos ei, laita kortti pelaajan käteen.
        // Tee tätä niin kauan kunnes pelaajan käsi on täynnä kortteja.

        int i = 0;
        while (i < amount)
        {
            // Satunnainen korttinumero 0-51 väliltä.
            int cardValue = deckCards[random.Next(0, deckCards.Length)];
            //int cardValue = deckCards[random.Next(deckCards.Length)];

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
                Console.WriteLine("Kortti " + cardValue + " oli jo vedetty. Arvotaan uudestaan");
            }
        }
        player.ShowHand();
    }

    public int GetCard()
    {
        // Tämä on yleinen funktio, joka palauttaa aina jonkun satunnaisen kortin
        // Käytännössä palauttaa numeron 0-51 välillä.
        Random random = new Random(Guid.NewGuid().GetHashCode());
        int card = deckCards[random.Next(0, deckCards.Length)];
        return card;
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
    public bool gameRunning = true;

    // Luo Player luokan konstruktorifunktio
    // Kun pelaaja luodaan ohjelmassa, sille TÄYTYY kertoa konstruktorin vaatimat asiat
    // Jokaiselle pelaajalle kerrotaan nimi, korttien tila kädessä ja korttipakkaobjekti

    public Player(string nameInput, int numOfCards, Deck gameDeck)
    {
        name = nameInput;
        hand = new int[numOfCards];
        deck = gameDeck;
        // Kun uusi pelaaja luodaan, halutaan pelaajalle antaa nimi ja kertoa, että käteen
        // mahtuu 5 korttia ja pelaajan tulee myös tietää millä korttipakalla hän pelaa
        // Luodaan siis yhteys pelaajan ja korttipakan välille.
    }

    public void ShowHand()
    {
        // Tämä funktio listaa/näyttää pelaajan kortit konsolissa.
        Console.WriteLine("Pelaajan " + name + " kortit ovat: ");
        // Tee tähän for looppi, joka listaa pelaajan kädessä olevat kortit.
        for (int i = 0; i < hand.Length; i++)
        {
            Console.WriteLine("Kortti kädessä " + i + " on " + ConvertCardToText(hand[i]));
        }
    }

    // Tämä on hieno funktio. :)
    // Tämä funktio vaatii parametrina int arvon, joka on CardID
    // Funktio teke sen, että se palauttaa string arvon paikkaan jossa sitä
    // on kutsuttu. Siksi public string....
    public string ConvertCardToText(int card)
    {
        string suit = "jokumaa";
        int number = 999;
        string numberText = "";

        if (card <= 12)
        {
            suit = "Hertta";
            number = card + 1;
        }
        else if (card <= 25)
        {
            suit = "Ruutu";
            number = card - 12;
        }
        else if (card <= 38)
        {
            suit = "Risti";
            number = card - 25;
        }
        else
        {
            suit = "Pata";
            number = card - 38;
        }
        // Tästä alkaa uudet iffit

        switch (number)
        {
            case 1:
                numberText = "Ässä";
                break;
            case 11:
                numberText = "Jätkä";
                break;
            case 12:
                numberText = "Akka";
                break;
            case 13:
                numberText = "Kunkku";
                break;
            default:
                // code block
                break;
        }

        // return komento edellytetään funktioissa, jotka palauttaa jotain.
        // tässä tapauksessa return palauttaa string merkkijonon kortin tiedoista
        // esimerkiksi: ruutu 7
        if (numberText != "")
        {
            return suit + " " + numberText;
        }
        else
        {
            return suit + " " + number.ToString();
        }
    }

    public void ChangeCards()
    {
        /*
Pyydetään käyttäjältä pilkkueroteltuna ne käden sijainnit, jotka halutaan vaihtaa.
Esimerkiksi 0,1,3
Sitten poistetaan syötteestä pilkut ja laitetaan numerot 0 1 ja 3 taulukkoon
Käydään loopilla taulukko läpi ja vedetään kyseiseen sijaintiin pakasta uusi
satunnainen kortti. Testataan, onko kortti jo vedettyjen korttien listalla ja
jos ei ole, laitetaan kortti käteen oikeaan sijaintiin. Lisätään kortti myös
vedettyjen korttien listaan.
*/
        Console.WriteLine("Erottele pilkulla ne korttisijainnit, " +
            "jotka haluat vaihtaa. Esim. 0,1,3. Jos et halua vaihtaa mitään, kirjoita E");
        string changeCards = Console.ReadLine(); // 0,1,3
                                                 // Tämä rivi poistaa käyttäjän syötteestä pilkut ja ottaa numerot ja
                                                 // laittaa ne nums taulukkoon
        if (changeCards == "E")
        {
            Console.WriteLine("Ei vaihdeta kortteja");
        }
        else
        {
            int[] nums = Array.ConvertAll(changeCards.Split(','), int.Parse);

            int i = 0;
            while (i < nums.Length)
            {
                // Pyydetään korttipakasta satunnainen kortti
                int cardValue = deck.GetCard();
                Console.WriteLine("Vedettiin kortti: " + cardValue + " " + ConvertCardToText(cardValue));

                // Tarkastetaan onko korttia jo vedetty
                if (!deck.takenCards.Contains(cardValue))
                {
                    // Kortti on käytettävissä, koska se ei ole takenCards listassa
                    // Lisätään kortti käteen ja otettujen korttien listaan
                    hand[nums[i]] = cardValue;
                    deck.takenCards.Add(cardValue);
                    i++;
                }
                else
                {
                    // Kortti oli jo vedetty, ei tehdä mitään.
                    Console.WriteLine("Yritettiin ottaa sellaista korttia, joka on jo pelissä.");
                }
            }
        }
        ShowHand();
    }

    public string GetSuit(int card)
    {
        string suit;
        if (card <= 12)
        {
            suit = "Hertta";
        }
        else if (card <= 25)
        {
            suit = "Ruutu";
        }
        else if (card <= 38)
        {
            suit = "Risti";
        }
        else
        {
            suit = "Pata";
        }
        return suit;
    }

    public int GetNumber(int card)
    {
        int number = 999;
        if (card <= 12)
        {
            number = card + 1;
        }
        else if (card <= 25)
        {
            number = card - 12;
        }
        else if (card <= 38)
        {
            number = card - 25;
        }
        else
        {
            number = card - 38;
        }
        return number;
    }

    public void CheckResults()
    {
        Console.WriteLine("Tarkastetaan tuloksia");
        if (GetSuit(hand[0]) == GetSuit(hand[1]) && GetSuit(hand[1]) == GetSuit(hand[2])
            && GetSuit(hand[2]) == GetSuit(hand[3]) && GetSuit(hand[3]) == GetSuit(hand[4]))
        {
            Console.WriteLine("SINULLA ON VÄRI!!!");
            money += bet * 7;
        }
        // Tehdään taulukko, johon laitetaan korttien numerot. Järjestetään taulukko suuruusjärjestykseen
        // ja tehdään if lause suoran testausta varten.
        int[] handNumbers = new int[5];

        for (int i = 0; i < hand.Length; i++)
        {
            // Siirrä taulukosta toiseen ja käytä funktiossa.
            handNumbers[i] = GetNumber(hand[i]);
            // extra
            Console.WriteLine(handNumbers[i]);
        }
        Array.Sort(handNumbers);

        // if lause eka numero - toka numero == -1 JA tokanumero - kolmasnumero == -1 JA kolmasnumero...
        if (handNumbers[0] - handNumbers[1] == -1 && handNumbers[1] - handNumbers[2] == -1 &&
            handNumbers[2] - handNumbers[3] == -1 && handNumbers[3] - handNumbers[4] == -1)
        {
            Console.WriteLine("SINULLA ON SUORA");
            money += bet * 5;
        }

        //Kysytään pelaajalta päätöstä, haluaako hän jatkaa peliä
        Console.WriteLine("Sinulla on rahaa jäljellä: " + money);
        Console.WriteLine("Haluatko jatkaa peliä? Vastaa K/E");
        if (Console.ReadLine() == "E")
        {
            gameRunning = false;
        }
        else
        {
            // Peli jatkuu, tyhjennetään otettujen korttien lista, jotta peli alkaa "alusta".
            deck.takenCards.Clear();
        }
    }
}

