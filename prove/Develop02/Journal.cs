using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    List<String> _prompts = new List<string>();

    public void AddEntry()
    {
        //Entry entrySend = new Entry();
        string promptsFile = @"C:\CSE-210\Template\prove\Develop02\Prompts.txt";
        string[] lines = System.IO.File.ReadAllLines(promptsFile);
        Random randNum = new Random(); //create a random number class instance
        int topRange = lines.Count();
        string currentPrompt ="";
        if (topRange >= 1)
        {
        int random = randNum.Next(0, topRange); //get and integer from class instance
        currentPrompt = lines[random]; //choose a prompt
        Console.WriteLine(currentPrompt);
        }
        else
        {
            Console.WriteLine(@"There is no prompt do display, 
Add your own prompt.");
            AddPrompt();//this prompts the user to add a prompt of their own
        }

        string userRes = Console.ReadLine(); //get the user response
    
        DateTime today = DateTime.Now; //get todays date
        string dateText = today.ToShortDateString();

        AddNonRandEntry(currentPrompt, userRes);
    }
        public void AddNonRandEntry (string prompt, string entry)
    {
        Entry entrySend = new Entry();
        DateTime today = DateTime.Now; //get todays date
        string dateText = today.ToShortDateString();

        entrySend._date = dateText;
        entrySend._prompt = prompt;
        entrySend._response = entry;
        
        _entries.Add(entrySend);
    }
        public string[] LoadFile(string fileName)
    {
        Entry entrySend = new Entry();
        fileName = $@"C:\CSE-210\Template\prove\Develop02\{fileName}";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string [] info = line.Split("|");
            entrySend._date = info[0];
            entrySend._date = info[1];
            entrySend._date = info[2];
        }

        return lines;
    }
    public void SaveToFile(string fileName)
    {
        fileName = @$"C:\CSE-210\Template\prove\Develop02\{fileName}";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
            outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            Console.WriteLine("saved");
            }
        }
    }
        public void DisplayEntries()
    {
        string journalFile = GetFileName();
        string[] lines = LoadFile(journalFile);

        foreach (string line in lines)
        {
            string [] info = line.Split("|");
            for(int i = 0; i < info.Count(); i++)
            {
            Console.WriteLine(info[i]);
            }
            Console.WriteLine("");
        }
    }

    public string GetFileName()
    {
        Console.WriteLine("What is the name of the file?");
        string journalFile = Console.ReadLine();
        return journalFile;
    }
    public void AddPrompt()
    {
        string promptsFile = GetFileName();
        
        promptsFile = $@"C:\CSE-210\Template\prove\Develop02\{promptsFile}";
        string[] lines = System.IO.File.ReadAllLines(promptsFile);
        string userIn = "";

        using (StreamWriter outputFile = File.AppendText(promptsFile))
        {
            Console.WriteLine("What is your custom prompt that you would like to add?");
            userIn = Console.ReadLine();
            outputFile.WriteLine($"{userIn}");
        }
        Console.WriteLine("Add your response");
        string userResp = Console.ReadLine();

        Console.WriteLine("Let's add that to your journal");
        AddNonRandEntry(userIn, userResp);

    }

}