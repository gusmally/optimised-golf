using System;
namespace OptimisedGolf.Models
{
    public class Card
    {
        public Suite Suite { get; private set; }

        public int Rank { get; private set; }

        public CardState State { get; set; }

        public Card(Suite suite, int rank)
        {
            this.Suite = suite;
            this.Rank = rank;
            this.State = CardState.Unrevealed;
        }

        public string PrettyPrint()
        {
            return $"{this.Suite} {this.Rank}";
        }

        public string PrettyPrintWithState()
        {
            return $"{this.Suite} {this.Rank} {this.State}";
        }
    }
}
