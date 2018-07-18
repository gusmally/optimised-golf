using System;
using System.Collections.Generic;

namespace OptimisedGolf.Models
{
    public class DiscardPile
    {
        private List<Card> discardPile = new List<Card>();

        public DiscardPile()
        {
        }

        public void Discard(Card card)
        {
            this.discardPile.Add(card);
        }

        /// <summary>
        /// Takes the entire discard pile and returns it to the caller, 
        /// emptying the discard pile
        /// </summary>
        /// <returns>The cards that were in the discard pile.</returns>
        public IEnumerable<Card> TakeAll()
        {
            List<Card> returnList = new List<Card>();
            returnList.AddRange(this.discardPile);

            this.discardPile.Clear();

            return returnList;
        }
    }
}
