public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes, "Swimming")
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
    
    // Override the summary to include a different measurement system.
    public override string GetSummary()
    {
        double distanceMiles = GetDistance() * 0.62;
        double paceMiles = GetMinutes() / distanceMiles;
        double speedMph = (distanceMiles / GetMinutes()) * 60;

        return $"{GetDate().ToShortDateString()} {GetActivityType()} ({GetMinutes()} min) - " +
               $"Distance: {GetDistance():F2} km ({distanceMiles:F2} miles), " +
               $"Speed: {GetSpeed():F2} kph ({speedMph:F2} mph), " +
               $"Pace: {GetPace():F2} min per km ({paceMiles:F2} min per mile)";
    }
}