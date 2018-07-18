using System;
using System.ComponentModel;

namespace OptimisedGolf.Models
{
    public class Hole
    {
        [DisplayName("par for this hole")]
        public int Par { get; set; }

        //public Player Dealer { get; set; }

        public Hole()
        {
            
        }

        public Hole(int par)//, Player dealer)
        {
            this.Par = par;
        }
    }
}
