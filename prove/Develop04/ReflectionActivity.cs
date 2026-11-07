public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>(); //All of the initial Prompts
    private List<string> followUp = new List<string>(); //All of the follow up questions
    private List<bool> chosenFs = new List<bool>(); //A list of boolean values that can tell the program if a follow-UP question has already been selected
    bool run; // A way for the program to know if it should keep running
    string chosen; //The prompt
    string foUQ;
    public ReflectionActivity (string name, string desc, int duration): base(name, desc, duration)
    {
        prompts = ["Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."];
        followUp = ["Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"];
        chosenFs = []; // A list of boolean values that can tell the program if any of the options have already been selected
        chosen = "";
        foUQ = "";

        foreach (string cur in followUp)// setting the prompt tracker to empty (false values)
        {
            chosenFs.Add(true);
        }
        run = true; // Let's run this thing! Setting the Start method to a 'stand-by' mode
    }
    public void Start()
    {   
        Random rand = new Random(); //a random prompt number object
        int randH = rand.Next(0, prompts.Count()); // random number hold: getting the length of the prompts list and finding a random number in range
        chosen = prompts[randH];
        // \/ These are time managment variables \/
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        // /\ ------------------------------------/\

        ShowPrologue();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {chosen} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine(); // Wait for user to press enter to continue
        Console.Clear();
        Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        
        for(int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();

        Random randF = new Random(); //a random prompt number object
        int randFH = rand.Next(0, chosen.Count());
        bool flag = false;
        int cnt = 0;

        foUQ = followUp[randFH];

        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(_duration);
        currentTime = DateTime.Now;
        
        while (currentTime < futureTime) // while loop that keeps asking the user to respond to follow-up questions
        {    
            run = true;
            randFH = rand.Next(0, chosenFs.Count());
            while (run) // This is to make sure we don't get the same follow up question twice
            {
                flag = chosenFs[randFH];
                if(flag)
                {
                    foUQ = followUp[randFH];
                    run = false;
                    chosenFs[randFH] = false;
                }
                else
                {
                    run = true;
                }
                foreach(bool check in chosenFs)
                {
                    if (check)
                    {
                    cnt++;
                    }
                }
                if (cnt >= chosenFs.Count())// set all to true if all are false
                {
                    for(int l = 0; l < chosenFs.Count(); l ++)
                    {
                        chosenFs[l] = true;
                    }
                }    
            }
            Console.WriteLine($"> {foUQ}");
            ShowSpinner(5);
            currentTime = DateTime.Now;
        }
        // make a loop that can select which one to choose, hoping that none have been chosen twice
        // show prompt
        // take user input
        // if all have been chosen then we can set all to 'false'
        ShowEpilogue();
        

        Console.Clear();
    }
}