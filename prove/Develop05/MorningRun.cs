public class MorningRun : Goals
{
    private int _distance;

    public MorningRun(int points, int distance) : base (points)
    {
        _distance = distance;
    }

    public override string DisplayName()
    {
        return "MorningRun";
    }

    public override int CalculatePoints()
    {
        return _distance * GetPoints();
    }
}