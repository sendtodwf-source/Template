public class Goal
{
    private string _title;
    private string _desc;
    private int _points;

    public Goal(string title, string desc, int points)
    {
        _title = title;
        _desc = desc;
        _points = points;
    }

    public virtual string GetSaveString()// This virtual method allows us to get a string that we can save to a .txt file
    {
        return $"SAMPLE Goal,{_title},{_desc},{_points}";
    }

    public virtual void Display()//This virtual method (meaning it is a default method if not overriden) will allow us to display the goal to prompt the user.
    {
        Console.WriteLine($"[∞] {_title} ({_desc})");
    }
    
    public virtual int Progress() // every time we make progress with our goal this will be use to get the amount that the goal can update by and append it to the running total in the main program.
    {
        // Check the point
        return _points;
    }
}