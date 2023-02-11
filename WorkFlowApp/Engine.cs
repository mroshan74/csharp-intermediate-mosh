namespace WorkFlowApp;

public class Engine
{
    public readonly IList<IWork> _work;

    public Engine()
    {
        _work = new List<IWork>();
    }

    public void Run()
    {
        foreach (var work in _work)
        {
            work.Execute();
        }
    }

    public void RegisterWork(IWork work)
    {
        _work.Add(work);
    }
}