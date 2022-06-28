namespace Domain;

public class TeamStats
{
    public string Team { get; set; }
    public int Games { get; set; }
    public int Wins { get; set; }
    public int Draws { get; set; }

    public int Losts { get; set; }
    public int Points { get; set; }
    public int GoalsInFavor { get; set; }
    public int GoalsAgainst { get; set; }
    public int GoalsDiff { get; set; }
}
