using System;
using System.Collections.Generic;

namespace OptimisedGolf.Models
{
    public class Game
    {
        private Hole[] holes;
        private List<Player> players = new List<Player>();
        private List<Player>.Enumerator playerEnumerator;
        private Deck deck = new Deck();

        public Game(int numberOfPlayers, bool fullGame) //take total number of players, user is the only one making choices, others are defined randomly or something
        {
            Console.WriteLine($"Starting new game with {(fullGame ? 9 : 18)} holes.");

            this.holes = new Hole[9];

            this.players.AddRange(players);
            Console.WriteLine($"Players: {this.players.ToString()}");

            this.holes = fullGame ? new Hole[18] : new Hole[9];
            //fullGame == true ? this.holes = new Hole[18] : this.holes = new Hole[9];

            this.playerEnumerator = this.players.GetEnumerator();

            this.deck.Shuffle();

            // a hole
            for (int i = 0; i < this.holes.Length; i++)
            {
                Console.WriteLine($"Starting Hole #{i + 1}...");
                Console.WriteLine();
                
                //prompt for par
                int PLACEHOLDEPAR = 3;
                this.holes[i] = new Hole(PLACEHOLDEPAR, this.playerEnumerator.Current);

                // in reality the dealer should be "doing" this
                for (int j = 0; j < PLACEHOLDEPAR; j++)
                {
                    foreach (Player player in this.players)
                    {
                        player.Hand.Add(this.deck.DealOne());
                    }
                }

                foreach(Player player in this.players)
                {
                    Console.WriteLine($"Dealt player {player.Name} cards:");

                    for (int j = 0; j < PLACEHOLDEPAR; j++)
                    {
                        Console.WriteLine(player.Hand[j].Suite + " " + player.Hand[j].Rank);
                    }

                    Console.WriteLine();
                }

                // players get to look at (know) some cards
                // prompt for cardsToPeek for each player
                int[] CARDSTOPEEK = new int[1]; // because of the hardcoded par
                CARDSTOPEEK[0] = 1; // hardcoded middle card
                this.players.ForEach(a => a.Peek(CARDSTOPEEK));

                Console.WriteLine();

                this.playerEnumerator.MoveNext(); // player to left of dealer goes first

                //player chooses 
                ChoiceOne firstChoice = ChoiceOne.RevealCard;
                this.players.ForEach(a => a.ChooseFirst(firstChoice));
                ChoiceTwo choiceTwo = ChoiceTwo.RevealKnown;
                this.players.ForEach(a => a.ChooseSecond(choiceTwo));

                //etc.

                // score

                // new hole
                this.playerEnumerator.MoveNext();
            }
//            Each hole, one of the players acts as a dealer.The dealer's only job is to deal the cards at the beginning of the hole. The dealer for the next hole is the person to the left of the current dealer.

//At the start of each hole, the dealer deals each player / par / cards.

//During each hole, each player may look at a certain number of cards they've been dealt, depending on the hole's par. When a player looks at the cards, the cards become known to that player.

//For a par 5, players may look at two of their cards.

//For a par 4, players may look at two of their cards.

//For a par 3, players may look at one of their cards.

//In real life, a player may only look at his / her cards once per hole. If the player forgets his / her cards, he / she can use a mulligan(only one per player per game) to look at the cards again.

//The player to the left of the dealer goes first. During the first round, the first player must:

//            1.Reveal a card from the top of the deck, placing it in the discard pile, or

//       not reveal a card


//2.Reveal one of their known cards, keeping it in their possession, or


       // reveal one of their unrevealed cards, keeping it in their possession, or


       // replace one of their known cards with the card at the top of the discard pile(if one exists), or

       //replace one of their unrevealed cards with the card at the top of the discard pile(if one exists)

        }
    }
}
