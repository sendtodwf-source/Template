public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity( string name, string desc, int duration)
    {
        _name = name;
        _description = desc;
        _duration = duration;
    }

    public void ShowPrologue()
    {   
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        ShowSpinner(1);
    }
    public void ShowEpilogue()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        Thread.Sleep(3000);
        ShowSpinner(1);
    }

        public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void ShowSpinner(int duration)
    {
        string [] an1= ["|", "/", "-", "\\"];
        int count = duration * 4;
        int cur = 0;
        for (int i = 0; i < count; i++)
        {
            cur = i % 4;
            Console.Write(an1[cur]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
        Console.Write(" ");
    }

}