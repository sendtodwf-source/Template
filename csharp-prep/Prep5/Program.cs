using System;


class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static void PromptUserName(out string name)
    {
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
    }
        static void PromptUserNumber(out string number)
    {
        Console.Write("Please enter your favorite number: ");
        number = Console.ReadLine();
    }
        static void PromptUserBirthYear(out string birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = Console.ReadLine();
    }
        static void SquareNumber(string name, ref int sqNum)
    {
        sqNum = sqNum * sqNum;

    }
        static void DisplayResult(string name, int sqNumPass, int birthYear)
    {
        int yearsOld = DateTime.Now.Year - birthYear;
        Console.WriteLine($"{name}, the square of your number is {sqNumPass}");        
        Console.WriteLine($"{name}, you will turn {yearsOld} this year.");
    }

    static void Main(string[] args)
    {
        //declaring user variables
        string name;
        string number;
        string birthYear;

        //declaring local integer conversions
        int sqNumPass = 0;
        int byPass = 0;

        //calling functions
        DisplayWelcome();
        PromptUserName(out name);
        PromptUserNumber(out number);
        //string to int conversion
        sqNumPass = int.Parse(number);
        PromptUserBirthYear(out birthYear);
        //string to int conversion
        byPass = int.Parse(birthYear);
        //squaring user's favorite number and displaying info
        SquareNumber(name, ref sqNumPass);
        DisplayResult(name, sqNumPass, byPass);

    }
}