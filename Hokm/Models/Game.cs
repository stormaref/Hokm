using System;
using System.Collections.Generic;

namespace Hokm.Models
{
    public class Game
    {
        public List<Round> Rounds { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public bool IsRunning { get; set; }

        public Game()
        {
        }
    }
}
