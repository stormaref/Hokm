namespace Hokm.Models
{
    public class Team : BaseEntity
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public int Score { get; set; }

        public Team(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
            Score = 0;
        }
    }
}
