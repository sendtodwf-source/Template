using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        Random magicMaker = new Random();
        int magicNumber = magicMaker.Next(1,11);
        int numberInput = -1;

        string input = "-1";
        Console.WriteLine("What is the magic number? ");

        while (numberInput != magicNumber)
        {
            input = Console.ReadLine();
            numberInput = int.Parse(input);

            if (numberInput < magicNumber)
            {
            Console.WriteLine("Higher");
            }
            else if (numberInput > magicNumber)
            {
            Console.WriteLine("Lower");
            }
            else
            {
            Console.WriteLine("You guessed it!");
            }
        }



    }

}