using System;
using System.Collections.Generic;

namespace BlackjackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            Deck deck = new Deck();
            deck.Shuffle();

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Player player = new Player(name);
            Dealer dealer = new Dealer();

            bool gameRunning = true;

            while (gameRunning)
            {
                player.ResetHand();
                dealer.ResetHand();

                Console.WriteLine($"\n{name}, you start with $100.");
                Console.WriteLine("How much would you like to bet? (1-100)");
                int bet = int.Parse(Console.ReadLine());
                player.Bet(bet);

                // Initial deal
                player.AddCard(deck.DealCard());
                player.AddCard(deck.DealCard());
                dealer.AddCard(deck.DealCard());
                dealer.AddCard(deck.DealCard());

                Console.WriteLine($"Your hand: {player.ShowHand()} (Score: {player.HandValue()})");
                Console.WriteLine($"Dealer's visible card: {dealer.ShowFirstCard()}");

                // Player's turn
                while (!player.IsBusted() && player.WantsToHit())
                {
                    player.AddCard(deck.DealCard());
                    Console.WriteLine($"Your hand: {player.ShowHand()} (Score: {player.HandValue()})");
                }

                if (player.IsBusted())
                {
                    Console.WriteLine("You busted! Dealer wins.");
                    continue;
                }

                // Dealer's turn
                while (dealer.ShouldHit())
                {
                    dealer.AddCard(deck.DealCard());
                }

                Console.WriteLine($"Dealer's hand: {dealer.ShowHand()} (Score: {dealer.HandValue()})");

                // Determine the winner
                if (dealer.IsBusted() || player.HandValue() > dealer.HandValue())
                {
                    Console.WriteLine("You win!");
                    player.WinBet(bet);
                }
                else if (player.HandValue() == dealer.HandValue())
                {
                    Console.WriteLine("It's a tie!");
                    player.PushBet(bet);
                }
                else
                {
                    Console.WriteLine("Dealer wins.");
                }

                Console.WriteLine($"Your total money: ${player.Money}");
                Console.WriteLine("Do you want to play again? (Y/N)");
                gameRunning = Console.ReadLine()?.ToUpper() == "Y";
            }

            Console.WriteLine("Thanks for playing!");
        }
    }

    class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();

            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    cards.Add(new Card(value, suit));
                }
            }
        }

        public void Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card DealCard()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }

    class Card
    {
        public string Value { get; }
        public string Suit { get; }

        public Card(string value, string suit)
        {
            Value = value;
            Suit = suit;
        }

        public int GetCardValue()
        {
            if (int.TryParse(Value, out int numericValue)) return numericValue;
            if (Value == "Ace") return 11;
            return 10;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }

    class Player
    {
        public string Name { get; }
        public int Money { get; private set; }
        private List<Card> hand;

        public Player(string name)
        {
            Name = name;
            Money = 100;
            hand = new List<Card>();
        }

        public void ResetHand()
        {
            hand.Clear();
        }

        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        public string ShowHand()
        {
            return string.Join(", ", hand);
        }

        public int HandValue()
        {
            int value = 0;
            int aceCount = 0;

            foreach (var card in hand)
            {
                value += card.GetCardValue();
                if (card.Value == "Ace") aceCount++;
            }

            while (value > 21 && aceCount > 0)
            {
                value -= 10;
                aceCount--;
            }

            return value;
        }

        public bool IsBusted()
        {
            return HandValue() > 21;
        }

        public bool WantsToHit()
        {
            Console.WriteLine("Do you want to hit or stand? (H/S)");
            return Console.ReadLine()?.ToUpper() == "H";
        }

        public void Bet(int amount)
        {
            Money -= amount;
        }

        public void WinBet(int amount)
        {
            Money += amount * 2;
        }

        public void PushBet(int amount)
        {
            Money += amount;
        }
    }

    class Dealer
    {
        private List<Card> hand;

        public Dealer()
        {
            hand = new List<Card>();
        }

        public void ResetHand()
        {
            hand.Clear();
        }

        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        public string ShowHand()
        {
            return string.Join(", ", hand);
        }

        public string ShowFirstCard()
        {
            return hand[0].ToString();
        }

        public int HandValue()
        {
            int value = 0;
            int aceCount = 0;

            foreach (var card in hand)
            {
                value += card.GetCardValue();
                if (card.Value == "Ace") aceCount++;
            }

            while (value > 21 && aceCount > 0)
            {
                value -= 10;
                aceCount--;
            }

            return value;
        }

        public bool IsBusted()
        {
            return HandValue() > 21;
        }

        public bool ShouldHit()
        {
            return HandValue() < 17;
        }
    }
}
