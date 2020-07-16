using System;
namespace Hokm.Models
{
    public class Team
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public int Score { get; set; }

        public Team()
        {
        }
    }
}
