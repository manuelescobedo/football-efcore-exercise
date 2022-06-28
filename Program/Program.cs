using Domain;
using Infrastructure.Persistence;

namespace Program;

public static class Program
{
    static void Main(string[] args)
    {
        using (AppDbContext ctx = new AppDbContext())
        {
            ctx.Database.EnsureCreated();

            List<TeamStats> list = ctx.Stats.ToList();

            Console.WriteLine(@"""Team"",""Matches Played"",""Wins"",""Draws"",""Loses"",""Goals In Favor"",""Goals Against"",""Goals Difference"",""Points""");
            for (int i = 1, len = list.Count; i <= len; i += 1)
            {
                TeamStats item = list[i - 1];
                Console.WriteLine($@"""{item.Team}"",""{item.Games}"",""{item.Wins}"",""{item.Draws}"",""{item.Losts}"",""{item.GoalsInFavor}"",""{item.GoalsAgainst}"",""{item.GoalsDiff}"",""{item.Points}""");
            }
        }
    }
}