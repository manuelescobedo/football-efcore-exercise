using Microsoft.AspNetCore.Mvc;
using Infrastructure.Persistence;
using API.DTOs;
using System.Linq;

namespace API.Controllers;


[ApiController]
[Route("[controller]")]
public class MatchesController : ControllerBase
{

    public MatchesController()
    {
    }

    [HttpGet(Name = "GetMatches")]
    public IEnumerable<MatchDTO> Get()
    {
        using (AppDbContext ctx = new AppDbContext())
        {
            ctx.Database.EnsureCreated();

            return ctx.Stats.ToList().Select((x) => new MatchDTO
            {
                Team = x.Team,
                MatchesPlayed = x.Games,
                Wins = x.Wins,
                Draws = x.Draws,
                Loses = x.Losts,
                GoalsInFavor = x.GoalsInFavor,
                GoalsAgainst = x.GoalsAgainst,
                GoalsDifference = x.GoalsDiff,
                Points = x.Points
            });
        }
    }
}
