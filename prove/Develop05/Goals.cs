public abstract class Goals
{
    private int _points;

    public Goals(int points)
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

    public abstract bool IsComplete();
    public abstract string DisplayName();
    public abstract int CalculatePoints();
}