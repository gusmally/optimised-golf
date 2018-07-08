using System;
using System.Collections.Generic;

namespace OptimisedGolf.Models
{
    public class Player
    {
        public string Name { get; private set; }
        
        public bool HasMulligan { get; set; }

        public List<Card> Hand { get; set; } = new List<Card>();

        public int Score { get; set; }

        public Player(string name)
        {
            this.Name = name;
            this.HasMulligan = false;
        }

        public void Peek(int[] cardsToPeek)
        {
            Console.WriteLine($"Player {this.Name} peeked at:");

            foreach(int i in cardsToPeek) // does this work?
            {
                this.Hand[i].State = CardState.Known;
                Console.WriteLine(this.Hand[i].PrettyPrint());
            }
        }

        public Action<Card> ChooseFirst(ChoiceOne choice)
        {
            switch (choice)
            {
                case ChoiceOne.DontRevealCard:
                    return null;
                case ChoiceOne.RevealCard:
                    return (card => this.revealCard(card));
                default:
                    return null;
            }
        }

        public void ChooseSecond(ChoiceTwo choice)
        {
            //switch(choice)
            //{
            //    case ChoiceTwo.ReplaceKnown:

            //}
            return;
        }

        private void revealCard(Card card)
        {
            this.Hand.Find(m => m.Equals(card)).State = CardState.Revealed;
        }
    }
}
