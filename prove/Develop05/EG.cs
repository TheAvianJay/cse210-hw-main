public abstract class EternalGoals
{
    private int _points;

    public EternalGoals(int points)
    {
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public abstract int CalculatePoints();
}