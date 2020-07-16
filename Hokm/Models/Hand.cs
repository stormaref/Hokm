using System;
namespace Hokm.Models
{
    public class Hand
    {
        public Player Player { get; set; }
        public Cards.Card Card { get; set; }

        public Hand()
        {
        }
    }
}
