public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract string GetActivity();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} {GetActivity()} ({GetMinutes()} min): Distance {GetDistance():F1}km, Speed: {GetSpeed():F1}kph, Pace: {GetPace():F1} min per km";
    }
}