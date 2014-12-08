using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame12345
{
    class Deck
    {
        public List<PlayingCard> CardsInTheDeck = new List<PlayingCard>();
        public void InitializeDeck()
        {
            for (int i = 0; i <= 3; i++)
            {
                PlayingCard.Suit suitChoice = (PlayingCard.Suit)i;

                for (int j = 2; j <= 14; j++)
                {
                    PlayingCard.Rank rankChoice = (PlayingCard.Rank)j;
                    CardsInTheDeck.Add(new PlayingCard(suitChoice, rankChoice));
                }
            }
        }
        public List<PlayingCard> ListOfDealtCards = new List<PlayingCard>();
    }
}
