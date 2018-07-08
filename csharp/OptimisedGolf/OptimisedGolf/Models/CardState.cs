using System;
namespace OptimisedGolf.Models
{
    public enum CardState
    {
        Revealed, //(to all players)

        Unrevealed, //(unknown to all players)

        Known //(only to the owner of the card)
    }
}
