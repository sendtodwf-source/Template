public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>(); //All of the initial Prompts
    private List<string> followUp = new List<string>(); //All of the follow up questions
    private List<bool> chosenFs = new List<bool>(); //A list of boolean values that can tell the program if a follow-UP question has already been selected
    bool run; // A way for the program to know if it should keep running
    string chosen; //The prompt
    public ListingActivity (string name, string desc, int duration): base(name, desc, duration)
    {
        prompts = ["Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"];
        chosen = "";
        
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
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine($"--- {chosen} ---\n");
        Console.WriteLine("When you are ready press enter to continue");
        Console.ReadLine(); // Wait for user to press enter to continue
        
        for(int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(_duration);
        currentTime = DateTime.Now;

        int count = 0;
        while (currentTime < futureTime) // while loop that keeps asking the user to respond to follow-up questions
        {    
            Console.Write("> ");
            Console.ReadLine();
            currentTime = DateTime.Now;
            count ++;
        }
        Console.WriteLine($"You listed {count} items!");
        ShowEpilogue();
        

        Console.Clear();
    }
}