using Hokm.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hokm.Tools
{
    public static class StaticTools
    {
        public static List<Player> GetPlayers(this Game game) => new List<Player>
            {
                game.Team1.Player1,
                game.Team1.Player2,
                game.Team2.Player1,
                game.Team2.Player2
            };

        public static Player GetNextPlayer(this Game game)
        {
            var lastRound = game.Rounds.Last();
            if (lastRound.Circles.Count == 0)
                return lastRound.Hakem;
            var lastCircle = lastRound.Circles.Last();
            if (!lastCircle.IsRunning)
                throw new Exception("Last circle is finished");
            if (lastCircle.Hands.Count == 0)
                return lastCircle.StarterPlayer;
            return GetNextPlayer(game.GetPlayers(), lastCircle.Hands.Last().Player);
        }
        public static Player GetNextPlayer(List<Player> players, Player player)
        {
            int index = (players.FindIndex(p => p.Id == player.Id) + 1) % 4;
            return players.ElementAt(index);
        }
    }
}
