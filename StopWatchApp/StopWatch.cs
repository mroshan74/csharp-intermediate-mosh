namespace StopWatchApp;

public class StopWatch
{
    private DateTime _startTime;
    private DateTime _endTime;
    private TimeSpan _duration;
    private bool _isRunning;

    public void Start()
    {
        if (_isRunning)
        {
            throw new InvalidOperationException("Stopwatch is already running !!");
        }
        _startTime = DateTime.Now;
        _isRunning = true;
    }

    public void Stop()
    {
        if (!_isRunning)
        {
            throw new InvalidOperationException("Stopwatch is not started !!");
        }
        _endTime = DateTime.Now;
        _isRunning = false;
    }

    public TimeSpan Duration()
    {
        _duration = _endTime - _startTime;
        return _duration;
    }
}