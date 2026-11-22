public class EternalGoal: Goal
{
    private string _title;
    private string _desc;
    private int _points;

    public EternalGoal(string title, string desc, int points): base(title, desc, points)
    {
        _title = title;
        _desc = desc;
        _points = points;
    }

    public override string GetSaveString()
    {
        return $"Eternal Goal:{_title},{_desc},{_points}";
    }

}