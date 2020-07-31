using Hokm.Models;
using Hokm.Models.Cards;
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

        private static Player GetNextPlayer(List<Player> players, Player player)
        {
            int index = (players.FindIndex(p => p.Id == player.Id) + 1) % 4;
            return players.ElementAt(index);
        }

        public static void ShuffleCards(this Game game)
        {
            var players = game.GetPlayers();
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    var card = new Card((Badge)i, (Sign)j);
                    cards.Add(card);
                }
            }
            cards = cards.OrderBy(c => Guid.NewGuid()).ToList();
            players[0].Cards = cards.Take(13).ToList();
            players[1].Cards = cards.Skip(13).Take(13).ToList();
            players[2].Cards = cards.Skip(26).Take(13).ToList();
            players[3].Cards = cards.Skip(39).Take(13).ToList();
        }
    }
}
