using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction = new Fraction();
        Random rand = new Random();

        for (int i = 0; i < 20; i ++)
        {
            myFraction.SetTop(rand.Next(1, 50));
            myFraction.SetBottom(rand.Next(1,50));
            Console.WriteLine($"Fraction: {i+1} String: {myFraction.GetFractionString()} Number: {myFraction.GetTop()}");

        }
        // double red = 0;
        // Console.WriteLine(myFraction.GetFractionString());
        // myFraction.SetTop(2);
        // Console.WriteLine();
        // myFraction.SetBottom(2);
        // Console.WriteLine(myFraction.GetFractionString());
        // myFraction.SetTop(2);
        // Console.WriteLine(myFraction.GetDecimalValue());
        // myFraction.SetTop(8);
        // Console.WriteLine(myFraction.GetTop());
        // myFraction.SetTop(2);
        // Console.WriteLine(myFraction.GetBottom());


    }
}