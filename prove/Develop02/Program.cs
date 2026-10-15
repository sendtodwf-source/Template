//namespaces
using System;
using System.Collections.Generic;
using System.IO;
// Program class
class Program
{
    static void Main(string[] args) // main loop
    {
        Journal myJournal = new Journal();
        DateTime today = DateTime.Now;
        string dateText = today.ToShortDateString();
        bool run = true;

while(run){ // Runs till user terminates program by selecting 6
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
            string response = Console.ReadLine(); // get user input for selection
            int choice;
            while (! int.TryParse(response, out choice)) // input validation
            {
                Console.Write("invalid try again: "); //prompt user until valid
                response = Console.ReadLine(); // take user input
            }
            // Check user response for validation
            if(choice == 1)
            {
                myJournal.AddEntry();//this adds an "Entry" do our list of entries
            }
            if(choice == 2)
            {
                myJournal.DisplayEntries();// this displays all loaded entries from file that user selects
            }
            if(choice == 3)
            {
                myJournal.LoadFile(myJournal.GetFileName());// this will load a Journal text file in a 3 spaced format. See Journal.cs for explanation
            }
            if(choice == 4)
            {
                myJournal.SaveToFile(myJournal.GetFileName()); // Save user responses
            }
            if(choice == 5)
            {
                myJournal.AddPrompt(); // add a custom prompt to which the user sequentially responds
            }
            if(choice == 6)
            {
                run = false; // terminate program
            }
        }
    }
}

