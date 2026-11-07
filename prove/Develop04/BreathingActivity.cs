public class BreathingActivity : Activity
{
    public BreathingActivity (string name, string desc, int duration): base(name, desc, duration)
    {
    }
    public void Start()
    {   
        ShowPrologue();
        ShowSpinner(3);
        List<double> bTimes = new List<double>();
        int bcounts = 0;
        double sum = 0;
        double naturalLog;

        while (sum < _duration)
        {
            naturalLog = Math.Log(10*(bcounts+1));
            sum = naturalLog + sum;
            bcounts += 1;
            bTimes.Add(naturalLog);
        }

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        int b = 0;
        int c = 1;
        foreach (double bTime in bTimes)
        {
            if (b%2==0)
            {
            Console.Write("\nBreath in...");
            }
            else
            {
                Console.Write("\nBreath out...");
            }

            startTime = DateTime.Now;
            futureTime = startTime.AddMilliseconds((int)(bTime*1000));
            c = 1;
            while (currentTime < futureTime)
            {
                Console.Write($"{c}");
                Thread.Sleep(1000);
                for (int i = 0; i < $"{c}".Count(); i++) // The adjust for how many digits there are that we need to break-line
                    {
                        Console.Write("\b");
                    }
                c++;
                currentTime = DateTime.Now;
                
            } 
            Console.Write(" "); 
            b ++;
        }  
        Console.Write("\n\n");
        ShowEpilogue();
        Console.Clear();

    }
}