namespace Hokm.Models.Cards
{
    public class Card : BaseEntity
    {
        public Badge Badge { get; set; }
        public Sign Sign { get; set; }

        public Card(Badge badge, Sign sign)
        {
            Badge = badge;
            Sign = sign;
        }
    }
}
