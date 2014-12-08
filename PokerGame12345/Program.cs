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
            Console.WriteLine(myCard);
            Console.ReadKey();
        }
    }

    class PlayingCard
    {
        public enum Suit
        {
            Diamonds = 1,
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
}
