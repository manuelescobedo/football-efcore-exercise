using Microsoft.AspNetCore.Mvc;
using Infrastructure.Persistence;
using API.DTOs;

namespace API.Controllers;


[ApiController]
[Route("[controller]")]
public class TeamsController : ControllerBase
{

    public TeamsController()
    {
    }

    [HttpGet("stats")]
    public IEnumerable<TeamStatsDTO> GetStats()
    {
        using (AppDbContext ctx = new AppDbContext())
        {
            ctx.Database.EnsureCreated();

            return ctx.Stats.ToList().Select((x) => new TeamStatsDTO
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
