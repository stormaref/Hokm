using System.Collections.Generic;
using Hokm.Models.Cards;

namespace Hokm.Models
{
    public class Player : BaseEntity
    {
        public List<Card> Cards { get; set; }

        public Player()
        {
        }
    }
}
