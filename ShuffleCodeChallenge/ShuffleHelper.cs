using System;
namespace ShuffleCodeChallenge
{
    public static class ShuffleHelper
    {
        public static int ShuffleDeck(int size)
        {
            bool isOrdered = false;
            int roundCount = 0;

            //edge case
            if (size == 0) return 0;

            Deck deck = new Deck(size);

            while (!isOrdered)
            {
                ShuffleRound(ref deck);
                isOrdered = deck.IsOrdered();
                ++roundCount;
            }

            return roundCount;
        }

        private static void ShuffleRound(ref Deck deck)
        {
            Deck handDeck = deck;
            Deck tableDeck = new Deck();

            //initialize card with value 0
            ListNode Card = new ListNode(0);

            while (true)
            {
                //Take the top card off the deck and set it on the table
                Card = deck.RemoveTopCard();
                if (Card == null) break;
                tableDeck.AddToFront(Card);

                //Take the next card off the top and put it on the bottom of the deck in your hand.
                Card = deck.RemoveTopCard();
                if (Card == null) break;
                handDeck.AddToBack(Card);
            }

            deck = tableDeck;

        }
    }
}
