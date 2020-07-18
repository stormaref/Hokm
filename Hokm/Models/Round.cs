using System.Collections.Generic;

namespace Hokm.Models
{
    public class Round : BaseEntity
    {
        public Team Winner { get; set; }
        public Player Hakem { get; set; }
        public List<Circle> Circles { get; set; }
        public bool IsRunning { get; set; }
        public Round(Player hakem)
        {
            Hakem = hakem;
            Circles = new List<Circle>();
            IsRunning = true;
        }
    }
}
