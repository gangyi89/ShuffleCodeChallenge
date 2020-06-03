using System;
namespace ShuffleCodeChallenge
{
    public class Deck
    {
        public ListNode Top { get; set; }

        //Tracking bottom card to avoid linear search when adding to back
        public ListNode Bottom { get; set; }

        /// <summary>
        /// Initialise empty deck
        /// </summary>
        public Deck()
        {
            Top = null;
            Bottom = null;
        }

        public Deck(int size)
        {
            Top = null;
            Bottom = null;

            PopulateDeck(size);
        }

        public void AddToBack(ListNode Card)
        {
            Card.Next = null;

            //edge case if there is no card
            if (Top == null)
            {
                Top = Card;
            }
            else
            {
                Bottom.Next = Card;
            }

            Bottom = Card;
        }

        public void AddToFront(ListNode Card)
        {
            if (Top == null)
            {
                //this is a empty deck scenario
                Card.Next = null;
                Top = Card;
                Bottom = Card;

            }
            else
            {
                //Card already exist in the deck
                Card.Next = Top;
                Top = Card;
            }

        }

        public ListNode RemoveTopCard()
        {
            if(Top != null)
            {
                ListNode RemovedCard = Top;
                Top = Top.Next;

                //If draw last card, remove bottom pointer as well
                if(Top == null)
                {
                    Bottom = null;
                }
                return RemovedCard;
            }

            return null;
        }

        public bool IsOrdered()
        {
            ListNode current = Top;
            int count = 1;
            while(current != null)
            {
                if (current.Value != count) return false;
                current = current.Next;
                ++count;
            }

            return true;
        }

        public void Print()
        {
            ListNode current = Top;

            if(Top != null) Console.WriteLine($"Top of the deck is: {Top.Value}");
            if(Bottom != null) Console.WriteLine($"Bottom of the deck is: {Bottom.Value}");
            Console.WriteLine($"=============Full Deck=================");

            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }
            Console.Write("\n");
        }

        private void PopulateDeck(int size)
        {
            for (int i = 1; i < size + 1; i++)
            {
                ListNode newCard = new ListNode(i);
                AddToBack(newCard);
            }
        }
    }
}
