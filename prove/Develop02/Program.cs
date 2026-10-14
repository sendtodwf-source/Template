using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        //List<Entry>entries = new List<Entry>();
        //Entry currentEntry = new Entry();
        DateTime today = DateTime.Now;
        string dateText = today.ToShortDateString();
        bool run = true;
    //     currentEntry._date = dateText;

    //     entries.Add(currentEntry);

    //     Console.WriteLine(entries[0]._date);

    //     myJournal.AddEntry(entries[0]);
    //     myJournal.SaveToFile();
    //     myJournal.DisplayEntries();
while(run){
            Console.WriteLine(@"
    Please Choose:
    1. Write
    2. Display
    3. Load
    4. Save
    5. Add Prompt
    6. Quit
            ");

            Console.Write("What would you like to do? ");
            string response = Console.ReadLine();
            int choice;
            while (! int.TryParse(response, out choice))
            {
                Console.Write("invalid try again: ");
                response = Console.ReadLine();
            }
            
            if(choice == 1)
            {
                myJournal.AddEntry();//this adds an "Entry" do our list of entries
            }
            if(choice == 2)
            {
                myJournal.DisplayEntries();
            }
            if(choice == 3)
            {
                myJournal.LoadFile(myJournal.GetFileName());
            }
            if(choice == 4)
            {
                myJournal.SaveToFile(myJournal.GetFileName());
            }
            if(choice == 5)
            {
                myJournal.AddPrompt();
            }
            if(choice == 6)
            {
                run = false;
            }

            //another funcion named try parse which will return a true or false depending on if it succeeds in converting the data type.




            /*string journalFile = "Journal.txt";
            string promptsFile = @"C:\CSE-210\Template\prove\Develop02\Prompts.txt";
            string firstName = "";
            string lastName = "";
            string[] lines = System.IO.File.ReadAllLines(promptsFile);
            string firstPrompt = "";
            string[] parts = [];

                foreach (string line in lines)
            {
                parts = line.Split(",");
                
            }
            firstName = parts[1];
            Console.WriteLine(firstName);
            */

        
        }
    }
}

