using System.Collections.Generic;

namespace Hokm.Models
{
    public class Circle : BaseEntity
    {
        public Player StarterPlayer { get; set; }
        public List<Hand> Hands { get; set; }
        public bool IsRunning { get; set; }
        public Player Winner { get; set; }
        public Circle(Player starterPlayer)
        {
            StarterPlayer = starterPlayer;
            IsRunning = true;
            Hands = new List<Hand>();
        }
    }
}