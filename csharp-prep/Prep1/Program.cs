using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        string first = "null";
        string last = "null";
        Console.Write("What is your first name? ");
        first = Console.ReadLine();
        Console.Write("What is your last name? ");
        last = Console.ReadLine();
        Console.WriteLine($"Your name is {first}, {first} {last}.");

    }
}