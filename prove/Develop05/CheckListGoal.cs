public class CheckListGoal: Goal
{
    private string _title;
    private string _desc;
    private int _points;
    private int _bonus;
    private int _tallyAmt;
    private int _tallyDone;

    public CheckListGoal(string title, string desc, int points, int bonus, int tally): base(title, desc, points)
    {
        _title = title;
        _desc = desc;
        _points = points;
        _bonus = bonus;
        _tallyAmt = tally;
    }

    public override string GetSaveString()
    {
        return $"Simple Goal: {_title}, ({_desc},{_points},{_bonus},{_tallyAmt},{_tallyDone})";
    }

    public override void Display()
    {
        string x = " ";
        string progTrack = "Incomplete x/y times";
        if(_tallyDone < _tallyAmt)
        {
            x = " ";
            progTrack = $"- Incomplete {_tallyDone}/{_tallyAmt} times";
        }
        else
        {
            x = "x";
            progTrack = $"- Complete {_tallyDone}/{_tallyAmt} times";
        }
        Console.WriteLine($"[{x}]{_title} ({_desc}) {progTrack}");
    }

    public override int Progress() 
    {
        _tallyDone++;
        if(_tallyDone < _tallyAmt)
        {
            return _points;
        }
        else
        {
            return _points + _bonus;
        }
        
    }
}