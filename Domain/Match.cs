namespace Domain;


public class Match
{
    public int ID { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string Ground { get; set; }
    public string Visitor { get; set; }
    public string Local { get; set; }
    public int VisitorScore { get; set; }
    public int LocalScore { get; set; }

}