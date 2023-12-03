public class Repentance : Goals
{
    private int _timesPerWeek;

    public Repentance(int points, int timesPerWeek) : base (points)
    {
        _timesPerWeek = timesPerWeek;
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