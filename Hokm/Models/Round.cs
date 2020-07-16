using System;
namespace Hokm.Models
{
    public class Round
    {
        public Team Winner { get; set; }
        public Player StarterPlayer { get; set; }
        public Hand Hand1 { get; set; }
        public Hand Hand2 { get; set; }
        public Hand Hand3 { get; set; }
        public Hand Hand4 { get; set; }
    }
}
