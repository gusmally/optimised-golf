using System;
using System.Collections.Generic;

namespace OptimisedGolf.Models
{
    public class PlayerFactory
    {
        // TODO: restrict the number of players in the form and elsewhere 
        // so we don't have to worry about running out of names here.
        private List<string> playerNames = new List<string>
        {
            "Fernie",
            "Aloe",
            "Aloe jr.",
            "Money Tree",
            "Bonsai",
            "Snake Plant",
            "Basil",
            "Vine Boy",
            "Purple Boy"
        };

        public PlayerFactory()
        {
			
        }

        public List<Player> CreatePlayers(int numberOfPlayers)
        {
            List<Player> newPlayers = new List<Player>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                newPlayers.Add(new Player(this.playerNames[i]));
            }

            return newPlayers;
        }
    }
}
