namespace API.DTOs
{
    public class MatchDTO
    {
        public string Team { get; set; }
        public int MatchesPlayed
        {
            get; set;
        }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
        public int GoalsInFavor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalsDifference { get; set; }
        public int Points { get; set; }

    }
}