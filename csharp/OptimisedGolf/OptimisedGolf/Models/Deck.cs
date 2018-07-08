using System;
using System.Collections.Generic;
using System.Linq;

namespace OptimisedGolf.Models
{
    public class Deck
    {
        private List<Card> cards;

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

        public Card DealOne()
        {
            if (this.cards.Any())
            {
                Card cardToDeal = this.cards[0];
                this.cards.RemoveAt(0);                     
                return cardToDeal;
            }

            throw new Exception(); //todo: exceptions shouldn't be used for control flow
        }
    }
}
