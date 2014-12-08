using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck ourDeck = new Deck();
            ourDeck.InitializeFullDeck();
            ourDeck.CardsInDeck.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine(myCard);
            Console.ReadKey();
        }
    }

    class Deck
    {
        public List<PlayingCard> CardsInDeck = new List<PlayingCard>();
        public List<PlayingCard> DealtCards = new List<PlayingCard>();
        private Random rng = new Random();

        public void InitializeFullDeck()
        {
            for (int i = 0; i <= 3; i++)
            {
                PlayingCard.Suit suitChoice = (PlayingCard.Suit)i;

                for (int j = 2; j <= 14; j++)
                {
                    PlayingCard.Rank rankChoice = (PlayingCard.Rank)j;
                    CardsInDeck.Add(new PlayingCard(suitChoice, rankChoice));
                }
            }
        }

        public void Shuffle()
        {
            if (CardsInDeck.Count > 1)
            {
                for (int i = CardsInDeck.Count - 1; i >= 0; i--)
                {
                    PlayingCard temp = CardsInDeck[i];
                    int randomIndex = rng.Next(i + 1);

                    CardsInDeck[i] = CardsInDeck[randomIndex];
                    CardsInDeck[randomIndex] = temp;
                }
            }
        }

        public PlayingCard DealACard()
        {
            int randomIndex = rng.Next(0, CardsInDeck.Count());
            PlayingCard tempCard = CardsInDeck.ElementAt(randomIndex);
            DealtCards.Add(tempCard);
            CardsInDeck.RemoveAt(randomIndex);

            return tempCard;
        }

    }

    class PlayingCard
    {
        public enum Suit
        {
            Diamonds,
            Hearts,
            Spades,
            Clubs

        }
        public enum Rank
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
            Ace = 14
        }
        public Suit MySuit { get; set; }
        public Rank MyRank { get; set; }

        public override string ToString()
        {
            return (MyRank.ToString() + " of " + MySuit.ToString());
        }

        public PlayingCard(Suit _suit, Rank _rank)
        {
            MySuit = _suit;
            MyRank = _rank;
        }

        public int CompareTo(object obj)
        {
            PlayingCard secondCard = (PlayingCard)obj;
            if (this.MyRank > secondCard.MyRank)
            {
                return 1;
            }
            if (this.MyRank < secondCard.MyRank)
            {
                return -1;
            }
            if (this.MySuit > secondCard.MySuit)
            {
                return 1;
            }
            if (this.MySuit < secondCard.MySuit)
            {
                return -1;
            }
            return 0; 
        }
    }

    class PokerPlayer
    {

    }
}
