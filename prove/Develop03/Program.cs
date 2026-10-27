using System;

class Program
{
    static void Main(string[] args)
    {
        List<Word> words = new List<Word>();//The list of all the words
        string input = "";
        bool allHidden = false;
        //Below are all the variables that we use to create a scripture object.
        string book = "2 Nephi";
        int chapter = 32;
        int sVerse = 3;
        int eVerse = 5;
        string text = @"3 Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do. 

4 Wherefore, now after I have spoken these words, if ye cannot understand them it will be because ye ask not, neither do ye knock; wherefore, ye are not brought into the light, but must perish in the dark.";
        
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Thread.Sleep(2000);
        Console.Clear();
        Reference rf = new Reference(book, chapter, sVerse, eVerse);
        Scripture scr = new Scripture(text, rf);
        while(input != "quit" || !allHidden)//while the user doesn't click "quit" but we pause at the end waiting for the user to press "enter"
        {
            scr.Display();
            Console.WriteLine("\n \nPress enter to continue or type 'quit' to finish");
            input = Console.ReadLine();
            if (input != "quit")
            {
                Console.Clear();
                allHidden = scr.Hide();
            }
        }
    }
}