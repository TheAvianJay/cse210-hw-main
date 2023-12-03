public class Repentance : Goals
{
    private int _timesPerWeek;
    private int _threshold;

    public Repentance(int timesPerWeek, int points = 1000) : base (points)
    {
        _timesPerWeek = timesPerWeek;
        _threshold = 7;
    }
    
    public override bool IsComplete()
    {
        return _timesPerWeek >= _threshold;
    }

    public override string DisplayName()
    {
        return "Repentance";
    }

    public override int CalculatePoints()
    {
        return _timesPerWeek * GetPoints();
    }

}