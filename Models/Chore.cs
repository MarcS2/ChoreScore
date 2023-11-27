


namespace ChoreScore.Models;

public class Chore
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }

    public Chore(int id, string title, string body)
    {
        Id = id;
        Title = title;
        Body = body;
    }
}


