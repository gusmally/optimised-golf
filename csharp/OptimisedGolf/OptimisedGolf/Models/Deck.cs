using System;
using System.Collections.Generic;
using System.Linq;

namespace OptimisedGolf.Models
{
    public class Deck
    {
        private List<Card> cards;

        /// <summary>
        /// Needs to be checked before calling DealOne
        /// TODO: it'd be nice to embed this in the DealOne call somehow, so it doesn't have to be manually checked.
        /// Maybe an event for when the cards run out that the main class listens to an shuffles the discard pile?
        /// </summary>
        /// <value><c>true</c> if has next; otherwise, <c>false</c>.</value>
        public bool HasNext
        {
            get
            {
                return this.cards.Any();
            }
        }

        public Deck()
        {
            //for (int i = 1; i < 14; i++)
            //{
            //    this.Cards.Add(new Card(Suite.Clubs, i));
            //    this.Cards.Add(new Card(Suite.Diamonds, i));
            //    this.Cards.Add(new Card(Suite.Hearts, i));
            //    this.Cards.Add(new Card(Suite.Spades, i));
            //}

            var query =
                from suit in Enum.GetValues(typeof(Suite)).Cast<Suite>()
                //from suit in new[] { Suite.Clubs, Suite.Hearts, Suite.Spades, Suite.Diamonds }
                from rank in Enumerable.Range(1, 13)
                select new Card(suit, rank);

            this.cards = query.ToList();
        }

        public void Shuffle()
        {
            Console.WriteLine($"Shuffling the deck...");
            Random random = new Random();
            
            for (int n = this.cards.Count - 1; n > 0; --n)
            {
                int k = random.Next(n + 1);
                Card temp = this.cards[n];
                this.cards[n] = this.cards[k];
                this.cards[k] = temp;
            }
        }

        public void AddCards(IEnumerable<Card> cards)
        {
            this.cards.AddRange(cards);
        }

        public Card DealOne()
        {
            Card cardToDeal = this.cards[0];
            this.cards.RemoveAt(0);                     
            return cardToDeal;
        }
    }
}
