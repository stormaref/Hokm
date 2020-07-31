using Hokm.Models;
using Microsoft.AspNetCore.Mvc;
using Hokm.Tools;

namespace Hokm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        public IActionResult Home()
        {
            var team1 = new Team(new Player(),new Player());
            var team2 = new Team(new Player(), new Player());
            var game = new Game(team1, team2);
            game.ShuffleCards();
            var players = game.GetPlayers();
            return Ok(players);
        }
    }
}
