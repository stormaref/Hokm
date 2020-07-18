using System.Collections.Generic;

namespace Hokm.Models
{
    public class Game : BaseEntity
    {
        public List<Round> Rounds { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }

        public Game(Team team1, Team team2)
        {
            Team1 = team1;
            Team2 = team2;
            Rounds = new List<Round>();
        }
    }
}
