public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date { get { return _date; } }
    public int Minutes { get { return _minutes; } }

    public abstract double GetDistance();
    public abstract double GetSpeed(); 
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {this.GetType().Name} ({Minutes} min) - " +
               $"Distance {GetDistance():F2} miles, " +
               $"Speed {GetSpeed():F2} mph, " +
               $"Pace: {GetPace():F2} min per mile";
    }
}
