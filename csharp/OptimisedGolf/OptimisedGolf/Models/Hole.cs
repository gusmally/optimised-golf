using System;
namespace OptimisedGolf.Models
{
    public class Hole
    {
        public int Par { get; set; }

        public Player Dealer { get; set; }

        public Hole(int par, Player dealer)
        {
            this.Par = par;
        }


    }
}
