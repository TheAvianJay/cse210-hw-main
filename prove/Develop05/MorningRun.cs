public class MorningRun : Goals
{
    private int _distance;
    private int _threshold;

    public MorningRun(int distance, int points = 200) : base (points)
    {
        _distance = distance;
        _threshold = 10;
    }
    public override bool IsComplete()
    {
        return _distance >= _threshold;
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