public class SimpleGoal: Goal
{
    private string _title;
    private string _desc;
    private int _points;
    private bool _complete;

    public SimpleGoal(string title, string desc, int points, bool complete): base(title, desc, points)
    {
        _title = title;
        _desc = desc;
        _points = points;
        _complete = complete;
    }

    public override string GetSaveString()
    {
        return $"Simple Goal:{_title},{_desc},{_points},{_complete}";
    }

    public override void Display()
    {
        string x = " ";
        if(_complete)
        {
            x = "x";
        }
        else
        {
            x = " ";
        }
        Console.WriteLine($"[{x}] {_title} ({_desc})");
    }

    public override int Progress() 
    {
        _complete = true;
        return _points;
    }

}