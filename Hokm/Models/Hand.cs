using Hokm.Models.Cards;
namespace Hokm.Models
{
    public class Hand : BaseEntity
    {
        public Player Player { get; set; }
        public Card Card { get; set; }

        public Hand(Player player, Card card)
        {
            Player = player;
            Card = card;
        }
    }
}
