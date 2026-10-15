//set up namespace for file proccessing
using System.IO;
public class Journal // class declaration
{
    public List<Entry> _entries = new List<Entry>(); // Attrubute: Entry data type 'List', holds all entries that will be uploaded to Journal.txt
    List<String> _prompts = new List<string>(); // Attribute: List of string data that holds all prompts to be fused and formatted later before sending to Journal.txt

    public void AddEntry() //Behavior: Add a journal entry, prompts user to respond to a random prompt selected from the 'Prompts.txt' file located in the projects 'bin' folder under local folder 'Develop02'
    {
        string promptsFile = "prompts.txt";
        string[] lines = System.IO.File.ReadAllLines(promptsFile);
        Random randNum = new Random(); //create a random number class instance
        int topRange = lines.Count(); //Don't get any random number larger than the length of info in file. > select only available info
        string currentPrompt ="";
        if (topRange >= 1) // if Statement > get available info in our file > prompt user
        {
        int random = randNum.Next(0, topRange); //get and integer from class instance
        currentPrompt = lines[random]; //choose a prompt
        Console.WriteLine(currentPrompt);
        }
        else // > add a custom prompt if there there are no prompts available on file
        {
            Console.WriteLine(@"There is no prompt do display, 
Add your own prompt.");
            AddPrompt();//this prompts the user to add a prompt of their own
        }

        string userRes = Console.ReadLine(); //get the user response

        AddNonRandEntry(currentPrompt, userRes); // update Journal class 'Entry' data list
    }
        public void AddNonRandEntry (string prompt, string entry) //Appends data to our Journals entry and adds a date stamp
    {
        Entry entrySend = new Entry();
        DateTime today = DateTime.Now; //get todays date
        string dateText = today.ToShortDateString();

        entrySend._date = dateText; // stamp date
        entrySend._prompt = prompt;
        entrySend._response = entry;
        
        _entries.Add(entrySend);
    }
        public string[] LoadFile(string fileName) // return file info from a file the program enters > this program handles the name of the file and generally asks the user with the GetFileName method
    {
        Entry entrySend = new Entry();
        fileName = $@"{fileName}";
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
    public void SaveToFile(string fileName) // saves Journal class 'Entry' data to passed file | filename > Journal > format info > save |
    {
        fileName = @$"{fileName}";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
            outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            Console.WriteLine("saved");
            }
        }
    }
        public void DisplayEntries() // Display the entries that are currently saved in the Journal class (includes all loaded info as loading appends information to the Journal's 'Entry' data)
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

    public string GetFileName() // Prompts user and requests a file name and extention
    {
        Console.WriteLine("What is the name of the file?");
        string journalFile = Console.ReadLine();
        return journalFile;
    }
    public void AddPrompt() // Add a prompt to the Journal's _prompt's list
    {
        string promptsFile = GetFileName();
    
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
        AddNonRandEntry(userIn, userResp); // finishes by updating the Journal's 'Entry' data

    }

}