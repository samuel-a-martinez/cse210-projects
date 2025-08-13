public abstract class Activity
{
    private DateTime _date;
    private int _minutes;
    private string _activityType;

    public Activity(DateTime date, int minutes, string activityType)
    {
        _date = date;
        _minutes = minutes;
        _activityType = activityType;
    }

    public DateTime GetDate() => _date;
    public int GetMinutes() => _minutes;
    public string GetActivityType() => _activityType;

    // Abstract methods to be overridden by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method to be overridden if needed
    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} {_activityType} ({_minutes} min) - " +
               $"Distance: {GetDistance():F2} km, " +
               $"Speed: {GetSpeed():F2} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }
}
