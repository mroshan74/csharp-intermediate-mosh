namespace PostVoterApp;

public class PostControl
{
    public string Title;
    public string Description;
    public DateTime CreatedAt = DateTime.Now;
    private int _votes;

    public PostControl(string title, string description)
    {
        Title = title;
        Description = description;
    }

    public void UpVote()
    {
        _votes++;
    }

    public void DownVote()
    {
        _votes--;
    }

    public int GetVotes()
    {
        return _votes;
    }
}